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
using System.Web;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;

namespace migh.admin
{
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
        }

        private void listArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }
        private void EnableButtons()
        {
            if (listArtist.SelectedItems.Count > 0)
            {
                btnDeleteArtist.Enabled = true;
                btnEditArtist.Enabled = true;
            }
            else
            {
                btnDeleteArtist.Enabled = false;
                btnEditArtist.Enabled = false;
            }
        }

        private void frmArtist_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            listArtist.Items.Clear();
            
            string artist_name = txtArtistName.Text.Trim();
            foreach (Artist a in admin.Library.artist_list)
            {
                if (a.name.ToLower().Contains(artist_name.ToLower()))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = a.name;
                    item.Tag = a;
                    listArtist.Items.Add(item);
                }
            }
            EnableButtons();
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            frmAdd_Artist frm = new frmAdd_Artist();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void txtArtistName_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            try
            {
                Artist artist = (Artist)listArtist.SelectedItems[0].Tag;
                frmEdit_Artist frm = new frmEdit_Artist();
                frm.artist_id = artist.id;
                frm.artist_name = artist.name;
                frm.artist_url_name = artist.url_name;
                frm.ShowDialog();

                if(frm.DialogResult == DialogResult.OK)
                {
                    RefreshList();
                }
            }
            catch
            {
                
            }
        }

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro?", "Eliminar Artista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Artist artist = (Artist)listArtist.SelectedItems[0].Tag;
                if(Artist.has_children(admin.Library.album_list, artist.id))
                {
                    MessageBox.Show(artist.name + " tiene álbumes registrados", "Eliminar Artista", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Artist.remove(ref admin.Library.artist_list, artist.id);
                    RefreshList();
                }
            }
        }
        private static readonly HttpClient client = new HttpClient();
        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            upgradeAsync();
        }

        void upgradeAsync()
        {
            foreach (ListViewItem i in listArtist.Items)
            {
                Artist a = (Artist)i.Tag;
                using (var wb = new WebClient())
                {
                    var data = new NameValueCollection();
                    data["Name"] = a.name;
                    data["UrlName"] = a.url_name;

                    var response = wb.UploadValues(frmMain.ServerURL + "api/artists", "POST", data);
                }
            }
        }
    }
}
