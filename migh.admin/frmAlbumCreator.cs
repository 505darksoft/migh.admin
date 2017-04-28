using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using migh.api;
using System.IO;
using TagLib;
using System.Web;
using System.Net;
using JsonTools;

namespace migh.admin
{
    public partial class frmAlbumCreator : Form
    {
        public frmAlbumCreator()
        {
            InitializeComponent();
        }

        private void frmAlbumCreator_Load(object sender, EventArgs e)
        {
            JsonFile file = new JsonFile();
            file.Directory = Application.StartupPath + "\\";
            file.FileName = "gh";
            txtGitHubFolder.Text = file.Read<string>();
        }

        List<Song> songs = new List<Song>();
        List<Album> albums = new List<Album>();
        List<Artist> artists = new List<Artist>();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            listSong.Items.Clear();
            string directory = txtDirectory.Text.Trim();
            songs = new List<Song>();
            Album album = new Album();
            Artist artist = new Artist();
            string path = txtDirectory.Text.Trim();
            
            try
            {
                foreach (string s in Directory.GetFiles(path).Select(Path.GetFileName))
                {
                    
                    if (s.ToLower().Contains(".mp3") || s.ToLower().Contains(".m4a"))
                    {
                        try
                        {
                            string filepath = directory + "\\" + s;

                            TagLib.File tagfile = TagLib.File.Create(filepath);
                            if(!System.IO.File.Exists(path + "/Cover.jpg"))
                            {
                                
                                if (tagfile.Tag.Pictures.Length >= 1)
                                {
                                    var bin = (byte[])(tagfile.Tag.Pictures[0].Data.Data);
                                    try
                                    {
                                        using (var fs = new FileStream(path + "/Cover.jpg", FileMode.Create, FileAccess.Write))
                                        {
                                            fs.Write(bin, 0, bin.Length);
                                            
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        
                                    }
                                }
                            }
                            Song song = new Song();
                            Artist art = admin.Library.artist_list.FirstOrDefault(a => a.name.ToLower().Equals(tagfile.Tag.FirstAlbumArtist.ToLower()));
                            if(art != null)
                            {
                                artist = art;
                            }
                            else
                            {
                                Artist artx = artists.FirstOrDefault(a => a.name.ToLower().Equals(tagfile.Tag.FirstAlbumArtist.ToLower()));
                                if (artx != null)
                                {
                                    artist = artx;
                                }
                                else
                                {
                                    artist.name = tagfile.Tag.FirstAlbumArtist;
                                    artist.url_name = Tools.ConvertToGitHubFolder(artist.name);
                                    while (Artist.id_exists(admin.Library.artist_list, artist.id))
                                    {
                                        artist.id++;
                                    }
                                    artists.Add(artist);
                                }
                            }
                            Album alb = admin.Library.album_list.FirstOrDefault(a => a.name.ToLower().Equals(tagfile.Tag.Album.ToLower()));
                            if (alb != null)
                            {
                                album = alb;
                            }
                            else
                            {
                                Album albx = albums.FirstOrDefault(a => a.name.ToLower().Equals(tagfile.Tag.Album.ToLower()));
                                if (albx != null)
                                {
                                    album = albx;
                                }
                                else
                                {
                                    album.name = tagfile.Tag.Album;
                                    album.url_name = Tools.ConvertToGitHubFolder(album.name);
                                    album.artist_id = artist.id;
                                    album.cover_url = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat, artist.url_name, album.url_name);
                                    album.url_name = Tools.ConvertToGitHubFolder(album.name);
                                    while (Album.id_exists(admin.Library.album_list, album.id))
                                    {
                                        album.id++;
                                    }
                                    albums.Add(album);
                                }
                            }
                            while (Song.id_exists(admin.Library.song_list, song.id))
                            {
                                song.id++;
                            }
                            song.artist_id = artist.id;
                            song.album_id = album.id;
                            song.name = tagfile.Tag.Title;
                            song.file_name = s;
                            song.url_name = Tools.ConvertToGitHubFile(song.file_name, admin.Library.configuration.GitHubFile_TextToReplace_List);
                            songs.Add(song);
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                foreach (Song s in songs)
                {
                    listSong.Items.Add(s);
                }
            }
            catch
            {
                
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro?", "Guardar Canciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach(Artist artist in artists)
                    {
                        admin.Library.artist_list.Add(artist);
                    }
                    foreach (Album album in albums)
                    {
                        admin.Library.album_list.Add(album);
                    }
                    foreach (Song song in songs)
                    {
                        if(!admin.Library.song_list.Contains(song))
                        {
                            admin.Library.song_list.Add(song);
                        }
                    }
                    if (!Directory.Exists(txtGitHubFolder.Text))
                    {
                        folderBrowser.ShowDialog();
                        {
                            if (folderBrowser.SelectedPath != string.Empty)
                            {
                                txtGitHubFolder.Text = folderBrowser.SelectedPath;
                                JsonFile file = new JsonFile();
                                file.Directory = Application.StartupPath + "\\";
                                file.FileName = "gh";
                                JsonFileResponse r = file.Write(txtGitHubFolder.Text.Trim());
                            }
                        }
                    }
                    
                    foreach (Song s in songs)
                    {
                        Artist a = Artist.get(admin.Library.artist_list, s.artist_id);
                        Album al = Album.get(admin.Library.album_list, s.album_id);
                        if (!Directory.Exists(txtGitHubFolder.Text + "\\" + a.url_name))
                        {
                            Directory.CreateDirectory(txtGitHubFolder.Text + "\\" + a.url_name);
                        }
                        if (!Directory.Exists(txtGitHubFolder.Text + "\\" + a.url_name + "\\" + al.url_name))
                        {
                            Directory.CreateDirectory(txtGitHubFolder.Text + "\\" + a.url_name + "\\" + al.url_name);
                        }
                        
                        if (!System.IO.File.Exists(txtGitHubFolder.Text + "\\" + a.url_name + "\\" + al.url_name + "\\Cover.jpg"))
                        {
                            if (System.IO.File.Exists(txtDirectory.Text + "\\Cover.jpg"))
                            {
                                System.IO.File.Copy(txtDirectory.Text + "\\Cover.jpg", txtGitHubFolder.Text + "\\" + a.url_name + "\\" + al.url_name + "\\Cover.jpg");
                            }
                        }

                        System.IO.File.Copy(txtDirectory.Text + "\\" + s.file_name, txtGitHubFolder.Text + "\\" + a.url_name + "\\" + al.url_name + "\\" + s.file_name);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch(Exception ex)
                {

                }
                finally
                {
                    songs.Clear();
                    albums.Clear();
                    artists.Clear();
                }
            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            if(Directory.Exists(txtDirectory.Text.Trim()))
            {
                btnAnalizar.Enabled = true;
            }
            else
            {
                btnAnalizar.Enabled = false;
            }
        }

        private void listSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listSong.SelectedItems.Count > 0)
            {
                try
                {
                    Song song = (Song)listSong.SelectedItem;
                    Album album = Album.get(albums, song.album_id);
                    if(album == null)
                    {
                        album = Album.get(admin.Library.album_list, song.album_id);
                    }
                    Artist artist = Artist.get(artists, song.artist_id);
                    if (artist == null)
                    {
                        artist = Artist.get(admin.Library.artist_list, song.artist_id);
                    }
                    txtName.Text = song.name;
                    txtAlbum.Text = album.name;
                    txtArtist.Text = artist.name;
                    txtFile.Text = song.file_name;
                    txtURLName.Text = song.url_name;

                }
                catch 
                {
                    txtName.Text = "";
                    txtAlbum.Text = "";
                    txtArtist.Text = "";
                    txtFile.Text = "";
                    txtURLName.Text = "";
                }
            }
            else
            {
                txtName.Text = "";
                txtAlbum.Text = "";
                txtArtist.Text = "";
                txtFile.Text = "";
                txtURLName.Text = "";
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            if(folderBrowser.SelectedPath != string.Empty)
            {
                txtDirectory.Text = folderBrowser.SelectedPath;
            }
        }
        
        private void btnSelectGitHubFolder_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            {
                if(folderBrowser.SelectedPath != string.Empty)
                {
                    txtGitHubFolder.Text = folderBrowser.SelectedPath;
                    JsonFile file = new JsonFile();
                    file.Directory = Application.StartupPath + "\\";
                    file.FileName = "gh";
                    JsonFileResponse r = file.Write(txtGitHubFolder.Text.Trim());
                }
            }
        }
    }
}
