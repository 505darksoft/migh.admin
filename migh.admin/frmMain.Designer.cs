namespace migh.admin
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUser = new System.Windows.Forms.Button();
            this.btnArtist = new System.Windows.Forms.Button();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnSong = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.cbxWebFile = new System.Windows.Forms.ComboBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSessionVersion = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUser.Location = new System.Drawing.Point(12, 12);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Usuarios";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnArtist.Location = new System.Drawing.Point(93, 12);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(75, 23);
            this.btnArtist.TabIndex = 1;
            this.btnArtist.Text = "Artistas";
            this.btnArtist.UseVisualStyleBackColor = true;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlbum.Location = new System.Drawing.Point(174, 12);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnAlbum.TabIndex = 2;
            this.btnAlbum.Text = "Álbumes";
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnSong
            // 
            this.btnSong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSong.Location = new System.Drawing.Point(255, 12);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(75, 23);
            this.btnSong.TabIndex = 3;
            this.btnSong.Text = "Canciones";
            this.btnSong.UseVisualStyleBackColor = true;
            this.btnSong.Click += new System.EventHandler(this.btnSong_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(255, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar y subir";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDownload.Location = new System.Drawing.Point(12, 117);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 50);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Descargar";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Enabled = false;
            this.btnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConfiguration.Location = new System.Drawing.Point(93, 144);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(156, 23);
            this.btnConfiguration.TabIndex = 6;
            this.btnConfiguration.Text = "Configuración";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // cbxWebFile
            // 
            this.cbxWebFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWebFile.FormattingEnabled = true;
            this.cbxWebFile.Location = new System.Drawing.Point(93, 117);
            this.cbxWebFile.Name = "cbxWebFile";
            this.cbxWebFile.Size = new System.Drawing.Size(156, 21);
            this.cbxWebFile.TabIndex = 7;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(136, 60);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(74, 18);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "Versión: 0";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblSessionVersion
            // 
            this.lblSessionVersion.AutoSize = true;
            this.lblSessionVersion.Location = new System.Drawing.Point(145, 78);
            this.lblSessionVersion.Name = "lblSessionVersion";
            this.lblSessionVersion.Size = new System.Drawing.Size(51, 13);
            this.lblSessionVersion.TabIndex = 9;
            this.lblSessionVersion.Text = "Sesión: 0";
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(93, 94);
            this.txtPIN.MaxLength = 20;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(156, 20);
            this.txtPIN.TabIndex = 10;
            this.txtPIN.UseSystemPasswordChar = true;
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(13, 42);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(317, 20);
            this.txtServer.TabIndex = 11;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 179);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.lblSessionVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cbxWebFile);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSong);
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.btnArtist);
            this.Controls.Add(this.btnUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnSong;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.ComboBox cbxWebFile;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSessionVersion;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox txtServer;
    }
}