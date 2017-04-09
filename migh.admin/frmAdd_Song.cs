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
    public partial class frmAdd_Song : Form
    {
        public frmAdd_Song()
        {
            InitializeComponent();
        }

        private void frmAdd_Song_Load(object sender, EventArgs e)
        {
            foreach (Album album in admin.Library.album_list)
            {
                admin.ListItem item = new admin.ListItem();
                item.Text = album.name;
                item.Value = album;
                cbxAlbum.Items.Add(item);
            }
            if (cbxAlbum.Items.Count > 0)
            {
                cbxAlbum.SelectedIndex = 0;
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string song_name = txtSongName.Text.Trim();
                string song_url_name = txtSongURLName.Text.Trim();
                string song_file_name = txtFileName.Text.Trim();
                
                Album album = (Album)((admin.ListItem)cbxAlbum.SelectedItem).Value;
                Song song = new Song();
                song.id = 0;
                song.album_id = album.id;
                song.artist_id = album.artist_id;
                song.name = song_name;


                if (song.name != "")
                {
                    if (!Artist.id_exists(admin.Library.artist_list, song.artist_id))
                    {
                        MessageBox.Show("No se encontró el Artista", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!Album.id_exists(admin.Library.album_list, song.album_id))
                    {
                        MessageBox.Show("No se encontró el Álbum", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    while (Song.id_exists(admin.Library.song_list, song.id))
                    {
                        song.id++;
                    }
                    admin.Library.song_list.Add(song);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSongName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
