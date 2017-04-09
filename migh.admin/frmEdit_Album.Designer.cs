namespace migh.admin
{
    partial class frmEdit_Album
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlbumURLName = new System.Windows.Forms.TextBox();
            this.cbxArtist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoverURL = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre URL";
            // 
            // txtAlbumURLName
            // 
            this.txtAlbumURLName.Location = new System.Drawing.Point(87, 65);
            this.txtAlbumURLName.Name = "txtAlbumURLName";
            this.txtAlbumURLName.Size = new System.Drawing.Size(376, 20);
            this.txtAlbumURLName.TabIndex = 2;
            this.txtAlbumURLName.TextChanged += new System.EventHandler(this.txtAlbumURLName_TextChanged);
            // 
            // cbxArtist
            // 
            this.cbxArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArtist.FormattingEnabled = true;
            this.cbxArtist.Location = new System.Drawing.Point(87, 12);
            this.cbxArtist.Name = "cbxArtist";
            this.cbxArtist.Size = new System.Drawing.Size(376, 21);
            this.cbxArtist.TabIndex = 18;
            this.cbxArtist.SelectedIndexChanged += new System.EventHandler(this.cbxArtist_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cover URL";
            // 
            // txtCoverURL
            // 
            this.txtCoverURL.Location = new System.Drawing.Point(87, 91);
            this.txtCoverURL.Name = "txtCoverURL";
            this.txtCoverURL.Size = new System.Drawing.Size(376, 20);
            this.txtCoverURL.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOk.Location = new System.Drawing.Point(388, 117);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(87, 39);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(376, 20);
            this.txtAlbumName.TabIndex = 1;
            this.txtAlbumName.TextChanged += new System.EventHandler(this.txtAlbumName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // frmEdit_Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 151);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlbumURLName);
            this.Controls.Add(this.cbxArtist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCoverURL);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdit_Album";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEdit_Album";
            this.Load += new System.EventHandler(this.frmEdit_Album_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlbumURLName;
        private System.Windows.Forms.ComboBox cbxArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoverURL;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label label1;


    }
}