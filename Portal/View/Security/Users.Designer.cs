namespace Portal.View.Security
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.Header = new System.Windows.Forms.Panel();
            this.LblId = new System.Windows.Forms.Label();
            this.Menue = new System.Windows.Forms.PictureBox();
            this.LblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.BDel = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.TUserName = new System.Windows.Forms.TextBox();
            this.CCB = new System.Windows.Forms.ComboBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Header.Controls.Add(this.LblId);
            this.Header.Controls.Add(this.Menue);
            this.Header.Controls.Add(this.LblName);
            this.Header.Controls.Add(this.pictureBox2);
            this.Header.Controls.Add(this.Close);
            this.Header.Controls.Add(this.panel1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(549, 50);
            this.Header.TabIndex = 7;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // LblId
            // 
            this.LblId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblId.AutoSize = true;
            this.LblId.BackColor = System.Drawing.Color.Transparent;
            this.LblId.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblId.ForeColor = System.Drawing.Color.MediumOrchid;
            this.LblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblId.Location = new System.Drawing.Point(184, 16);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 24);
            this.LblId.TabIndex = 77;
            this.LblId.Text = "0";
            this.LblId.Visible = false;
            // 
            // Menue
            // 
            this.Menue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Menue.BackColor = System.Drawing.Color.Transparent;
            this.Menue.Cursor = System.Windows.Forms.Cursors.Default;
            this.Menue.Image = global::Server.Properties.Resources.user_groups_96px;
            this.Menue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Menue.Location = new System.Drawing.Point(12, 10);
            this.Menue.Name = "Menue";
            this.Menue.Size = new System.Drawing.Size(39, 37);
            this.Menue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menue.TabIndex = 76;
            this.Menue.TabStop = false;
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblName.ForeColor = System.Drawing.Color.MediumOrchid;
            this.LblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblName.Location = new System.Drawing.Point(58, 16);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(120, 24);
            this.LblName.TabIndex = 74;
            this.LblName.Text = "Users Portal";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(462, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close.Location = new System.Drawing.Point(507, 10);
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
            this.panel1.Size = new System.Drawing.Size(549, 3);
            this.panel1.TabIndex = 71;
            // 
            // DGV
            // 
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(28, 176);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(492, 325);
            this.DGV.TabIndex = 90;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // BDel
            // 
            this.BDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDel.FlatAppearance.BorderSize = 0;
            this.BDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BDel.Image = global::Server.Properties.Resources.delete_32px;
            this.BDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDel.Location = new System.Drawing.Point(257, 507);
            this.BDel.Name = "BDel";
            this.BDel.Size = new System.Drawing.Size(107, 46);
            this.BDel.TabIndex = 113;
            this.BDel.Text = "Delete";
            this.BDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDel.UseVisualStyleBackColor = true;
            this.BDel.Visible = false;
            this.BDel.Click += new System.EventHandler(this.BDel_Click);
            // 
            // BEdit
            // 
            this.BEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEdit.FlatAppearance.BorderSize = 0;
            this.BEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEdit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BEdit.Image = global::Server.Properties.Resources.edit_property_32px;
            this.BEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEdit.Location = new System.Drawing.Point(163, 507);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(88, 46);
            this.BEdit.TabIndex = 112;
            this.BEdit.Text = "Edit";
            this.BEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Visible = false;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 120;
            this.label3.Text = "Category : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 119;
            this.label2.Text = "Password : ";
            // 
            // TPassword
            // 
            this.TPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPassword.Location = new System.Drawing.Point(135, 91);
            this.TPassword.MaxLength = 200;
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(385, 20);
            this.TPassword.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(24, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 118;
            this.label1.Text = "Phone : ";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblUserName.Location = new System.Drawing.Point(24, 64);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(111, 22);
            this.LblUserName.TabIndex = 117;
            this.LblUserName.Text = "UserName : ";
            // 
            // TPhone
            // 
            this.TPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPhone.Location = new System.Drawing.Point(135, 117);
            this.TPhone.MaxLength = 11;
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(385, 20);
            this.TPhone.TabIndex = 116;
            // 
            // TUserName
            // 
            this.TUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUserName.Location = new System.Drawing.Point(135, 65);
            this.TUserName.Name = "TUserName";
            this.TUserName.Size = new System.Drawing.Size(385, 20);
            this.TUserName.TabIndex = 114;
            // 
            // CCB
            // 
            this.CCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCB.FormattingEnabled = true;
            this.CCB.Location = new System.Drawing.Point(135, 144);
            this.CCB.Name = "CCB";
            this.CCB.Size = new System.Drawing.Size(385, 26);
            this.CCB.TabIndex = 122;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(549, 561);
            this.Controls.Add(this.CCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.TUserName);
            this.Controls.Add(this.BDel);
            this.Controls.Add(this.BEdit);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Menue;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button BDel;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.TextBox TUserName;
        private System.Windows.Forms.Label LblId;
        public System.Windows.Forms.ComboBox CCB;
    }
}