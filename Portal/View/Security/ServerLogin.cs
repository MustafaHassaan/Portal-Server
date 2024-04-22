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
    public partial class ServerLogin : Form
    {
        int mov;
        int movx;
        int movy;
        PortalContext DbS;
        public static string UNPassing;
        public static string IDPassing;
        public ServerLogin()
        {
            InitializeComponent();
        }

        private void BSL_Click(object sender, EventArgs e)
        {
            DbS = new PortalContext();
            if (string.IsNullOrEmpty(TUserName.Text) || string.IsNullOrEmpty(TPassword.Text))
            {
                MessageBox.Show("Please Insert UserName & Phone ...", "Error");
                return;
            }
            else if (!string.IsNullOrEmpty(TUserName.Text) && !string.IsNullOrEmpty(TPassword.Text))
            {
                try
                {
                    foreach (var user in DbS.Users)
                    {
                        if (user.UserName == TUserName.Text && user.Password == TPassword.Text && user.PositionId == 1)
                        {
                            MessageBox.Show("Login Is Successfullu ...", "Success");
                            Historyes FH = new Historyes();
                            FH.Show();
                            TUserName.Clear();
                            TPassword.Clear();
                            this.Hide();
                            return;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Server Is Dowen ...", "Warning");
                    return;
                }
            }
            if(!string.IsNullOrEmpty(TUserName.Text) && !string.IsNullOrEmpty(TPassword.Text))
            {
                MessageBox.Show("Login Is Faild You Not Have Apermotions To Open This Window ...", "Faild");
                return;
            }
        }
        private void ServerLogin_Load(object sender, EventArgs e)
        {

        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (TPassword.UseSystemPasswordChar == true)
            {
                TPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TPassword.UseSystemPasswordChar = true;
            }
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
        private void TUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DbS = new PortalContext();
                if (string.IsNullOrEmpty(TUserName.Text) || string.IsNullOrEmpty(TPassword.Text))
                {
                    MessageBox.Show("Please Insert UserName & Phone ...", "Error");
                    return;
                }
                else if (!string.IsNullOrEmpty(TUserName.Text) && !string.IsNullOrEmpty(TPassword.Text))
                {
                    try
                    {
                        foreach (var user in DbS.Users)
                        {
                            if (user.UserName == TUserName.Text && user.Password == TPassword.Text && user.PositionId == 1)
                            {
                                MessageBox.Show("Login Is Successfullu ...", "Success");
                                Historyes FH = new Historyes();
                                FH.Show();
                                TUserName.Clear();
                                TPassword.Clear();
                                this.Hide();
                                return;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Server Is Dowen ...", "Warning");
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(TUserName.Text) && !string.IsNullOrEmpty(TPassword.Text))
                {
                    MessageBox.Show("Login Is Faild You Not Have Apermotions To Open This Window ...", "Faild");
                    return;
                }
            }
        }
        private void TPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DbS = new PortalContext();
                if (string.IsNullOrEmpty(TUserName.Text) || string.IsNullOrEmpty(TPassword.Text))
                {
                    MessageBox.Show("Please Insert UserName & Phone ...", "Error");
                    return;
                }
                else if (!string.IsNullOrEmpty(TUserName.Text) && !string.IsNullOrEmpty(TPassword.Text))
                {
                    try
                    {
                        foreach (var user in DbS.Users)
                        {
                            if (user.UserName == TUserName.Text && user.Password == TPassword.Text && user.PositionId == 1)
                            {
                                MessageBox.Show("Login Is Successfullu ...", "Success");
                                Historyes FH = new Historyes();
                                FH.Show();
                                TUserName.Clear();
                                TPassword.Clear();
                                this.Hide();
                                return;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Server Is Dowen ...", "Warning");
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(TUserName.Text) && !string.IsNullOrEmpty(TPassword.Text))
                {
                    MessageBox.Show("Login Is Faild You Not Have Apermotions To Open This Window ...", "Faild");
                    return;
                }
            }
        }
    }
}
