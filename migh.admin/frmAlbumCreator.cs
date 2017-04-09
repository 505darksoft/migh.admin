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
            FillAlbumCombo();
            FillSongList();
        }

        List<Song> songs = new List<Song>();

        private void FillAlbumCombo()
        {
            foreach(Album album in admin.Library.album_list)
            {
                cbxAlbum.Items.Add(album);
            }
            if(cbxAlbum.Items.Count > 0)
            {
                cbxAlbum.SelectedIndex = 0;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }

        private void FillSongList()
        {
            listSong.Items.Clear();
            try
            {
                Album album = (Album)((admin.ListItem)cbxAlbum.SelectedItem).Value;
                foreach(Song song in admin.Library.song_list)
                {
                    if(song.album_id == album.id)
                    {
                        admin.ListItem item = new admin.ListItem();
                        item.Text = song.name;
                        item.Value = song;
                        listSong.Items.Add(item);
                    }
                }
            }
            catch { }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            listSong.Items.Clear();
            string directory = txtDirectory.Text.Trim();
            songs = new List<Song>();
            Album album = (Album)cbxAlbum.SelectedItem;
            Artist artist = Artist.get(admin.Library.artist_list, album.artist_id);
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

                            Song song = new Song();

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

        private void cbxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSongList();
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
                    Album album = (Album)cbxAlbum.SelectedItem;
                    List<Song> aux = new List<Song>();
                    foreach (Song song in admin.Library.song_list)
                    {
                        aux.Add(song);
                    }
                    foreach (Song song in aux)
                    {
                        if (song.album_id == album.id)
                        {
                            Song.remove(ref admin.Library.song_list, song.id);
                        }
                    }
                    foreach (Song song in songs)
                    {
                        while (Song.id_exists(admin.Library.song_list, song.id))
                        {
                            song.id++;
                        }
                        admin.Library.song_list.Add(song);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch { }
            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            if(Directory.Exists(txtDirectory.Text.Trim()) && cbxAlbum.Items.Count > 0)
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }

        private void listSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listSong.SelectedItems.Count > 0)
            {
                try
                {
                    Song song = (Song)listSong.SelectedItem;
                    Album album = Album.get(admin.Library.album_list, song.album_id);
                    Artist artist = Artist.get(admin.Library.artist_list, song.artist_id);

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
    }
}
