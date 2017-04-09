namespace migh.admin
{
    partial class frmSong
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
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.btnEditSong = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.listSong = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxSongAlbum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSongArtist = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAlbumCreator = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteSong.Location = new System.Drawing.Point(174, 332);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSong.TabIndex = 23;
            this.btnDeleteSong.Text = "Eliminar";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // btnEditSong
            // 
            this.btnEditSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditSong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditSong.Location = new System.Drawing.Point(93, 332);
            this.btnEditSong.Name = "btnEditSong";
            this.btnEditSong.Size = new System.Drawing.Size(75, 23);
            this.btnEditSong.TabIndex = 22;
            this.btnEditSong.Text = "Modificar";
            this.btnEditSong.UseVisualStyleBackColor = true;
            this.btnEditSong.Click += new System.EventHandler(this.btnEditSong_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddSong.Location = new System.Drawing.Point(12, 332);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 21;
            this.btnAddSong.Text = "Agregar";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(62, 33);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(210, 20);
            this.txtSongName.TabIndex = 20;
            this.txtSongName.TextChanged += new System.EventHandler(this.txtSongName_TextChanged);
            // 
            // listSong
            // 
            this.listSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8});
            this.listSong.FullRowSelect = true;
            this.listSong.Location = new System.Drawing.Point(12, 59);
            this.listSong.Name = "listSong";
            this.listSong.Size = new System.Drawing.Size(625, 267);
            this.listSong.TabIndex = 19;
            this.listSong.UseCompatibleStateImageBehavior = false;
            this.listSong.View = System.Windows.Forms.View.Details;
            this.listSong.SelectedIndexChanged += new System.EventHandler(this.listSong_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nombre";
            this.columnHeader5.Width = 239;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Álbum";
            this.columnHeader7.Width = 189;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Artista";
            this.columnHeader8.Width = 166;
            // 
            // cbxSongAlbum
            // 
            this.cbxSongAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSongAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSongAlbum.FormattingEnabled = true;
            this.cbxSongAlbum.Location = new System.Drawing.Point(320, 6);
            this.cbxSongAlbum.Name = "cbxSongAlbum";
            this.cbxSongAlbum.Size = new System.Drawing.Size(317, 21);
            this.cbxSongAlbum.TabIndex = 18;
            this.cbxSongAlbum.SelectedIndexChanged += new System.EventHandler(this.cbxSongAlbum_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Álbum";
            // 
            // cbxSongArtist
            // 
            this.cbxSongArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSongArtist.FormattingEnabled = true;
            this.cbxSongArtist.Location = new System.Drawing.Point(62, 6);
            this.cbxSongArtist.Name = "cbxSongArtist";
            this.cbxSongArtist.Size = new System.Drawing.Size(210, 21);
            this.cbxSongArtist.TabIndex = 16;
            this.cbxSongArtist.SelectedIndexChanged += new System.EventHandler(this.cbxSongArtist_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Artista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nombre";
            // 
            // btnAlbumCreator
            // 
            this.btnAlbumCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlbumCreator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlbumCreator.Location = new System.Drawing.Point(537, 332);
            this.btnAlbumCreator.Name = "btnAlbumCreator";
            this.btnAlbumCreator.Size = new System.Drawing.Size(100, 23);
            this.btnAlbumCreator.TabIndex = 25;
            this.btnAlbumCreator.Text = "Crear álbum";
            this.btnAlbumCreator.UseVisualStyleBackColor = true;
            this.btnAlbumCreator.Click += new System.EventHandler(this.btnAlbumCreator_Click);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(456, 332);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(75, 23);
            this.btnUpgrade.TabIndex = 26;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // frmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 367);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnAlbumCreator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnEditSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.listSong);
            this.Controls.Add(this.cbxSongAlbum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxSongArtist);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(665, 405);
            this.Name = "frmSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSong";
            this.Load += new System.EventHandler(this.frmSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.Button btnEditSong;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.ListView listSong;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cbxSongAlbum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSongArtist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAlbumCreator;
        private System.Windows.Forms.Button btnUpgrade;
    }
}