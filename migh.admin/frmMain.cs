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
using simple.ftp;

namespace migh.admin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            admin.Library = (Library.read_local(Configuration.LibraryFileName)).ToObject<Library>();
            //Configuration.Load();
            RefreshComboWebFile();
            SessionVersion = admin.Library.Version + 1;
            lblVersion.Text = "Versión: " + admin.Library.Version;
            lblSessionVersion.Text = "Sesión: " + SessionVersion;
        }

        private void RefreshComboWebFile()
        {
            cbxWebFile.Items.Add("Default");
            foreach (WebFile webfile in admin.Library.configuration.WebFile_List)
            {
                if (webfile.FTP)
                {
                    cbxWebFile.Items.Add(webfile);
                }
            }
            if (cbxWebFile.Items.Count > 1)
            {
                cbxWebFile.SelectedIndex = 1;
            }
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.ShowDialog();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            frmArtist frm = new frmArtist();
            frm.ShowDialog();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            frmAlbum frm = new frmAlbum();
            frm.ShowDialog();
        }

        private void btnSong_Click(object sender, EventArgs e)
        {
            frmSong frm = new frmSong();
            frm.ShowDialog();
        }
        int SessionVersion = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            admin.Library.Version = SessionVersion;
            //admin.Library.configuration = Configuration.Data;
            Library.write_local(admin.Library, Configuration.LibraryFileName);
            string WebFile = cbxWebFile.Text;
            BackgroundWorker worker = new BackgroundWorker() { WorkerReportsProgress = true };

            worker.DoWork += delegate(object s, DoWorkEventArgs args)
            {
                try
                {
                    WebFile wf = admin.Library.configuration.WebFile_List.Single(w => w.Name.Equals(WebFile));
                    ftp.Upload(Configuration.LibraryFileName, wf.URL, wf.Credentials.UserName, Tools.DecodeStringFromBase64(wf.Credentials.Password));
                    args.Result = "Archivo subido";
                }
                catch(Exception ex)
                {
                    args.Result = ex.Message;
                }
            };

            worker.RunWorkerCompleted += delegate(object s, RunWorkerCompletedEventArgs args)
            {
                MessageBox.Show(args.Result.ToString(), "Guardar y subir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            worker.RunWorkerAsync();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro?", "Descargar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(cbxWebFile.Text == "Default")
                {
                    Library l = new Library("ftp://migh.somee.com/www.migh.somee.com/migh/migh.lib", "eduardohley", "@Poder123");
                    Library.write_local(l, Configuration.LibraryFileName);
                    return;
                }
                WebFile wf = (WebFile)cbxWebFile.SelectedItem;
                Library lib = new Library(wf.URL, wf.Credentials.UserName, Tools.DecodeStringFromBase64(wf.Credentials.Password));
                Library.write_local(lib, Configuration.LibraryFileName);
            }
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            frmConfiguration frm = new frmConfiguration();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                RefreshComboWebFile();
            }
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            try
            {
                WebFile wf = (WebFile)cbxWebFile.SelectedItem;
                Library lib = new Library(wf.URL, wf.Credentials.UserName, Tools.DecodeStringFromBase64(wf.Credentials.Password));
                MessageBox.Show("Versión en línea: " + lib.Version, "Versión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                
            }
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            if(txtPIN.Text == "::0437")
            {
                btnDownload.Enabled = true;
                btnSave.Enabled = true;
                btnConfiguration.Enabled = true;
                txtPIN.Visible = false;
            }
        }
        public static string ServerURL = "";
        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            ServerURL = txtServer.Text;
        }

        private void btnAlbumCreator_Click(object sender, EventArgs e)
        {
            frmAlbumCreator frm = new frmAlbumCreator();
            frm.ShowDialog();
        }
    }
}
