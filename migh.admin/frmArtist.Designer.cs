namespace migh.admin
{
    partial class frmArtist
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
            this.btnDeleteArtist = new System.Windows.Forms.Button();
            this.btnEditArtist = new System.Windows.Forms.Button();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.listArtist = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteArtist
            // 
            this.btnDeleteArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteArtist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteArtist.Location = new System.Drawing.Point(174, 293);
            this.btnDeleteArtist.Name = "btnDeleteArtist";
            this.btnDeleteArtist.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteArtist.TabIndex = 17;
            this.btnDeleteArtist.Text = "Eliminar";
            this.btnDeleteArtist.UseVisualStyleBackColor = true;
            this.btnDeleteArtist.Click += new System.EventHandler(this.btnDeleteArtist_Click);
            // 
            // btnEditArtist
            // 
            this.btnEditArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditArtist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditArtist.Location = new System.Drawing.Point(93, 293);
            this.btnEditArtist.Name = "btnEditArtist";
            this.btnEditArtist.Size = new System.Drawing.Size(75, 23);
            this.btnEditArtist.TabIndex = 16;
            this.btnEditArtist.Text = "Modificar";
            this.btnEditArtist.UseVisualStyleBackColor = true;
            this.btnEditArtist.Click += new System.EventHandler(this.btnEditArtist_Click);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddArtist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddArtist.Location = new System.Drawing.Point(12, 293);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtist.TabIndex = 15;
            this.btnAddArtist.Text = "Agregar";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // listArtist
            // 
            this.listArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listArtist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listArtist.FullRowSelect = true;
            this.listArtist.Location = new System.Drawing.Point(12, 32);
            this.listArtist.MultiSelect = false;
            this.listArtist.Name = "listArtist";
            this.listArtist.Size = new System.Drawing.Size(501, 255);
            this.listArtist.TabIndex = 14;
            this.listArtist.UseCompatibleStateImageBehavior = false;
            this.listArtist.View = System.Windows.Forms.View.Details;
            this.listArtist.SelectedIndexChanged += new System.EventHandler(this.listArtist_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            this.columnHeader3.Width = 376;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(62, 6);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(259, 20);
            this.txtArtistName.TabIndex = 13;
            this.txtArtistName.TextChanged += new System.EventHandler(this.txtArtistName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(438, 293);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(75, 23);
            this.btnUpgrade.TabIndex = 18;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // frmArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 328);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnDeleteArtist);
            this.Controls.Add(this.btnEditArtist);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.listArtist);
            this.Controls.Add(this.txtArtistName);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(353, 266);
            this.Name = "frmArtist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArtist";
            this.Load += new System.EventHandler(this.frmArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteArtist;
        private System.Windows.Forms.Button btnEditArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.ListView listArtist;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpgrade;
    }
}