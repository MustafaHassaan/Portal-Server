namespace Portal.View.Security
{
    partial class ServerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerLogin));
            this.Header = new System.Windows.Forms.Panel();
            this.Lbl = new System.Windows.Forms.Label();
            this.Menue = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BSL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TUserName = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Header.Controls.Add(this.Lbl);
            this.Header.Controls.Add(this.Menue);
            this.Header.Controls.Add(this.Close);
            this.Header.Controls.Add(this.panel1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(352, 50);
            this.Header.TabIndex = 102;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lbl.Location = new System.Drawing.Point(57, 17);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(126, 24);
            this.Lbl.TabIndex = 85;
            this.Lbl.Text = "Login Server";
            // 
            // Menue
            // 
            this.Menue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Menue.BackColor = System.Drawing.Color.Transparent;
            this.Menue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menue.Image = global::Server.Properties.Resources.workstation_64px;
            this.Menue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Menue.Location = new System.Drawing.Point(12, 10);
            this.Menue.Name = "Menue";
            this.Menue.Size = new System.Drawing.Size(39, 37);
            this.Menue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menue.TabIndex = 76;
            this.Menue.TabStop = false;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close.Location = new System.Drawing.Point(310, 10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(39, 37);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 72;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 3);
            this.panel1.TabIndex = 71;
            // 
            // BSL
            // 
            this.BSL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BSL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSL.FlatAppearance.BorderSize = 0;
            this.BSL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BSL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSL.Location = new System.Drawing.Point(150, 118);
            this.BSL.Name = "BSL";
            this.BSL.Size = new System.Drawing.Size(71, 30);
            this.BSL.TabIndex = 107;
            this.BSL.Text = "Login";
            this.BSL.UseVisualStyleBackColor = true;
            this.BSL.Click += new System.EventHandler(this.BSL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 106;
            this.label2.Text = "Password : ";
            // 
            // TPassword
            // 
            this.TPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPassword.Location = new System.Drawing.Point(123, 92);
            this.TPassword.MaxLength = 200;
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(184, 20);
            this.TPassword.TabIndex = 104;
            this.TPassword.UseSystemPasswordChar = true;
            this.TPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TPassword_KeyDown);
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblUserName.Location = new System.Drawing.Point(12, 65);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(111, 22);
            this.LblUserName.TabIndex = 105;
            this.LblUserName.Text = "UserName : ";
            // 
            // TUserName
            // 
            this.TUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUserName.Location = new System.Drawing.Point(123, 66);
            this.TUserName.Name = "TUserName";
            this.TUserName.Size = new System.Drawing.Size(217, 20);
            this.TUserName.TabIndex = 103;
            this.TUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TUserName_KeyDown);
            // 
            // ShowPassword
            // 
            this.ShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassword.Image = global::Server.Properties.Resources.visible_96px;
            this.ShowPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ShowPassword.Location = new System.Drawing.Point(314, 92);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(26, 21);
            this.ShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowPassword.TabIndex = 108;
            this.ShowPassword.TabStop = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // ServerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(352, 153);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.BSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TPassword);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.TUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerLogin";
            this.Load += new System.EventHandler(this.ServerLogin_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.PictureBox Menue;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ShowPassword;
        private System.Windows.Forms.Button BSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TUserName;
    }
}