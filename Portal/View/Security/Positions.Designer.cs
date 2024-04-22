namespace Portal.View.Security
{
    partial class Positions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Positions));
            this.Header = new System.Windows.Forms.Panel();
            this.LblId = new System.Windows.Forms.Label();
            this.Menue = new System.Windows.Forms.PictureBox();
            this.LblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.TCName = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.BDel = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
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
            this.Header.Size = new System.Drawing.Size(473, 50);
            this.Header.TabIndex = 9;
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
            this.LblId.Location = new System.Drawing.Point(162, 16);
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
            this.Menue.Image = global::Server.Properties.Resources.leaderboard_96px;
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
            this.LblName.Size = new System.Drawing.Size(98, 24);
            this.LblName.TabIndex = 74;
            this.LblName.Text = "Memories";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(386, 10);
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
            this.Close.Location = new System.Drawing.Point(431, 10);
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
            this.panel1.Size = new System.Drawing.Size(473, 3);
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
            this.DGV.Location = new System.Drawing.Point(12, 109);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(449, 273);
            this.DGV.TabIndex = 92;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // TCName
            // 
            this.TCName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCName.Location = new System.Drawing.Point(178, 74);
            this.TCName.MaxLength = 150;
            this.TCName.Multiline = true;
            this.TCName.Name = "TCName";
            this.TCName.Size = new System.Drawing.Size(283, 29);
            this.TCName.TabIndex = 111;
            this.TCName.TextChanged += new System.EventHandler(this.TCName_TextChanged);
            this.TCName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCName_KeyPress);
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblPhone.Location = new System.Drawing.Point(15, 75);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(157, 24);
            this.LblPhone.TabIndex = 110;
            this.LblPhone.Text = "Position Name : ";
            this.LblPhone.Click += new System.EventHandler(this.LblPhone_Click);
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
            this.BDel.Location = new System.Drawing.Point(227, 388);
            this.BDel.Name = "BDel";
            this.BDel.Size = new System.Drawing.Size(107, 46);
            this.BDel.TabIndex = 115;
            this.BDel.Text = "Delete";
            this.BDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDel.UseVisualStyleBackColor = true;
            this.BDel.Visible = false;
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
            this.BEdit.Location = new System.Drawing.Point(133, 388);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(88, 46);
            this.BEdit.TabIndex = 114;
            this.BEdit.Text = "Edit";
            this.BEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Visible = false;
            // 
            // BSave
            // 
            this.BSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSave.FlatAppearance.BorderSize = 0;
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BSave.Image = global::Server.Properties.Resources.save_32px;
            this.BSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSave.Location = new System.Drawing.Point(28, 388);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(99, 46);
            this.BSave.TabIndex = 116;
            this.BSave.Text = "Save";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Visible = false;
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
            this.BClear.Location = new System.Drawing.Point(340, 388);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(105, 46);
            this.BClear.TabIndex = 117;
            this.BClear.Text = "Clear";
            this.BClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // Positions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(473, 446);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.BDel);
            this.Controls.Add(this.BEdit);
            this.Controls.Add(this.TCName);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Positions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Positions";
            this.Load += new System.EventHandler(this.Positions_Load);
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
        private System.Windows.Forms.PictureBox Menue;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TCName;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Button BDel;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BClear;
    }
}