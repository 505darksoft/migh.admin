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
using System.Net;
using System.Collections.Specialized;
using JsonTools;

namespace migh.admin
{
    public partial class frmAlbum : Form
    {
        public frmAlbum()
        {
            InitializeComponent();
        }

        private void frmAlbum_Load(object sender, EventArgs e)
        {
            EnableButtons();
            FillComboArtist();
        }

        private void FillComboArtist()
        {
            cbxAlbumArtist.Items.Clear();
            cbxAlbumArtist.Items.Add(admin.Todos);

            foreach(Artist artist in admin.Library.artist_list)
            {
                admin.ListItem item = new admin.ListItem();
                item.Text = artist.name;
                item.Value = artist;
                cbxAlbumArtist.Items.Add(item);
            }
            cbxAlbumArtist.SelectedIndex = 0;
        }
        private void RefreshList()
        {
            listAlbum.Items.Clear();
            int artist_id = -1;
            string album_name = txtAlbumName.Text.Trim();

            if(cbxAlbumArtist.SelectedIndex > 0)
            {
                Artist artist = (Artist)((admin.ListItem)cbxAlbumArtist.SelectedItem).Value;
                artist_id = artist.id;
            }

            foreach(Album album in admin.Library.album_list)
            {
                if(artist_id > -1)
                {
                    if(album.artist_id == artist_id)
                    {
                        if(album.name.ToLower().Contains(album_name.ToLower()))
                        {
                            Artist artist = Artist.get(admin.Library.artist_list, album.artist_id);
                            ListViewItem item = new ListViewItem();
                            item.Text = album.name;
                            item.SubItems.Add(artist.name);
                            item.Tag = album;
                            listAlbum.Items.Add(item);
                        }
                    }
                }
                else
                {
                    if (album.name.ToLower().Contains(album_name.ToLower()))
                    {
                        Artist artist = Artist.get(admin.Library.artist_list, album.artist_id);
                        ListViewItem item = new ListViewItem();
                        item.Text = album.name;
                        item.SubItems.Add(artist.name);
                        item.Tag = album;
                        listAlbum.Items.Add(item);
                    }
                }
            }
            EnableButtons();
        }
        private void EnableButtons()
        {
            if (listAlbum.SelectedItems.Count > 0)
            {
                btnDeleteAlbum.Enabled = true;
                btnEditAlbum.Enabled = true;
            }
            else
            {
                btnDeleteAlbum.Enabled = false;
                btnEditAlbum.Enabled = false;
            }
        }

        private void listAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdd_Album frm = new frmAdd_Album();
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    RefreshList();
                }
            }
            catch { }
        }

        private void btnEditAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                Album album = (Album)listAlbum.SelectedItems[0].Tag;
                frmEdit_Album frm = new frmEdit_Album();
                frm.album_id = album.id;
                frm.cover_url = album.cover_url;
                frm.album_name = album.name;
                frm.album_url_name = album.url_name;
                frm.artist_id = album.artist_id;
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    RefreshList();
                }
            }
            catch { }
        }

        private void cbxAlbumArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro?", "Eliminar Álbum", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Album album = (Album)listAlbum.SelectedItems[0].Tag;
                if (Album.has_children(admin.Library.song_list, album.id))
                {
                    MessageBox.Show(album.name + " tiene canciones registradas", "Eliminar Álbum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Album.remove(ref admin.Library.album_list, album.id);
                    RefreshList();
                }
            }
        }

        private void txtAlbumName_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        public partial class ArtistAPI
        {
            public int idArtist { get; set; }
            public string Name { get; set; }
            public string UrlName { get; set; }
        }
        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem i in listAlbum.Items)
            {
                Album a = i.Tag as Album;
                Artist artist = Artist.get(admin.Library.artist_list, a.artist_id);
                using (var wb = new WebClient())
                {
                    string response = wb.DownloadString(frmMain.ServerURL + "/api/artists?name=" + artist.name);
                    ArtistAPI alb = response.ToObject<ArtistAPI>();
                    using (var wb2 = new WebClient())
                    {
                        var data = new NameValueCollection();
                        data["idArtist"] = alb.idArtist+"";
                        data["Title"] = a.name;
                        data["Tracks"] = 0+"";
                        data["Year"] = 0+"";

                        var response2 = wb2.UploadValues(frmMain.ServerURL + "/api/albums", "POST", data);
                    }
                }
            }
        }
    }
}
