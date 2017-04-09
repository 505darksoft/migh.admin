using migh.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace migh.admin
{
    public partial class frmConfiguration_Edit_WebFile : Form
    {
        public frmConfiguration_Edit_WebFile()
        {
            InitializeComponent();
        }

        public WebFile webfile = new WebFile();

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (WebFile w in admin.Library.configuration.WebFile_List)
            {
                if (w.Name.ToLower() == webfile.Name.ToLower())
                {
                    w.Name = txtName.Text.Trim();
                    w.URL = txtURL.Text.Trim();
                    w.FTP = chkFTP.Checked;
                    w.Default = chkDefault.Checked;
                    w.Credentials.UserName = txtUsername.Text.Trim();
                    w.Credentials.Password = Tools.EncodeStringToBase64(txtPassword.Text.Trim());
                }
                else
                {
                    w.Default = false;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void frmConfiguration_Edit_WebFile_Load(object sender, EventArgs e)
        {
            txtName.Text = webfile.Name;
            txtURL.Text = webfile.URL;
            chkFTP.Checked = webfile.FTP;
            chkDefault.Checked = webfile.Default;
            txtUsername.Text = webfile.Credentials.UserName;
            txtPassword.Text = Tools.DecodeStringFromBase64(webfile.Credentials.Password);
        }
    }
}
