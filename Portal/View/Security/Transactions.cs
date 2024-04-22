using Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.View.Security
{
    public partial class Transactions : Form
    {
        int mov;
        int movx;
        int movy;
        public Transactions()
        {
            InitializeComponent();
            DGV.Refresh();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
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
        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Transactions_Load(object sender, EventArgs e)
        {
            try
            {
                GettransList();
            }
            catch (Exception)
            {

                MessageBox.Show("The Server Is Dowen Please Try Again ...", "Server Error");
            }
        }
        public void GettransList()
        {
            PortalContext Dbd = new PortalContext();
            var DT = from Trans in Dbd.TransActions
                      join USING in Dbd.Users
                      on Trans.UserId equals USING.Id
                      select new
                      {
                          Trans.SMSPhone,
                          Trans.SMSBody,
                          Trans.Languge,
                          Trans.Status,
                          Trans.Result,
                          Trans.Date,
                          Trans.Time,
                          USING.UserName,
                          USING.PhoneNumber
                      };
            DGV.DataSource = DT.ToList();
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TPhone.Text = DGV.CurrentRow.Cells[0].Value.ToString();
            TMessage.Text = DGV.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
