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
using JsonTools;
using System.Collections.Specialized;
using System.Net;

namespace migh.admin
{
    public partial class frmSong : Form
    {
        public frmSong()
        {
            InitializeComponent();
        }

        private void listSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }
        private void EnableButtons()
        {
            if (listSong.SelectedItems.Count > 0)
            {
                btnDeleteSong.Enabled = true;
                btnEditSong.Enabled = true;
            }
            else
            {
                btnDeleteSong.Enabled = false;
                btnEditSong.Enabled = false;
            }
        }

        private void frmSong_Load(object sender, EventArgs e)
        {
            RefreshList();
            FillComboArtist();
            FillComboAlbum();
        }
        private void FillComboArtist()
        {
            cbxSongArtist.Items.Add(admin.Todos);
            foreach (Artist artist in admin.Library.artist_list)
            {
                admin.ListItem item = new admin.ListItem();
                item.Text = artist.name;
                item.Value = artist;
                cbxSongArtist.Items.Add(item);
            }
            cbxSongArtist.SelectedIndex = 0;
        }
        private void FillComboAlbum()
        {
            cbxSongAlbum.Items.Clear();
            cbxSongAlbum.Items.Add(admin.Todos);
            if(cbxSongArtist.Text == admin.Todos)
            {
                foreach (Album album in admin.Library.album_list)
                {
                    admin.ListItem item = new admin.ListItem();
                    item.Text = album.name;
                    item.Value = album;
                    cbxSongAlbum.Items.Add(item);
                }
            }
            else
            {
                try
                {
                    Artist artist = (Artist)((admin.ListItem)cbxSongArtist.SelectedItem).Value;
                    foreach (Album album in admin.Library.album_list)
                    {
                        if(album.artist_id == artist.id)
                        {
                            admin.ListItem item = new admin.ListItem();
                            item.Text = album.name;
                            item.Value = album;
                            cbxSongAlbum.Items.Add(item);
                        }
                    }
                }
                catch
                {
                    
                }
            }
            cbxSongAlbum.SelectedIndex = 0;
        }
        private void RefreshList()
        {
            listSong.Items.Clear();

            string song_name = txtSongName.Text.Trim();
            int artist_id = -1;
            int album_id = -1;

            if(cbxSongArtist.SelectedIndex > 0)
            {
                Artist artist = (Artist)((admin.ListItem)cbxSongArtist.SelectedItem).Value;
                artist_id = artist.id;
            }
            if(cbxSongAlbum.SelectedIndex > 0)
            {
                Album album = (Album)((admin.ListItem)cbxSongAlbum.SelectedItem).Value;
                album_id = album.id;
            }

            foreach(Song song in admin.Library.song_list)
            {
                if(artist_id > -1 && album_id > -1)
                {
                    if(song.artist_id == artist_id)
                    {
                        if(song.album_id == album_id)
                        {
                            if(song.name.ToLower().Contains(song_name.ToLower()))
                            {
                                Album album = Album.get(admin.Library.album_list, song.album_id);
                                Artist artist = Artist.get(admin.Library.artist_list, song.artist_id);

                                ListViewItem item = new ListViewItem();
                                item.Text = song.name;
                                item.Tag = song;
                                item.SubItems.Add(album.name);
                                item.SubItems.Add(artist.name);
                                listSong.Items.Add(item);
                            }
                        }
                    }
                }
                if(artist_id == -1 && album_id > -1)
                {
                    if (song.album_id == album_id)
                    {
                        if (song.name.ToLower().Contains(song_name.ToLower()))
                        {
                            Album album = Album.get(admin.Library.album_list, song.album_id);
                            Artist artist = Artist.get(admin.Library.artist_list, song.artist_id);

                            ListViewItem item = new ListViewItem();
                            item.Text = song.name;
                            item.Tag = song;
                            item.SubItems.Add(album.name);
                            item.SubItems.Add(artist.name);
                            listSong.Items.Add(item);
                        }
                    }
                }
                if(artist_id > -1 && album_id == -1)
                {
                    if (song.artist_id == artist_id)
                    {
                        if (song.name.ToLower().Contains(song_name.ToLower()))
                        {
                            Album album = Album.get(admin.Library.album_list, song.album_id);
                            Artist artist = Artist.get(admin.Library.artist_list, song.artist_id);

                            ListViewItem item = new ListViewItem();
                            item.Text = song.name;
                            item.Tag = song;
                            item.SubItems.Add(album.name);
                            item.SubItems.Add(artist.name);
                            listSong.Items.Add(item);
                        }
                    }
                }
                if(artist_id == -1 && album_id == -1)
                {
                    if (song.name.ToLower().Contains(song_name.ToLower()))
                    {
                        Album album = Album.get(admin.Library.album_list, song.album_id);
                        Artist artist = Artist.get(admin.Library.artist_list, song.artist_id);

                        ListViewItem item = new ListViewItem();
                        item.Text = song.name;
                        item.Tag = song;
                        item.SubItems.Add(album.name);
                        item.SubItems.Add(artist.name);
                        listSong.Items.Add(item);
                    }
                }
            }
            EnableButtons();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            frmAdd_Song frm = new frmAdd_Song();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void btnEditSong_Click(object sender, EventArgs e)
        {
            try
            {
                Song song = (Song)listSong.SelectedItems[0].Tag;
                frmEdit_Song frm = new frmEdit_Song();
                frm.song_id = song.id;
                frm.album_id = song.album_id;
                frm.song_name = song.name;
                frm.song_file_name = song.file_name;
                frm.song_url_name = song.url_name;
                frm.ShowDialog();
                
                if(frm.DialogResult == DialogResult.OK)
                {
                    RefreshList();
                }
            }
            catch { }
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro?", "Eliminar Canción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach(ListViewItem item in listSong.SelectedItems)
                    {
                        Song song = (Song)item.Tag;
                        Song.remove(ref admin.Library.song_list, song.id);
                    }
                }
                catch
                {
                    
                }
                RefreshList();
            }
        }

        private void cbxSongArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
            FillComboAlbum();
        }

        private void cbxSongAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void txtSongName_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnAlbumCreator_Click(object sender, EventArgs e)
        {
            frmAlbumCreator frm = new frmAlbumCreator();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                RefreshList();
            }
        }
        public partial class AlbumAPI
        {
            public int idAlbum { get; set; }
            public int idArtist { get; set; }
            public string Title { get; set; }
            public byte Tracks { get; set; }
            public short Year { get; set; }
        }
        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listSong.Items)
            {
                Song a = i.Tag as Song;
                Album album = Album.get(admin.Library.album_list, a.album_id);
                
                using (var wb = new WebClient())
                {
                    string response = wb.DownloadString(frmMain.ServerURL + "/api/albums?title=" + System.Net.WebUtility.UrlEncode(album.name));
                    AlbumAPI alb = response.ToObject<AlbumAPI>();
                    using (var wb2 = new WebClient())
                    {
                        var data = new NameValueCollection();
                        data["idAlbum"] = alb.idAlbum + "";
                        data["Title"] = a.name;
                        data["TrackNumber"] = 0 + "";
                        data["FileName"] = a.file_name;
                        data["FileUrlName"] = a.url_name;
                        
                        var response2 = wb2.UploadValues(frmMain.ServerURL + "/api/tracks", "POST", data);
                    }
                }
            }
        }
    }
}
