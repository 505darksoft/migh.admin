namespace migh.admin
{
    partial class frmEdit_Song
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
            this.txtSongURLName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAlbum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSongURLName
            // 
            this.txtSongURLName.Location = new System.Drawing.Point(87, 91);
            this.txtSongURLName.Name = "txtSongURLName";
            this.txtSongURLName.Size = new System.Drawing.Size(350, 20);
            this.txtSongURLName.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Nombre URL";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOk.Location = new System.Drawing.Point(362, 117);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 45;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(87, 65);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(350, 20);
            this.txtFileName.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Archivo";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(87, 39);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(350, 20);
            this.txtSongName.TabIndex = 42;
            this.txtSongName.TextChanged += new System.EventHandler(this.txtSongName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre";
            // 
            // cbxAlbum
            // 
            this.cbxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlbum.FormattingEnabled = true;
            this.cbxAlbum.Location = new System.Drawing.Point(87, 12);
            this.cbxAlbum.Name = "cbxAlbum";
            this.cbxAlbum.Size = new System.Drawing.Size(350, 21);
            this.cbxAlbum.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Álbum";
            // 
            // frmEdit_Song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 154);
            this.Controls.Add(this.txtSongURLName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxAlbum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdit_Song";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEdit_Song";
            this.Load += new System.EventHandler(this.frmEdit_Song_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSongURLName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAlbum;
        private System.Windows.Forms.Label label1;

    }
}