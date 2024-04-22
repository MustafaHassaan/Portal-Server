using Controler;
using Portal.View.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.View.Security
{
    public partial class Sign : Form
    {
        int mov;
        int movx;
        int movy;
        public Sign()
        {
            InitializeComponent();
        }
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TUserName.Text) || string.IsNullOrEmpty(TPhone.Text) || string.IsNullOrEmpty(TPassword.Text))
            {
                MessageBox.Show("Please Insert UserName & Phone ...", "Faild");
                return;
            }
            else if (string.IsNullOrEmpty(CCB.Text))
            {
                MessageBox.Show("Shoud Choose Type Of User ...", "Faild");
                return;
            }
            else
            {
                PortalContext Db = new PortalContext();
                var users = new Model.User();
                users.UserName = TUserName.Text;
                users.PhoneNumber = TPhone.Text;
                users.Password = TPassword.Text;
                users.PositionId = int.Parse(CCB.SelectedValue.ToString());
                foreach (var item in Db.Users)
                {
                    if (item.UserName == users.UserName && item.PhoneNumber == users.PhoneNumber)
                    {
                        MessageBox.Show("This Account Is Already Saved Pefor ...", "Warning");
                        return;
                    }
                    else if (item.UserName == users.UserName)
                    {
                        MessageBox.Show("This UserName Is Already Saved Pefor ...", "Warning");
                        return;
                    }
                    else if (item.PhoneNumber == users.PhoneNumber)
                    {
                        MessageBox.Show("This Phone Is Already Saved Pefor ...", "Warning");
                        return;
                    }
                    else if (TPhone.Text.Length < 11)
                    {
                        MessageBox.Show("The Password Less Than 11 Charcter " + "\n" + "Must Be Biger Or Equal 11 Charcter ...", "Warning");
                        return;
                    }
                    else if (TPassword.Text.Length < 8)
                    {
                        MessageBox.Show("The Password Less Than 8 Charcter "+"\n"+"Must Be Biger Or Equal 8 Charcter ...", "Warning");
                        return;
                    }
                }
                Db.Users.Add(users);
                await Db.SaveChangesAsync();
                MessageBox.Show("User Is Saved Successfully ...", "Success");
                TUserName.Clear();
                TPhone.Clear();
                this.Close();
            }
        }
        public void GP()
        {
            try
            {
                string constr = @"Data Source=192.168.3.180;Initial Catalog=Portal;Persist Security Info=True;User ID=PCServicesAdministrator;Password=PCS2020";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Id, PositionName FROM Positions", con))
                    {
                        //Fill the DataTable with records from Table.
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        //Insert the Default Item to DataTable.
                        DataRow row = dt.NewRow();
                        row[0] = 0;
                        row[1] = "-- Select Position --";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        CCB.DataSource = dt;
                        CCB.DisplayMember = "PositionName";
                        CCB.ValueMember = "Id";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...", "Error");
            }
        }
        private void Sign_Load(object sender, EventArgs e)
        {
            GP();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private async void BSend_Click(object sender, EventArgs e)
        {
        }
        private async void TUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(TUserName.Text) || string.IsNullOrEmpty(TPhone.Text))
                {
                    MessageBox.Show("Please Insert UserName & Phone ...", "Faild");
                    return;
                }
                else
                {
                    PortalContext Db = new PortalContext();
                    var users = new Model.User();
                    users.UserName = TUserName.Text;
                    users.PhoneNumber = TPhone.Text;
                    foreach (var item in Db.Users)
                    {
                        if (item.UserName == users.UserName && item.PhoneNumber == users.PhoneNumber)
                        {
                            MessageBox.Show("This Account Is Already Saved Pefor ...", "Warning");
                            return;
                        }
                        else if (item.PhoneNumber == users.PhoneNumber)
                        {
                            MessageBox.Show("This Phone Is Already Saved Pefor ...", "Warning");
                            return;
                        }
                    }
                    Db.Users.Add(users);
                    await Db.SaveChangesAsync();
                    TUserName.Clear();
                    TPhone.Clear();
                    MessageBox.Show("User Is Saved Successfully ...", "Success");
                    this.Close();
                }
            }
        }
        private async void TPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(TUserName.Text) || string.IsNullOrEmpty(TPhone.Text))
                {
                    MessageBox.Show("Please Insert UserName & Phone ...", "Faild");
                    return;
                }
                else
                {
                    PortalContext Db = new PortalContext();
                    var users = new Model.User();
                    users.UserName = TUserName.Text;
                    users.PhoneNumber = TPhone.Text;
                    users.Password = TPassword.Text;
                    foreach (var item in Db.Users)
                    {
                        if (item.UserName == users.UserName && item.PhoneNumber == users.PhoneNumber)
                        {
                            MessageBox.Show("This Account Is Already Saved Pefor ...", "Warning");
                            return;
                        }
                        else if (item.UserName == users.UserName)
                        {
                            MessageBox.Show("This UserName Is Already Saved Pefor ...", "Warning");
                            return;
                        }
                        else if (item.PhoneNumber == users.PhoneNumber)
                        {
                            MessageBox.Show("This Phone Is Already Saved Pefor ...", "Warning");
                            return;
                        }
                        else if (TPhone.Text.Length < 11)
                        {
                            MessageBox.Show("The Password Less Than 11 Charcter " + "\n" + "Must Be Biger Or Equal 11 Charcter ...", "Warning");
                            return;
                        }
                        else if (TPassword.Text.Length < 8)
                        {
                            MessageBox.Show("The Password Less Than 8 Charcter " + "\n" + "Must Be Biger Or Equal 8 Charcter ...", "Warning");
                            return;
                        }
                    }
                    Db.Users.Add(users);
                    await Db.SaveChangesAsync();
                    TUserName.Clear();
                    TPhone.Clear();
                    MessageBox.Show("User Is Saved Successfully ...", "Success");
                    this.Close();
                }
            }
        }
        private void TPhone_TextChanged(object sender, EventArgs e)
        {

        }
        private void TPhone_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
