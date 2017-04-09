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
using JsonTools;

namespace migh.admin
{
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                Close();
            }
            catch { }
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            JsonFile f = new JsonFile(Application.StartupPath, "cookie.txt");

            Configuration.Cookie cookie = new Configuration.Cookie();
            try
            {
                cookie = f.Read<Configuration.Cookie>();
                txtSU.Text = Tools.DecodeStringFromBase64(cookie.su);
                txtU.Text = Tools.DecodeStringFromBase64(cookie.u);
                txtP.Text = Tools.DecodeStringFromBase64(cookie.p);
            }
            catch { }
            
            

            RefreshReplaceTextList();
            RefreshReplaceTextHTMLList();
            RefreshWebFileList();
            txtAudioFileURLFormat.Text = admin.Library.configuration.AudioFileURLFormat;
            txtAlbumCoverImageFileURLFormat.Text = admin.Library.configuration.AlbumCoverImageFileURLFormat;
        }

        private void btnAddReplaceText_Click(object sender, EventArgs e)
        {
            ReplaceText rt = new ReplaceText();
            rt.OriginalText = txtOriginalText.Text;
            rt.NewText = txtNewText.Text;
            admin.Library.configuration.GitHubFile_TextToReplace_List.Add(rt);
            RefreshReplaceTextList();
        }

        private void RefreshReplaceTextList()
        {
            listReplaceText.Items.Clear();
            foreach (ReplaceText rt in admin.Library.configuration.GitHubFile_TextToReplace_List)
            {
                listReplaceText.Items.Add(rt);
            }
        }
        private void RefreshReplaceTextHTMLList()
        {
            listReplaceTextHTML.Items.Clear();
            foreach (ReplaceText rt in admin.Library.configuration.GitHubFile_TextToReplace_HTML_List)
            {
                listReplaceTextHTML.Items.Add(rt);
            }
        }
        private void RefreshWebFileList()
        {
            listWebFile.Items.Clear();
            foreach (WebFile wf in admin.Library.configuration.WebFile_List)
            {
                listWebFile.Items.Add(wf);
            }
        }

        private void btnEditWebFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (listWebFile.SelectedItems.Count > 0)
                {
                    WebFile webfile = (WebFile)listWebFile.SelectedItem;
                    frmConfiguration_Edit_WebFile frm = new frmConfiguration_Edit_WebFile();
                    frm.webfile = webfile;
                    frm.ShowDialog();

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        RefreshWebFileList();
                    }
                }
            }
            catch { }
        }

        private void btnAddWebFile_Click(object sender, EventArgs e)
        {
            frmConfiguration_Add_WebFile frm = new frmConfiguration_Add_WebFile();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                RefreshWebFileList();
            }
        }

        private void btnDeleteReplaceText_Click(object sender, EventArgs e)
        {
            try
            {
                if(listReplaceText.SelectedItems.Count > 0)
                {
                    ReplaceText rt = (ReplaceText)listReplaceText.SelectedItem;
                    List<ReplaceText> aux = new List<ReplaceText>();
                    foreach (ReplaceText r in admin.Library.configuration.GitHubFile_TextToReplace_List)
                    {
                        aux.Add(r);
                    }
                    foreach(ReplaceText r in aux)
                    {
                        if(r == rt)
                        {
                            admin.Library.configuration.GitHubFile_TextToReplace_List.Remove(rt);
                        }
                    }
                }
                RefreshReplaceTextList();
            }
            catch { }
        }

        private void btnDeleteWebFile_Click(object sender, EventArgs e)
        {
            try
            {
                if(listWebFile.SelectedItems.Count > 0)
                {
                    WebFile wf = (WebFile)listWebFile.SelectedItem;
                    List<WebFile> aux = new List<WebFile>();
                    foreach (WebFile w in admin.Library.configuration.WebFile_List)
                    {
                        aux.Add(w);
                    }
                    foreach(WebFile w in aux)
                    {
                        if(w.Name.ToLower() == wf.Name.ToLower())
                        {
                            admin.Library.configuration.WebFile_List.Remove(wf);
                        }
                    }
                }
                RefreshWebFileList();
            }
            catch { }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                admin.Library.configuration.AudioFileURLFormat = txtAudioFileURLFormat.Text.Trim();
                admin.Library.configuration.AlbumCoverImageFileURLFormat = txtAlbumCoverImageFileURLFormat.Text.Trim();
                //Configuration.Save();
                Configuration.Cookie cookie = new Configuration.Cookie();
                cookie.su = Tools.EncodeStringToBase64(txtSU.Text.Trim());
                cookie.u = Tools.EncodeStringToBase64(txtU.Text.Trim());
                cookie.p =  Tools.EncodeStringToBase64(txtP.Text);
                JsonFile f = new JsonFile(Application.StartupPath, "cookie.txt");
                f.Write(cookie);
                this.DialogResult = DialogResult.OK;
            }
            catch { }
        }

        private void btnAddReplaceTextHTML_Click(object sender, EventArgs e)
        {
            ReplaceText rt = new ReplaceText();
            rt.OriginalText = txtOriginalTextHTML.Text;
            rt.NewText = txtNewTextHTML.Text;
            admin.Library.configuration.GitHubFile_TextToReplace_HTML_List.Add(rt);
            RefreshReplaceTextHTMLList();
        }

        private void btnDeleteReplaceTextHTML_Click(object sender, EventArgs e)
        {
            try
            {
                if (listReplaceTextHTML.SelectedItems.Count > 0)
                {
                    ReplaceText rt = (ReplaceText)listReplaceTextHTML.SelectedItem;
                    List<ReplaceText> aux = new List<ReplaceText>();
                    foreach (ReplaceText r in admin.Library.configuration.GitHubFile_TextToReplace_HTML_List)
                    {
                        aux.Add(r);
                    }
                    foreach (ReplaceText r in aux)
                    {
                        if (r == rt)
                        {
                            admin.Library.configuration.GitHubFile_TextToReplace_HTML_List.Remove(rt);
                        }
                    }
                }
                RefreshReplaceTextHTMLList();
            }
            catch { }
        }
    }
}
