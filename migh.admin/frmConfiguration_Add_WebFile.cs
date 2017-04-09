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
    public partial class frmConfiguration_Add_WebFile : Form
    {
        public frmConfiguration_Add_WebFile()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WebFile wf = new WebFile();
            wf.Name = txtName.Text.Trim();
            wf.URL = txtURL.Text.Trim();
            wf.FTP = chkFTP.Checked;
            wf.Default = chkDefault.Checked;
            wf.Credentials.UserName = txtUsername.Text.Trim();
            wf.Credentials.Password = Tools.EncodeStringToBase64(txtPassword.Text.Trim());
            admin.Library.configuration.WebFile_List.Add(wf);
            foreach (WebFile w in admin.Library.configuration.WebFile_List)
            {
                if(w.Name.ToLower() == wf.Name.ToLower())
                {
                    w.Default = chkDefault.Checked;
                }
                else
                {
                    w.Default = false;
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
