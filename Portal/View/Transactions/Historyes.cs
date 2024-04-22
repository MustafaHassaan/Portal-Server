using Controler;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.PduConverter.SmartMessaging;
using Portal.View.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace Portal.View.Transactions
{
    public partial class Historyes : Form
    {
        private Timer tmr;
        bool start = false;
        private GsmCommMain GsmCom;
        PortalContext Db;
        public Historyes()
        {
            InitializeComponent();

            if (start == false)
            {
                tmr = new Timer();
                tmr.Tick += delegate
                {
                    BtnLoop.PerformClick();
                };
                tmr.Interval = (int)TimeSpan.FromSeconds(90).TotalMilliseconds;
                tmr.Start();
            }
        }
        /* For Search 
         * Get All history For Today & 
         * Get All history For Date Choose & 
         * client choossing in today & 
         * clint choossing in date choose &
         * phone in today & 
         * phone in date choose & 
         * phone , clien in today & 
         * phone, client in choose date*/


        //GAHT : Get All History List For Today
        public void GAHT()
        {
            Db = new PortalContext();
            try
            {
                //DTHL : Date Today History List
                var HT = from History in Db.Histories
                             //where History.Date == Convert.ToDateTime(D1)
                         where History.Date == DateTime.Today
                         join users in Db.Users
                           on History.UserId equals users.Id
                         select new
                         {
                             History.SMSPhone,
                             History.SMSBody,
                             History.Languge,
                             History.Status,
                             History.Result,
                             History.Date,
                             History.Time,
                             users.UserName,
                             users.PhoneNumber
                         };
                DGV.DataSource = HT.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }

        //GAHD : Get All History List For Day Choose
        public void GAHD()
        {
            var T = DateTime.Now.ToShortTimeString();
            Db = new PortalContext();
            try
            {
                //DTHL : Date Today History List
                var HT = from History in Db.Histories
                             //where History.Date == Convert.ToDateTime(D1)
                         where History.Date >= DTF.Value && History.Date <= DTT.Value
                         join users in Db.Users
                           on History.UserId equals users.Id
                         select new
                         {
                             History.SMSPhone,
                             History.SMSBody,
                             History.Languge,
                             History.Status,
                             History.Result,
                             History.Date,
                             users.UserName,
                             users.PhoneNumber
                         };
                DGV.DataSource = HT.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...", "Error");
            }
            
        }

        //Get Client History List For Today
        public void GCHT()
        {
            Db = new PortalContext();
            //DTHL : Date Today History List
            try
            {
                var G2 = from History in Db.Histories
                         join users in Db.Users
                         on History.UserId equals users.Id
                         where users.UserName == EmpCB.Text
                         select new
                         {
                             History.SMSPhone,
                             History.SMSBody,
                             History.Languge,
                             History.Status,
                             History.Result,
                             History.Date,
                             users.UserName,
                             users.PhoneNumber
                         };
                DGV.DataSource = G2.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }

        }

        //Get Client History List For Day choosing
        public void GCHD()
        {
            Db = new PortalContext();
            //DTHL : Date Today History List
            try
            {
                var G3 = from History in Db.Histories
                         where History.Date >= DTF.Value &&
                               History.Date <= DTT.Value
                         join users in Db.Users
                         on History.UserId equals users.Id
                         where users.UserName == EmpCB.Text
                         select new
                         {
                             History.SMSPhone,
                             History.SMSBody,
                             History.Languge,
                             History.Status,
                             History.Result,
                             History.Date,
                             users.UserName,
                             users.PhoneNumber
                         };
                DGV.DataSource = G3.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }

        //Get Phone History List For Today
        public void GPHT()
        {
            Db = new PortalContext();
            try
            {
                //DTHL : Date Today History List
                var G4 = from History in Db.Histories
                         where History.SMSPhone.Contains(TSerching.Text)
                         join users in Db.Users
                         on History.UserId equals users.Id
                         select new
                         {
                             History.SMSPhone,
                             History.SMSBody,
                             History.Languge,
                             History.Status,
                             History.Result,
                             History.Date,
                             users.UserName,
                             users.PhoneNumber
                         };
                DGV.DataSource = G4.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }

        }

        //Get Phone History List For Day choosing
        public void GPHD()
        {

            Db = new PortalContext();
            try
            {
                //DTHL : Date Today History List
                var G5 = from History in Db.Histories
                         where History.SMSPhone.Contains(TSerching.Text) &&
                               History.Date >= DTF.Value &&
                               History.Date <= DTT.Value
                         join users in Db.Users
                         on History.UserId equals users.Id
                         select new
                         {
                             History.SMSPhone,
                             History.SMSBody,
                             History.Languge,
                             History.Status,
                             History.Result,
                             History.Date,
                             users.UserName,
                             users.PhoneNumber
                         };
                DGV.DataSource = G5.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }

        //Get Phone & Client History List For Today
        public void GPCHT()
        {
            Db = new PortalContext();
            //DTHL : Date Today History List
            try
            {
                var G6 = from History in Db.Histories
                         where History.SMSPhone.Contains(TSerching.Text)
                         join users in Db.Users
                         on History.UserId equals users.Id
                         where users.UserName == EmpCB.Text
                         select new
                         {
                             History.SMSPhone,
                             History.SMSBody,
                             History.Languge,
                             History.Status,
                             History.Result,
                             History.Date,
                             users.UserName,
                             users.PhoneNumber
                         };
                DGV.DataSource = G6.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }

        //Get Phone & Client History List For Day choosing
        public void GPCHD()
        {
            Db = new PortalContext();
            //DTHL : Date Today History List
            try
            {
                var G7 = from History in Db.Histories
                         where History.SMSPhone.Contains(TSerching.Text) &&
                               History.Date >= DTF.Value &&
                               History.Date <= DTT.Value
                         join users in Db.Users
                         on History.UserId equals users.Id
                         where users.UserName == EmpCB.Text
                         select new
                         {
                             History.SMSPhone,
                             History.SMSBody,
                             History.Languge,
                             History.Status,
                             History.Result,
                             History.Date,
                             users.UserName,
                             users.PhoneNumber
                         };
                DGV.DataSource = G7.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Hide();
                NI.Visible = true;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
                MessageBox.Show("Ths Server Is Dowen ...","Error");
            }
        }
        private void Actions_Load(object sender, EventArgs e)
        {
            DTF.Value = DateTime.Today;
            DTT.Value = DateTime.Today;
            try
            {
                GAHT();
                GU();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...","Error");
            }
        }
        public async void GD()
        {
            start = true;
            Db = new PortalContext();
            var Qua = from SMS in Db.TransActions
                      join user in Db.Users
                      on SMS.UserId equals user.Id
                      select new
                      {
                          SMS.Id,
                          SMS.SMSPhone,
                          SMS.SMSBody,
                          SMS.Languge,
                          SMS.Status,
                          SMS.Result,
                          SMS.UserId,
                          user.UserName
                      };
            int i = 0;
            try
            {
                foreach (var item in Qua)
                {
                    //======================Text Of Connect To Gsm Modem=====================//
                    try
                    {
                        ComboBox box = new ComboBox();
                        ManagementObjectSearcher ms = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem");
                        foreach (ManagementObject Obj in ms.Get())
                        {
                            box.Items.Add(Obj["AttachedTo"].ToString());
                        }
                        ConText.Text = box.Items[0].ToString();
                        //===========================================//



                        //===========================================//
                        //اعمل كائن جديد من(GSMCom) للبورت 
                        //وهتاخد كام حرف فى الثانيه الواحده
                        //والكلام ده هيحصل فى وقت قد ايه
                        GsmCom = new GsmCommMain(ConText.Text, 9600, 150);
                        GsmCom.Open();
                        Cursor.Current = Cursors.WaitCursor;
                        System.Threading.Thread.Sleep(5000);
                        Cursor.Current = Cursors.Default;
                        //===========================================//
                    }
                    catch (Exception)
                    {
                        var ME = MessageBox.Show("Please Connect Your UsbModem", "Error");
                        if (ME == DialogResult.OK)
                        {
                            return;
                        }
                    }
                    //=======================================================================//


                    //=======================================================================//
                    string SMS = item.SMSBody;
                    string Phone = item.SMSPhone;
                    var D = DateTime.Now.ToShortDateString();
                    var T = DateTime.Now.ToLongTimeString();
                    //لو انجليزى ابعت على 170 حرف
                    if (item.Languge == "Language Is : English (United States)")
                    {
                        //هنحط الرسالة هنا
                        //ببعت اول حاجه عن طريق sms Pdu 
                        OutgoingSmsPdu[] pdus = null;
                        try
                        {
                            pdus = SmartMessageFactory.CreateConcatTextMessage(SMS, Phone);
                            GsmCom.SendMessages(pdus);
                        }
                        catch (Exception ex)
                        {
                            //======================
                            //function Save in History
                            Db = new PortalContext();
                            var histc = new Model.History();
                            histc.SMSPhone = item.SMSPhone;
                            histc.SMSBody = item.SMSBody;
                            histc.Languge = item.Languge;
                            histc.Status = "Faild";
                            string Exception = ex.ToString();
                            histc.Result = Exception;
                            histc.Date = Convert.ToDateTime(D);
                            histc.Time = T;
                            histc.UserId = item.UserId;
                            Db.Histories.Add(histc);
                            await Db.SaveChangesAsync();

                            Db = new PortalContext();
                            var transactionsc = await Db.TransActions.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
                            Db.TransActions.Remove(transactionsc);
                            await Db.SaveChangesAsync();
                            DGV.Refresh();
                            i++;
                        }
                    }

                    //لو عربى ابعت على 70 حرف
                    if (item.Languge == "Language Is : Arabic (Egypt)")
                    {
                        //هنحط الرسالة هنا
                        //ببعت اول حاجه عن طريق sms Pdu 
                        SmsSubmitPdu Pdu;
                        try
                        {
                            // فبتبعت اول حاجه نص الرساله مع التحويل من المودم للغة
                            byte Dsc = (byte)DataCodingScheme.GeneralCoding.Alpha16Bit;

                            ////وبتبدأ تعمل الكائن بتاعك
                            //// اللى بيحتوى على
                            ////SMS, Phone, واللغة اللى هتبعتهاDSC
                            Pdu = new SmsSubmitPdu(SMS, Phone, Dsc);
                            GsmCom.SendMessage(Pdu);
                        }
                        catch (Exception ex)
                        {
                            //======================
                            //function Save in History
                            Db = new PortalContext();
                            var hista = new Model.History();
                            hista.SMSPhone = item.SMSPhone;
                            hista.SMSBody = item.SMSBody;
                            hista.Languge = item.Languge;
                            hista.Status = "Faild";
                            string Exception = ex.ToString();
                            hista.Result = Exception;
                            D = DateTime.Now.ToShortDateString();
                            T = DateTime.Now.ToLongTimeString();
                            hista.Date = Convert.ToDateTime(D);
                            hista.UserId = item.UserId;
                            Db.Histories.Add(hista);
                            await Db.SaveChangesAsync();

                            Db = new PortalContext();
                            var transactionsa = await Db.TransActions.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
                            Db.TransActions.Remove(transactionsa);
                            await Db.SaveChangesAsync();
                            DGV.Refresh();
                            i++;
                        }
                    }
                    //=======================================================================//
                    GsmCom.Close();

                    //======================
                    //function Save in History
                    Db = new PortalContext();
                    var hist = new Model.History();
                    hist.SMSPhone = item.SMSPhone;
                    hist.SMSBody = item.SMSBody;
                    hist.Languge = item.Languge;
                    hist.Status = "Done";
                    hist.Result = "Done";
                    D = DateTime.Now.ToShortDateString();
                    T = DateTime.Now.ToLongTimeString();
                    hist.Date = Convert.ToDateTime(D);
                    hist.Time = T;
                    hist.UserId = item.UserId;
                    Db.Histories.Add(hist);
                    await Db.SaveChangesAsync();

                    Db = new PortalContext();
                    var transactions = await Db.TransActions.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
                    Db.TransActions.Remove(transactions);
                    await Db.SaveChangesAsync();
                    DGV.Refresh();
                    //======================
                    i++;
                    //=======================================================================//
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Server Is Dowen ...", "Error");
            }
            GAHT();
            start = false;
        }
        private async void BtnLoop_Click(object sender, EventArgs e)
        {
            GD();
        }
        private void NewUser_Click(object sender, EventArgs e)
        {
            var SF = Application.OpenForms["Sign"];
            if ((SF as Security.Sign) != null)
            {
                SF.BringToFront();
                //Form is already open
            }
            else
            {
                Security.Sign SCF = new Security.Sign();
                SCF.Show();
                // Form is not open
            }
        }
        private void Users_Click(object sender, EventArgs e)
        {
            var UF = Application.OpenForms["Users"];
            if ((UF as Security.Users) != null)
            {
                if (UF.WindowState == FormWindowState.Minimized)
                {
                    UF.WindowState = FormWindowState.Normal;
                }
                else
                {
                    UF.BringToFront();
                    //Form is already open
                }
            }
            else
            {
                Security.Users UCF = new Security.Users();
                UCF.Show();
                // Form is not open
            }
        }
        private void Transactions_Click(object sender, EventArgs e)
        {
            var TF = Application.OpenForms["Tansactions"];
            if ((TF as Security.Transactions) != null)
            {
                if (TF.WindowState == FormWindowState.Minimized)
                {
                    TF.WindowState = FormWindowState.Normal;
                }
                else
                {
                    TF.BringToFront();
                    //Form is already open
                }
            }
            else
            {
                Security.Transactions TAF = new Security.Transactions();
                TAF.Show();
                // Form is not open
            }
        }
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void EmpCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void EmpCB_TextChanged(object sender, EventArgs e)
        {
        }
        private void EmpCB_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        private void EmpCB_TextUpdate(object sender, EventArgs e)
        {
        }
        private void EmpCB_MouseEnter(object sender, EventArgs e)
        {
        }
        private void EmpCB_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void TSerching_KeyPress(object sender, KeyPressEventArgs e)
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
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var x = EmpCB.SelectedIndex;
            if (x == 0 && TSerching.Text == "" && DTF.Value == DateTime.Today && DTT.Value == DateTime.Today)
            {
                GAHT();
            }
            if (x == 0 && TSerching.Text == "" && DTF.Value <= DateTime.Today && DTT.Value <= DateTime.Today)
            {
                GAHD();
            }
            if (x != 0 && TSerching.Text == "" && DTF.Value == DateTime.Today && DTT.Value == DateTime.Today)
            {
                GCHT();
            }
            if (x != 0 && TSerching.Text == "" && DTF.Value <= DateTime.Today && DTT.Value <= DateTime.Today)
            {
                GCHD();
            }
            if (x == 0 && TSerching.Text != "" && DTF.Value == DateTime.Today && DTT.Value == DateTime.Today)
            {
                GPHT();
            }
            if (x == 0 && TSerching.Text != "" && DTF.Value <= DateTime.Today && DTT.Value <= DateTime.Today)
            {
                GPHD();
            }
            if (x != 0 && TSerching.Text != "" && DTF.Value == DateTime.Today && DTT.Value == DateTime.Today)
            {
                GPCHT();
            }
            if (x != 0 && TSerching.Text != "" && DTF.Value <= DateTime.Today && DTT.Value <= DateTime.Today)
            {
                GPCHD();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void DTF_KeyDown_1(object sender, KeyEventArgs e)
        {
        }
        private void DTT_KeyDown_1(object sender, KeyEventArgs e)
        {
        }
        private void DTF_ValueChanged(object sender, EventArgs e)
        {
        }
        private void DTT_ValueChanged(object sender, EventArgs e)
        {
        }
        private void TSerching_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void Reload_Click(object sender, EventArgs e)
        {
            GU();
        }
        private void EmpCB_Click(object sender, EventArgs e)
        {
            GU();
        }
        private void Export_Click(object sender, EventArgs e)
        {

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported From Server";
            // storing header part in Excel  
            for (int i = 1; i < DGV.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DGV.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < DGV.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DGV.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DGV.Rows[i].Cells[j].Value.ToString();
                }
            }
            var ComputerName = Environment.MachineName;
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.InitialDirectory = @"C:\" + ComputerName;
            SFD.RestoreDirectory = true;
            SFD.FileName = ".xlsx";
            SFD.DefaultExt = "xlsx";
            SFD.Filter = "Excel Files (*.xlsx)|*.xlsx";
            string FP = "";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                FP = SFD.FileName;
            }
            var x = FP;
            // save the application  
            workbook.SaveAs(x, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue
            workbook.Close(true, Type.Missing, Type.Missing);

            // Exit from the application  
            app.Quit();
        }
        private void NI_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        private void NI_Click(object sender, EventArgs e)
        {
        }
        private void NI_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                this.WindowState = FormWindowState.Maximized;
                NI.Visible = false;
            }
            else
            {
                CMS.Show();
            }
        }
        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("Server"))
            {
                process.Kill();
            }
            Close();
        }
        private void maxmizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Maximized;
            NI.Visible = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var SCF = Application.OpenForms["ServerCustomers"];
            if ((SCF as ServerCustomers) != null)
            {
                if (SCF.WindowState == FormWindowState.Minimized)
                {
                    SCF.WindowState = FormWindowState.Normal;
                }
                else
                {
                    SCF.BringToFront();
                    //Form is already open
                }
            }
            else
            {
                ServerCustomers SFF = new ServerCustomers();
                SFF.Show();
                // Form is not open
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var MF = Application.OpenForms["Memories"];
            if ((MF as Memories) != null)
            {
                if (MF.WindowState == FormWindowState.Minimized)
                {
                    MF.WindowState = FormWindowState.Normal;
                }
                else
                {
                    MF.BringToFront();
                    //Form is already open
                }
            }
            else
            {
                Memories MFF = new Memories();
                MFF.Show();
                // Form is not open
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 95)
            {
                panel2.Width = 375;
            }
            else
            {
                panel2.Width = 95;
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var PF = Application.OpenForms["Positions"];
            if ((PF as Positions) != null)
            {
                if (PF.WindowState == FormWindowState.Minimized)
                {
                    PF.WindowState = FormWindowState.Normal;
                }
                else
                {
                    PF.BringToFront();
                    //Form is already open
                }
            }
            else
            {
                Positions PFF = new Positions();
                PFF.Show();
                // Form is not open
            }
        }
    }
}
