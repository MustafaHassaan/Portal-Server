namespace Portal.View.Security
{
    partial class Sign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign));
            this.TUserName = new System.Windows.Forms.TextBox();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.Lbl = new System.Windows.Forms.Label();
            this.Menue = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CCB = new System.Windows.Forms.ComboBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // TUserName
            // 
            this.TUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUserName.Location = new System.Drawing.Point(123, 72);
            this.TUserName.Name = "TUserName";
            this.TUserName.Size = new System.Drawing.Size(217, 20);
            this.TUserName.TabIndex = 0;
            this.TUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TUserName_KeyDown);
            // 
            // TPhone
            // 
            this.TPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPhone.Location = new System.Drawing.Point(123, 124);
            this.TPhone.MaxLength = 11;
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(217, 20);
            this.TPhone.TabIndex = 3;
            this.TPhone.TextChanged += new System.EventHandler(this.TPhone_TextChanged);
            this.TPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TPhone_KeyDown);
            this.TPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPhone_KeyPress);
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblUserName.Location = new System.Drawing.Point(12, 71);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(111, 22);
            this.LblUserName.TabIndex = 85;
            this.LblUserName.Text = "UserName : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 86;
            this.label1.Text = "Phone : ";
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
            this.Header.TabIndex = 87;
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
            this.Lbl.Size = new System.Drawing.Size(90, 24);
            this.Lbl.TabIndex = 85;
            this.Lbl.Text = "Signe Up";
            // 
            // Menue
            // 
            this.Menue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Menue.BackColor = System.Drawing.Color.Transparent;
            this.Menue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menue.Image = global::Server.Properties.Resources.conference_96px;
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
            // BSend
            // 
            this.BSend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSend.FlatAppearance.BorderSize = 0;
            this.BSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSend.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSend.Location = new System.Drawing.Point(140, 181);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(63, 30);
            this.BSend.TabIndex = 93;
            this.BSend.Text = "Signe";
            this.BSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSend.UseVisualStyleBackColor = true;
            this.BSend.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 95;
            this.label2.Text = "Password : ";
            // 
            // TPassword
            // 
            this.TPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPassword.Location = new System.Drawing.Point(123, 98);
            this.TPassword.MaxLength = 200;
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(217, 20);
            this.TPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 96;
            this.label3.Text = "Position : ";
            // 
            // CCB
            // 
            this.CCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCB.FormattingEnabled = true;
            this.CCB.Location = new System.Drawing.Point(123, 150);
            this.CCB.Name = "CCB";
            this.CCB.Size = new System.Drawing.Size(217, 26);
            this.CCB.TabIndex = 99;
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(352, 223);
            this.Controls.Add(this.CCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TPassword);
            this.Controls.Add(this.BSend);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.TUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign";
            this.Load += new System.EventHandler(this.Sign_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TUserName;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox Menue;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CCB;
    }
}