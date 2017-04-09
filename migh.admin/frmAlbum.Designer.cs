namespace migh.admin
{
    partial class frmAlbum
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
            this.btnDeleteAlbum = new System.Windows.Forms.Button();
            this.btnEditAlbum = new System.Windows.Forms.Button();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.listAlbum = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxAlbumArtist = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAlbum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteAlbum.Location = new System.Drawing.Point(174, 273);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAlbum.TabIndex = 22;
            this.btnDeleteAlbum.Text = "Eliminar";
            this.btnDeleteAlbum.UseVisualStyleBackColor = true;
            this.btnDeleteAlbum.Click += new System.EventHandler(this.btnDeleteAlbum_Click);
            // 
            // btnEditAlbum
            // 
            this.btnEditAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditAlbum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditAlbum.Location = new System.Drawing.Point(93, 273);
            this.btnEditAlbum.Name = "btnEditAlbum";
            this.btnEditAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnEditAlbum.TabIndex = 21;
            this.btnEditAlbum.Text = "Modificar";
            this.btnEditAlbum.UseVisualStyleBackColor = true;
            this.btnEditAlbum.Click += new System.EventHandler(this.btnEditAlbum_Click);
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAlbum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddAlbum.Location = new System.Drawing.Point(12, 273);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnAddAlbum.TabIndex = 20;
            this.btnAddAlbum.Text = "Agregar";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // listAlbum
            // 
            this.listAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAlbum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6});
            this.listAlbum.FullRowSelect = true;
            this.listAlbum.Location = new System.Drawing.Point(15, 33);
            this.listAlbum.MultiSelect = false;
            this.listAlbum.Name = "listAlbum";
            this.listAlbum.Size = new System.Drawing.Size(621, 234);
            this.listAlbum.TabIndex = 19;
            this.listAlbum.UseCompatibleStateImageBehavior = false;
            this.listAlbum.View = System.Windows.Forms.View.Details;
            this.listAlbum.SelectedIndexChanged += new System.EventHandler(this.listAlbum_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre";
            this.columnHeader4.Width = 302;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Artista";
            this.columnHeader6.Width = 291;
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlbumName.Location = new System.Drawing.Point(320, 6);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(316, 20);
            this.txtAlbumName.TabIndex = 18;
            this.txtAlbumName.TextChanged += new System.EventHandler(this.txtAlbumName_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre";
            // 
            // cbxAlbumArtist
            // 
            this.cbxAlbumArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlbumArtist.FormattingEnabled = true;
            this.cbxAlbumArtist.Location = new System.Drawing.Point(54, 6);
            this.cbxAlbumArtist.Name = "cbxAlbumArtist";
            this.cbxAlbumArtist.Size = new System.Drawing.Size(210, 21);
            this.cbxAlbumArtist.TabIndex = 16;
            this.cbxAlbumArtist.SelectedIndexChanged += new System.EventHandler(this.cbxAlbumArtist_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Artista";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(561, 273);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(75, 23);
            this.btnUpgrade.TabIndex = 23;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // frmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 308);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnDeleteAlbum);
            this.Controls.Add(this.btnEditAlbum);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.listAlbum);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxAlbumArtist);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlbum";
            this.Load += new System.EventHandler(this.frmAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAlbum;
        private System.Windows.Forms.Button btnEditAlbum;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.ListView listAlbum;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxAlbumArtist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpgrade;
    }
}