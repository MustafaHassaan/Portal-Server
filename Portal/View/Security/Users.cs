using Controler;
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
    public partial class Users : Form
    {
        int mov;
        int movx;
        int movy;
        PortalContext Db;
        public Users()
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
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }
        private async void List()
        {
            Db = new PortalContext();
            var id = long.Parse(LblId.Text);
            try
            {
                var user = await Db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
                var List = from users in Db.Users
                           join pos in Db.Positions
                           on users.PositionId equals pos.Id
                           select new
                           {
                               users.Id,
                               users.UserName,
                               users.Password,
                               users.PhoneNumber,
                               pos.PositionName
                           };
                DGV.DataSource = List.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }
        public void GP()
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
        private async void Users_Load(object sender, EventArgs e)
        {
            try
            {
                List();
                GP();
            }
            catch (Exception)
            {

                MessageBox.Show("The Server Is Dowen Please Try Again ...", "Server Error");
            }
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.Rows.Count > 0)
            {
                LblId.Text = DGV.CurrentRow.Cells[0].Value.ToString();
                TUserName.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                TPassword.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                TPhone.Text = DGV.CurrentRow.Cells[3].Value.ToString();
                CCB.Text = DGV.CurrentRow.Cells[4].Value.ToString();
                BEdit.Visible = true;
                BDel.Visible = true;
            }
        }
        private async void BEdit_Click(object sender, EventArgs e)
        {
            Db = new PortalContext();
            var id = Int32.Parse(LblId.Text);
            var user = await Db.Users.Where(X => X.Id == id).FirstOrDefaultAsync();
            user.UserName = TUserName.Text;
            user.Password = TPassword.Text;
            user.PhoneNumber = TPhone.Text;
            user.PositionId = int.Parse(CCB.SelectedValue.ToString());
            Db.Entry(user).State = EntityState.Modified;
            await Db.SaveChangesAsync();
            MessageBox.Show("User Is Editing Successfully ...", "Success");
            List();
        }
        private async void BDel_Click(object sender, EventArgs e)
        {
            Db = new PortalContext();
            var id = Int32.Parse(LblId.Text);
            var user = await Db.Users.Where(X => X.Id == id).FirstOrDefaultAsync();
            Db.Users.Remove(user);
            await Db.SaveChangesAsync();
            MessageBox.Show("User Is Deleted Successfully ...", "Success");
            List();
        }
    }
}
