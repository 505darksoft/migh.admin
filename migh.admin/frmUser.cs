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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAdd_User frm = new frmAdd_User();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = (User)listUser.SelectedItems[0].Tag;

            frmEdit_User frm = new frmEdit_User();
            frm.user = user;
            frm.user_name = user.name;

            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User user = (User)listUser.SelectedItems[0].Tag;
                User.remove(ref admin.Library.user_list, user.name);
                RefreshList();
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            listUser.Items.Clear();
            string user_name = txtUserName.Text.Trim();
            foreach(User user in admin.Library.user_list)
            {
                if(user.name.ToLower().Contains(user_name.ToLower()))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = user.name;

                    string modo = "Regular";
                    if(user.premium)
                    {
                        modo = "Premium";
                    }
                    item.SubItems.Add(modo);
                    item.Tag = user;
                    listUser.Items.Add(item);
                }
            } 
            EnableButtons();
        }
        private void EnableButtons()
        {
            if (listUser.SelectedItems.Count > 0)
            {
                btnDeleteUser.Enabled = true;
                btnEditUser.Enabled = true;
            }
            else
            {
                btnDeleteUser.Enabled = false;
                btnEditUser.Enabled = false;
            }
        }

        private void listUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
