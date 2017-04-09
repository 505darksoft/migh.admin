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
    public partial class frmEdit_Artist : Form
    {
        public frmEdit_Artist()
        {
            InitializeComponent();
        }
        public int artist_id;
        public string artist_name = "";
        public string artist_url_name = "";

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string new_artist_name = txtArtistName.Text.Trim();
                string new_artist_url_name = txtArtistURLName.Text.Trim();
                Artist new_artist = new Artist();
                new_artist.name = new_artist_name;
                new_artist.url_name = new_artist_url_name;

                if (new_artist.name != "" && new_artist.url_name != "")
                {
                    Artist.set(ref admin.Library.artist_list, artist_id, new_artist);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEdit_Artist_Load(object sender, EventArgs e)
        {
            txtArtistName.Text = artist_name;
            txtArtistURLName.Text = artist_url_name;
        }

        private void txtArtistName_TextChanged(object sender, EventArgs e)
        {
            txtArtistURLName.Text = Tools.ConvertToGitHubFolder(txtArtistName.Text.Trim());
        }
    }
}
