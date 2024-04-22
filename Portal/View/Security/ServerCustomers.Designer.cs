namespace Portal.View.Security
{
    partial class ServerCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerCustomers));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.TCPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TCName = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BSearch = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 200);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(730, 343);
            this.DGV.TabIndex = 112;
            // 
            // TCPhone
            // 
            this.TCPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCPhone.Location = new System.Drawing.Point(187, 103);
            this.TCPhone.MaxLength = 11;
            this.TCPhone.Multiline = true;
            this.TCPhone.Name = "TCPhone";
            this.TCPhone.Size = new System.Drawing.Size(555, 29);
            this.TCPhone.TabIndex = 111;
            this.TCPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TCPhone_KeyDown);
            this.TCPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCPhone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 110;
            this.label1.Text = "Phone Number : ";
            // 
            // TCName
            // 
            this.TCName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCName.Location = new System.Drawing.Point(187, 68);
            this.TCName.MaxLength = 150;
            this.TCName.Multiline = true;
            this.TCName.Name = "TCName";
            this.TCName.Size = new System.Drawing.Size(555, 29);
            this.TCName.TabIndex = 109;
            this.TCName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TCName_KeyDown);
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblPhone.Location = new System.Drawing.Point(9, 68);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(172, 24);
            this.LblPhone.TabIndex = 108;
            this.LblPhone.Text = "Customer Name : ";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.LblName);
            this.Header.Controls.Add(this.pictureBox2);
            this.Header.Controls.Add(this.Close);
            this.Header.Controls.Add(this.panel1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(754, 50);
            this.Header.TabIndex = 107;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Server.Properties.Resources.user_manual_96px;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
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
            this.LblName.Location = new System.Drawing.Point(58, 17);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(105, 24);
            this.LblName.TabIndex = 74;
            this.LblName.Text = "Customers";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(667, 10);
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
            this.Close.Location = new System.Drawing.Point(712, 10);
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
            this.panel1.Size = new System.Drawing.Size(754, 3);
            this.panel1.TabIndex = 71;
            // 
            // BSearch
            // 
            this.BSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSearch.FlatAppearance.BorderSize = 0;
            this.BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BSearch.Image = global::Server.Properties.Resources.search_32px;
            this.BSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSearch.Location = new System.Drawing.Point(270, 148);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(110, 46);
            this.BSearch.TabIndex = 113;
            this.BSearch.Text = "Search";
            this.BSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSearch.UseVisualStyleBackColor = true;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BClear
            // 
            this.BClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BClear.FlatAppearance.BorderSize = 0;
            this.BClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BClear.Image = global::Server.Properties.Resources.broom_32px;
            this.BClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BClear.Location = new System.Drawing.Point(386, 148);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(105, 46);
            this.BClear.TabIndex = 114;
            this.BClear.Text = "Clear";
            this.BClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // ServerCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(754, 555);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BSearch);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.TCPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCName);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerCustomers";
            this.Load += new System.EventHandler(this.ServerCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox TCPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCName;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.Button BClear;
    }
}