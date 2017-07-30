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

namespace migh.admin
{
    public partial class frmEdit_Album : Form
    {
        public frmEdit_Album()
        {
            InitializeComponent();
        }

        public int album_id;
        public int artist_id;
        public string album_name = "";
        public string album_url_name = "";
        public string cover_url = "";

        private void frmEdit_Album_Load(object sender, EventArgs e)
        {
            
            try
            {
                foreach (Artist artist in admin.Library.artist_list)
                {
                    admin.ListItem item = new admin.ListItem();
                    item.Text = artist.name;
                    item.Value = artist;
                    cbxArtist.Items.Add(item);
                }
                if (cbxArtist.Items.Count > 0)
                {
                    cbxArtist.SelectedIndex = 0;
                    int index = 0;
                    foreach(admin.ListItem item in cbxArtist.Items)
                    {
                        if(((Artist)item.Value).id == artist_id)
                        {
                            cbxArtist.SelectedIndex = index;
                            break;
                        }
                        index++;
                    }
                    btnOk.Enabled = true;
                }
                else
                {
                    btnOk.Enabled = false;
                }
                txtAlbumName.Text = album_name;
                txtCoverURL.Text = cover_url;
                txtAlbumURLName.Text = album_url_name;
                lblAlbumId.Text = "id: " + album_id;
                lblArtistId.Text = "Artist id: " + artist_id;
            }
            catch { }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            try
            {
                string new_album_name = txtAlbumName.Text.Trim();
                string new_cover_url = txtCoverURL.Text.Trim();
                string new_album_url_name = txtAlbumURLName.Text.Trim();
                Album new_album = new Album();
                new_album.name = new_album_name;
                new_album.url_name = new_album_url_name;
                new_album.cover_url = new_cover_url;

                if (album_name != "" && album_url_name != "")
                {
                    Artist artist = (Artist)((admin.ListItem)cbxArtist.SelectedItem).Value;
                    new_album.artist_id = artist.id;
                    Album.set(ref admin.Library.album_list, album_id, new_album);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAlbumName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAlbumURLName.Text = Tools.ConvertToGitHubFolder(txtAlbumName.Text.Trim());
                Artist artist = (Artist)((admin.ListItem)cbxArtist.SelectedItem).Value;
                txtCoverURL.Text = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat, artist.url_name, album_url_name);
            }
            catch { }
        }

        private void txtAlbumURLName_TextChanged(object sender, EventArgs e)
        {
            if (cbxArtist.Items.Count > 0)
            {
                Artist artist = (Artist)((admin.ListItem)cbxArtist.SelectedItem).Value;
                txtCoverURL.Text = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat, artist.url_name, txtAlbumURLName.Text);
            }
        }

        private void cbxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxArtist.Items.Count > 0)
            {
                Artist artist = (Artist)((admin.ListItem)cbxArtist.SelectedItem).Value;
                txtCoverURL.Text = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat, artist.url_name, txtAlbumURLName.Text);
            }
        }
    }
}
