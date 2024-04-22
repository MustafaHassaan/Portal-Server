using Controler;
using Portal.View.Transactions;
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
    public partial class ServerCustomers : Form
    {
        int mov;
        int movx;
        int movy;
        PortalContext Db;
        public ServerCustomers()
        {
            InitializeComponent();
        }
        private async void List()
        {
            try
            {
                Db = new PortalContext();
                var List = from Cust in Db.Customers
                           join Emp in Db.Users
                           on Cust.UserId equals Emp.Id
                           select new
                           {
                               Cust.CustName,
                               Cust.CustPhone,
                               Cust.AnotherPhone,
                               Cust.LinePhone
                           };
                DGV.DataSource = List.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }

        //SLN : Search By Name Of List
        private async void SLN()
        {
            Db = new PortalContext();
            var List = from Cust in Db.Customers
                       where Cust.CustName.Contains(TCName.Text)
                       join Emp in Db.Users
                       on Cust.UserId equals Emp.Id
                       select new
                       {
                           Cust.CustName,
                           Cust.CustPhone,
                           Cust.AnotherPhone,
                           Cust.LinePhone
                       };
            DGV.DataSource = List.ToList();
        }

        //SLP : Search By Phone Of List
        private async void SLP()
        {
            Db = new PortalContext();
            var List = from Cust in Db.Customers
                       where (Cust.CustPhone.Contains(TCPhone.Text) || Cust.AnotherPhone.Contains(TCPhone.Text) || Cust.LinePhone.Contains(TCPhone.Text))
                       join Emp in Db.Users
                       on Cust.UserId equals Emp.Id
                       select new
                       {
                           Cust.CustName,
                           Cust.CustPhone,
                           Cust.AnotherPhone,
                           Cust.LinePhone
                       };
            DGV.DataSource = List.ToList();
        }

        //SLP : Search By Name & Phone Of List
        private async void SLNP()
        {
            Db = new PortalContext();
            var List = from Cust in Db.Customers
                       where Cust.CustName.Contains(TCName.Text)  && (Cust.CustPhone.Contains(TCPhone.Text) || Cust.AnotherPhone.Contains(TCPhone.Text) || Cust.LinePhone.Contains(TCPhone.Text))
                       join Emp in Db.Users
                       on Cust.UserId equals Emp.Id
                       select new
                       {
                           Cust.CustName,
                           Cust.CustPhone,
                           Cust.AnotherPhone,
                           Cust.LinePhone
                       };
            DGV.DataSource = List.ToList();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void ServerCustomers_Load(object sender, EventArgs e)
        {
            List();
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }
        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }
        private void BClear_Click(object sender, EventArgs e)
        {
            TCName.Clear();
            TCPhone.Clear();
            List();
        }
        private void TCPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Pres Number Only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void BSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TCName.Text) && string.IsNullOrEmpty(TCPhone.Text))
            {
                MessageBox.Show("Please Insert Customer Name Or Phone ...","worning");
            }
            else
            {
                //SLN : Search By Name Of List
                if (!string.IsNullOrEmpty(TCName.Text) && string.IsNullOrEmpty(TCPhone.Text) || TCName.TextLength >= 0 && TCName.TextLength <= 5)
                {
                    SLN();
                }
                //SLP : Search By Phone Of List
                else if (string.IsNullOrEmpty(TCName.Text) && !string.IsNullOrEmpty(TCPhone.Text))
                {
                    SLP();
                }

                //SLP : Search By Name & Phone Of List
                else
                {
                    SLNP();
                }
            }
        }
        private void TCName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(TCName.Text) && string.IsNullOrEmpty(TCPhone.Text))
                {
                    MessageBox.Show("Please Insert Customer Name Or Phone ...", "worning");
                }
                else
                {
                    //SLN : Search By Name Of List
                    if (!string.IsNullOrEmpty(TCName.Text) && string.IsNullOrEmpty(TCPhone.Text))
                    {
                        SLN();
                    }
                    //SLP : Search By Phone Of List
                    else if (string.IsNullOrEmpty(TCName.Text) && !string.IsNullOrEmpty(TCPhone.Text))
                    {
                        SLP();
                    }

                    //SLP : Search By Name & Phone Of List
                    else
                    {
                        SLNP();
                    }
                }
            }
        }
        private void TCPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(TCName.Text) && string.IsNullOrEmpty(TCPhone.Text))
                {
                    MessageBox.Show("Please Insert Customer Name Or Phone ...", "worning");
                }
                else
                {
                    //SLN : Search By Name Of List
                    if (!string.IsNullOrEmpty(TCName.Text) && string.IsNullOrEmpty(TCPhone.Text))
                    {
                        SLN();
                    }
                    //SLP : Search By Phone Of List
                    else if (string.IsNullOrEmpty(TCName.Text) && !string.IsNullOrEmpty(TCPhone.Text))
                    {
                        SLP();
                    }

                    //SLP : Search By Name & Phone Of List
                    else
                    {
                        SLNP();
                    }
                }
            }
        }
    }
}
