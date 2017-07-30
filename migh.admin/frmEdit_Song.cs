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
    public partial class frmEdit_Song : Form
    {
        public frmEdit_Song()
        {
            InitializeComponent();
        }

        public int song_id;
        public int album_id;
        public string song_name = "";
        public string song_url_name = "";
        public string song_file_name = "";

        private void frmEdit_Song_Load(object sender, EventArgs e)
        {
            txtSongName.Text = song_name;
            txtSongURLName.Text = song_url_name;
            txtFileName.Text = song_file_name;
            lblSongId.Text = "id: " + song_id;
            lblAlbumId.Text = "Album id: " + album_id;

            foreach(Album album in admin.Library.album_list)
            {
                admin.ListItem item = new admin.ListItem();
                item.Text = album.name;
                item.Value = album;
                cbxAlbum.Items.Add(item);
            }

            if(cbxAlbum.Items.Count > 0)
            {
                int index = 0;
                cbxAlbum.SelectedIndex = 0;
                foreach(admin.ListItem item in cbxAlbum.Items)
                {
                    if(((Album)item.Value).id == album_id)
                    {
                        cbxAlbum.SelectedIndex = index;
                        return;
                    }
                    index++;
                }
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
                string new_song_name = txtSongName.Text.Trim();
                string new_song_url_name = txtSongURLName.Text.Trim();
                string new_song_file_name = txtFileName.Text.Trim();

                Album album = (Album)((admin.ListItem)cbxAlbum.SelectedItem).Value;
                Song new_song = new Song();
                new_song.album_id = album.id;
                new_song.artist_id = album.artist_id;
                new_song.name = new_song_name;
                new_song.file_name = new_song_file_name;
                new_song.url_name = new_song_url_name;

                if (new_song.name != "")
                {
                    if (!Artist.id_exists(admin.Library.artist_list, new_song.artist_id))
                    {
                        MessageBox.Show("No se encontró el Artista", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!Album.id_exists(admin.Library.album_list, new_song.album_id))
                    {
                        MessageBox.Show("No se encontró el Álbum", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Song.set(ref admin.Library.song_list, song_id, new_song);
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
    }
}
