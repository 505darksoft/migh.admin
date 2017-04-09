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
    public partial class frmAdd_Album : Form
    {
        public frmAdd_Album()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string album_name = txtAlbumName.Text.Trim();
                string album_url_name = txtAlbumURLName.Text.Trim();
                string cover_url = txtCoverURL.Text.Trim();

                if (album_name != "" && album_url_name != "")
                {
                    Artist artist = (Artist)((admin.ListItem)cbxArtist.SelectedItem).Value;

                    Album new_album = new Album();
                    new_album.id = 0;
                    new_album.artist_id = artist.id;
                    new_album.name = album_name;
                    new_album.url_name = album_url_name;
                    new_album.cover_url = cover_url;

                    if (!Artist.id_exists(admin.Library.artist_list, new_album.id))
                    {
                        MessageBox.Show("No se encontró el Artista", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Album.name_exists(admin.Library.album_list, new_album.name))
                    {
                        MessageBox.Show("El nombre de Álbum ya está registrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    while (Album.id_exists(admin.Library.album_list, new_album.id))
                    {
                        new_album.id++;
                    }

                    admin.Library.album_list.Add(new_album);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdd_Album_Load(object sender, EventArgs e)
        {
            try
            {
                foreach(Artist artist in admin.Library.artist_list)
                {
                    admin.ListItem item = new admin.ListItem();
                    item.Text = artist.name;
                    item.Value = artist;
                    cbxArtist.Items.Add(item);
                }
                if(cbxArtist.Items.Count > 0)
                {
                    btnOk.Enabled = true;
                    cbxArtist.SelectedIndex = 0;
                }
                else
                {
                    btnOk.Enabled = false;
                }
            }
            catch { }
        }

        private void txtAlbumName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtAlbumURLName.Text = Tools.ConvertToGitHubFolder(txtAlbumName.Text.Trim());
                Artist artist = (Artist)((admin.ListItem)cbxArtist.SelectedItem).Value;
                txtCoverURL.Text = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat, artist.url_name, txtAlbumURLName.Text);
            }
            catch { }
        }

        private void cbxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxArtist.Items.Count > 0)
            {
                Artist artist = (Artist)((admin.ListItem)cbxArtist.SelectedItem).Value;
                txtCoverURL.Text = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat, artist.url_name, txtAlbumURLName.Text);
            }
        }

        private void txtAlbumURLName_TextChanged(object sender, EventArgs e)
        {
            if (cbxArtist.Items.Count > 0)
            {
                Artist artist = (Artist)((admin.ListItem)cbxArtist.SelectedItem).Value;
                txtCoverURL.Text = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat, artist.url_name, txtAlbumURLName.Text);
            }
        }
    }
}
