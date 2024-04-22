using Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.View.Security
{
    public partial class Memories : Form
    {
        int mov;
        int movx;
        int movy;
        PortalContext Db;
        public Memories()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
        public void GU()
        {
            try
            {
                string constr = @"Data Source=192.168.3.180;Initial Catalog=Portal;Persist Security Info=True;User ID=PCServicesAdministrator;Password=PCS2020";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Id, UserName FROM Users", con))
                    {
                        //Fill the DataTable with records from Table.
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        //Insert the Default Item to DataTable.
                        DataRow row = dt.NewRow();
                        row[0] = 0;
                        row[1] = "-- All --";
                        dt.Rows.InsertAt(row, 0);

                        //Assign DataTable as DataSource.
                        EmpCB.DataSource = dt;
                        EmpCB.DisplayMember = "UserName";
                        EmpCB.ValueMember = "Id";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }
        private void Memories_Load(object sender, EventArgs e)
        {
            GU();
        }
        public void GCH()
        {
            Db = new PortalContext();
            //DTHL : Date Today History List
            var G2 = from memo in Db.Memories
                     join users in Db.Users
                     on memo.UserId equals users.Id
                     where users.UserName == EmpCB.Text
                     select new
                     {
                         memo.MemoryName,
                         memo.Message,
                         users.UserName
                     };
            DGV.DataSource = G2.ToList();
        }
        private void EmpCB_TextChanged(object sender, EventArgs e)
        {
            var x = EmpCB.SelectedIndex;
            if (x == 0)
            {
                DGV.DataSource = null;
            }
            if (x != 0)
            {
                GCH();
            }
        }
    }
}
