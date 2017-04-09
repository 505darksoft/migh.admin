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
    public partial class frmAdd_Artist : Form
    {
        public frmAdd_Artist()
        {
            InitializeComponent();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            try
            {
                string artist_name = txtArtistName.Text.Trim();
                string artist_url_name = txtArtistURLName.Text.Trim();

                Artist new_artist = new Artist();
                new_artist.id = 0;
                new_artist.name = artist_name;
                new_artist.url_name = artist_url_name;

                if (new_artist.name != "" && new_artist.url_name != "")
                {
                    if (Artist.name_exists(admin.Library.artist_list, new_artist.name))
                    {
                        MessageBox.Show("El nombre de Artista ya está registrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ;
                    while (Artist.id_exists(admin.Library.artist_list, new_artist.id))
                    {
                        new_artist.id++;
                    }
                    admin.Library.artist_list.Add(new_artist);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtArtistName_TextChanged(object sender, EventArgs e)
        {
            txtArtistURLName.Text = Tools.ConvertToGitHubFolder(txtArtistName.Text.Trim());
        }
    }
}
