using Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.View.Security
{
    public partial class Positions : Form
    {
        int mov;
        int movx;
        int movy;
        PortalContext Db;
        public Positions()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LblPhone_Click(object sender, EventArgs e)
        {

        }
        private void TCName_TextChanged(object sender, EventArgs e)
        {
        }
        private void BClear_Click(object sender, EventArgs e)
        {
            TCName.Clear();
            BEdit.Visible = false;
            BDel.Visible = false;
        }
        private void Positions_Load(object sender, EventArgs e)
        {
            List();
        }
        private async void List()
        {
            try
            {
                Db = new PortalContext();
                var List = from Pos in Db.Positions
                           select new
                           {
                               Pos.Id,
                               Pos.PositionName
                           };
                DGV.DataSource = List.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...", "Error");
            }
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TCName.Text = DGV.CurrentRow.Cells[1].Value.ToString();
            BEdit.Visible = true;
            BDel.Visible = true;
        }
        private void TCName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(TCName.Text))
            {
                BSave.Visible = true;
            }
            else
            {
                BSave.Visible = false;
            }
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }
        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }
    }
}
