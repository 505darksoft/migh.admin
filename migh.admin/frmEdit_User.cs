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
    public partial class frmEdit_User : Form
    {
        public frmEdit_User()
        {
            InitializeComponent();
        }

        public User user = new User();
        public string user_name = null;

        private void Refresh_User_Artist_List()
        {
            listUser_Artists.Items.Clear();

            foreach (int artist_id in user.artist_list)
            {
                Artist artist = Artist.get(admin.Library.artist_list, artist_id);
                if (artist != null)
                {
                    admin.ListItem item = new admin.ListItem();
                    item.Text = artist.name;
                    item.Value = artist;
                    listUser_Artists.Items.Add(item);
                }
            }
        }

        private void Refresh_All_Artist_List()
        {
            listAll_Artists.Items.Clear();
            foreach (Artist a in admin.Library.artist_list)
            {
                if (!user.artist_list.Contains(a.id))
                {
                    admin.ListItem item = new admin.ListItem();
                    item.Text = a.name;
                    item.Value = a;
                    listAll_Artists.Items.Add(item);
                }
            }
        }

        private void frmEdit_User_Load(object sender, EventArgs e)
        {
            txtUsername.Text = user.name;
            txtPassword.Text = Tools.DecodeStringFromBase64(user.password);
            txtMessage.Text = user.message;
            chkPremium.Checked = user.premium;
            Refresh_User_Artist_List();
            Refresh_All_Artist_List();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = Tools.EncodeStringToBase64(txtPassword.Text.Trim());
                string message = txtMessage.Text.Trim();
                bool premium = chkPremium.Checked;

                User new_user = new User();
                new_user.name = username;
                new_user.password = password;
                new_user.premium = premium;
                new_user.message = message;
                new_user.artist_list = user.artist_list;

                User.set(ref admin.Library.user_list, user_name, new_user);
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Artist artist = (Artist)((admin.ListItem)listAll_Artists.SelectedItem).Value;
                user.artist_list.Add(artist.id);
                Refresh_User_Artist_List();
                Refresh_All_Artist_List();
            }
            catch
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Artist artist = (Artist)((admin.ListItem)listUser_Artists.SelectedItem).Value;
                user.artist_list.Remove(artist.id);
                Refresh_User_Artist_List();
                Refresh_All_Artist_List();
            }
            catch
            {

            }
        }
    }
}
