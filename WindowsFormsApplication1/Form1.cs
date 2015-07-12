using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Int32 ID;
        public static int t3_flag = -1;
        

        public Form1()
        {
            InitializeComponent();
        }
        
        //
        // upload image
        //

//Tab control
//
        private void button_upload_slika_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_t1_photo.Image = new Bitmap(open.FileName);

                if (button1.Enabled == false)
                    button1.Enabled = true;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
      //generating activation code

            long activationCode = FunctionClass.ActivationCodeGenerator();
            while (!FunctionClass.ValidateActivationCode(activationCode.ToString()))
            {
                activationCode = FunctionClass.ActivationCodeGenerator();
            }
            tb_t1_activationCode.Text = activationCode.ToString();

            ep_t1_activationCode.SetError(tb_t1_activationCode, "Okay.");
            ep_t1_activationCode.Icon = Properties.Resources.ok;
           
            if (ep_t1_name.GetError(tb_t1_name) == "Validated" &&
                ep_t1_surname.GetError(tb_t1_surname) == "Validated" &&
                ep_t1_mail.GetError(tb_t1_mail) == "Validated" &&
                ep_t1_phone.GetError(tb_t1_phone) == "Validated" &&
                ep_t1_birthdate.GetError(dateTimePicker1) == "Okay." &&
                ep_t1_datefrom.GetError(dtp_t1_dateFrom) == "Okay." &&
                !FunctionClass.SameAs(pb_t1_photo.Image, pb_t1_photo.InitialImage)
                )
            {

                MemoryStream ms = new MemoryStream();
                pb_t1_photo.Image.Save(ms, ImageFormat.Jpeg);

                FunctionClass.Insert_User(tb_t1_name.Text, tb_t1_surname.Text, tb_t1_mail.Text, ms.ToArray(), tb_t1_phone.Text, dateTimePicker1.Value, dtp_t1_dateFrom.Value);

                DataSet ds = FunctionClass.Select_User_By_ID(tb_t1_name.Text, tb_t1_surname.Text, tb_t1_mail.Text, tb_t1_phone.Text, dateTimePicker1.Value);
                //Int32 
                ID = Int32.Parse(((DataRow)ds.Tables["Data"].Rows[0])["id"].ToString());

                FunctionClass.Insert_GoldCard(dtp_t1_dateFrom.Value, dtp_t1_dateFrom.Value.AddMonths(1), activationCode.ToString(), ID);


                tb_t1_name.Enabled = false;
                tb_t1_surname.Enabled = false;
                tb_t1_mail.Enabled = false;
                //pictureBox3.Image = null;
                pb_t1_photo.Enabled = false;
                button_upload_slika.Enabled = false;
                tb_t1_phone.Enabled = false;
                tb_t1_activationCode.Enabled = false;
               // dateTimePicker1.Value = DateTime.Today;
                dateTimePicker1.Enabled = false;
               // dtp_t1_dateFrom.Value = DateTime.Today;
                dtp_t1_dateFrom.Enabled = false;
                btn_printForm.Enabled = true;
                MessageBox.Show("Успешно внесен корисник!! Честитки.");
                if (button1.Enabled == true)
                button1.Enabled = false;

                ep_t1_activationCode.Clear();
                ep_t1_birthdate.Clear();
                ep_t1_datefrom.Clear();
                ep_t1_mail.Clear();
                ep_t1_name.Clear();
                ep_t1_phone.Clear();
                ep_t1_photo.Clear();
                ep_t1_surname.Clear();
                
            }
            else MessageBox.Show("Проблем.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_dp_gold_membershipDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this._dp_gold_membershipDataSet1.Users);
            //dtp_t3_birthdate.MaxDate = DateTime.Today.AddDays(1);
            //dtp_t3_birthdate.Value = DateTime.Today;
           // this.ep_t1_birthdate.Icon = Properties.Resources.err;
           // this.ep_t1_birthdate.SetError(dateTimePicker1, "error value changed");

            //autocomplete
            DataSet d = FunctionClass.Select_Users_By_SearchString(tb_t4_search.Text);
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            foreach(DataRow dr in d.Tables["Data"].Rows)
            {
                MyCollection.Add(dr["name"] + " " + dr["surname"] + ", " + dr["id"]);
                MyCollection.Add(dr["surname"] + " " + dr["name"] + ", " + dr["id"]);
                MyCollection.Add(dr["id"] + ", " + dr["name"] + " " + dr["surname"]);
                //CollectionId = Int32.Parse(dr["id"].ToString());
                //lbl_t4_name.Text = CollectionId.ToString();
            }
            tb_t4_search.AutoCompleteCustomSource = MyCollection;
        }

        private void btn_printForm_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            Print pr = new Print();
            //f1.Hide();
            this.Hide();
            pr.setUserCode = ID.ToString();
            pr.setName = tb_t1_name.Text;
            pr.setSurname = tb_t1_surname.Text;
            pr.setMail = tb_t1_mail.Text;
            pr.setPhone = tb_t1_phone.Text;
            pr.setBirthdate = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            pr.setActivationCode = tb_t1_activationCode.Text;
            pr.setDateFrom = dtp_t1_dateFrom.Value.ToString("dd.MM.yyyy");
            pr.setDateTo = (dtp_t1_dateFrom.Value.AddMonths(1)).ToString("dd.MM.yyyy");
            pr.Show();
            //this.Close();

            
            //f1.Close();
            
            //empty ID
            ID = -1;
            tb_t1_name.Text = "";
            tb_t1_surname.Text = "";
            tb_t1_mail.Text = "";
            pb_t1_photo.Image = Properties.Resources.slika;
            tb_t1_phone.Text = "";
            tb_t1_activationCode.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dtp_t1_dateFrom.Value = DateTime.Today;
        }
   
        private void tb_t2_userCode_TextChanged(object sender, EventArgs e)
        {
            if (tb_t2_userCode.Text == "") 
            {
                lbl_t2_name.Text = "// име:";
                lbl_t2_surname.Text = "// презиме:";
                lbl_t2_dateFrom.Text = "// дата од:";
                lbl_t2_dateTo.Text = "// дата до:";
                lbl_t2_birthdate.Text = "// дата на раѓање";
                lbl_t2_age.Text = "// возраст";
                pb_t2_photo.Image = Properties.Resources.slika;
                tb_t2_time.Text = "";
                lbl_t2_visit.Text = "// број";
            
            }
            else 
            { 
                DataSet ds = FunctionClass.Select_GoldCard_By_UserID(Int32.Parse(tb_t2_userCode.Text));
                if (ds.Tables["Data"].Rows.Count > 0)
                {
                    lbl_t2_name.Text = ((DataRow)ds.Tables["Data"].Rows[0])["name"].ToString();
                    lbl_t2_surname.Text = ((DataRow)ds.Tables["Data"].Rows[0])["surname"].ToString();
                    lbl_t2_birthdate.Text = ((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateOfBirth"]).ToString("dd.MM.yyyy");
                    lbl_t2_dateFrom.Text = ((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateFrom"]).ToString("dd.MM.yyyy");
                    lbl_t2_dateTo.Text = ((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateTo"]).ToString("dd.MM.yyyy");
                    var data = (Byte[])(((DataRow)ds.Tables["Data"].Rows[0])["photo"]);
                    var ms = new MemoryStream(data);
                    pb_t2_photo.Image = Image.FromStream(ms);
                    tb_t2_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    lbl_t2_days.Text = FunctionClass.CalculateDaysLeft(((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateFrom"]),
                              ((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateTo"])).ToString();
                    lbl_t2_age.Text = FunctionClass.CalculateAge((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateOfBirth"]).ToString() + " години";
                    DataSet ds2 = FunctionClass.Count_Activities_By_UserID(Int32.Parse(tb_t2_userCode.Text));
                    lbl_t2_visit.Text = ((DataRow)ds2.Tables["Data"].Rows[0])["number"].ToString();                        
                }
                //else
                //    MessageBox.Show("Не постои корисник со внесениот код.");
                
            }
        }

        private void btn_t2_submit_Click(object sender, EventArgs e)
        {
            FunctionClass.Insert_Activity(DateTime.ParseExact(tb_t2_time.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), tb_t2_serviceID.Text, Int32.Parse(tb_t2_userCode.Text));
            MessageBox.Show("Успешен внес.");
            tb_t2_serviceID.Text = "";
            tb_t2_userCode.Text = "";
            btn_t2_submit.Enabled = false;

        }

        private void dgv_users_SelectionChanged(object sender, EventArgs e)
        {
            if( dgv_users.SelectedRows.Count > 0)
            {
                //tb_t3_name.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
                //tb_t3_surname.Text = dgv_users.SelectedRows[0].Cells[2].Value.ToString();
                //tb_t3_mail.Text = dgv_users.SelectedRows[0].Cells[3].Value.ToString();
                var data = (Byte[])(dgv_users.SelectedRows[0].Cells[4].Value);
                var ms = new MemoryStream(data);
                //pb_t3_photo.Image = Image.FromStream(ms);
                //tb_t3_phone.Text = dgv_users.SelectedRows[0].Cells[5].Value.ToString();
                //dtp_t3_birthdate.MaxDate = Convert.ToDateTime(dgv_users.SelectedRows[0].Cells[6].Value.ToString()).AddDays(1);
                //dtp_t3_birthdate.Value = Convert.ToDateTime(dgv_users.SelectedRows[0].Cells[6].Value.ToString());
                
                DataSet ds = FunctionClass.Select_GoldCard_By_UserID(Int32.Parse(dgv_users.SelectedRows[0].Cells[0].Value.ToString()));
                //if (ds.Tables["Data"].Rows.Count > 0)
                //{
                //    lbl_t3_dateFrom.Text = ((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateFrom"]).ToString("dd.MM.yyyy");
                //    lbl_t3_dateTo.Text = ((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateTo"]).ToString("dd.MM.yyyy");
                   
                //}

                fill_Personal_Info(dgv_users.SelectedRows[0].Cells[1].Value.ToString(),
                    dgv_users.SelectedRows[0].Cells[2].Value.ToString(),
                    dgv_users.SelectedRows[0].Cells[3].Value.ToString(),
                    ms,
                    dgv_users.SelectedRows[0].Cells[5].Value.ToString(),
                    dgv_users.SelectedRows[0].Cells[6].Value.ToString());
                    
                fill_Card_Info( (DateTime) ( (DataRow)ds.Tables["Data"].Rows[0])["dateFrom"]);
         
            }


        }

        private void fill_Personal_Info(String name, String surname, String mail, MemoryStream photo, String phone, String birthdate)
        {
            tb_t3_name.Text = name;
            tb_t3_surname.Text = surname;
            tb_t3_mail.Text = mail;
            pb_t3_photo.Image = Image.FromStream(photo);
            tb_t3_phone.Text = phone;
            dtp_t3_birthdate.MaxDate = Convert.ToDateTime(birthdate).AddDays(1);
            dtp_t3_birthdate.Value = Convert.ToDateTime(birthdate);
            
        }
        private void fill_Card_Info(DateTime dateFrom)
        {
            lbl_t3_dateFrom.Text = dateFrom.ToString("yyyy - MM - dd");
            lbl_t3_dateTo.Text = dateFrom.AddMonths(1).ToString("yyyy - MM - dd");
           // dtp_t3_dateFrom.MinDate = Convert.ToDateTime(dateFrom).AddDays(-1); !!!!!!!!!!!!!!!!!!!!
            //dtp_t3_dateFrom.MaxDate = dateFrom.AddDays(1);
            dtp_t3_dateFrom.MinDate = Convert.ToDateTime("01/01/1758");
            dtp_t3_dateFrom.MaxDate = Convert.ToDateTime("01/01/2099");
            //dtp_t3_dateFrom.Value = dateFrom;
            dtp_t3_dateFrom.Value = DateTime.Today;
        }

        private void btn_t3_edit_Click(object sender, EventArgs e)
        {
            if (t3_flag == 2)
            {
                DateTime date = DateTime.ParseExact(lbl_t3_dateFrom.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                fill_Card_Info(date); 
            }
            t3_flag = 1;
            dtp_t3_birthdate.Enabled = true;
            btn_t3_upload.Enabled = true;
            btn_t3_submit.Enabled = true;

            dtp_t3_dateFrom.Visible = false;
            dtp_t3_dateFrom.Enabled = false;

            tb_t3_name.Enabled = true;
            tb_t3_surname.Enabled = true;
            tb_t3_mail.Enabled = true;
            tb_t3_phone.Enabled = true;
            btn_t3_upload.Enabled = true;

            lbl_t3_activationCode.Visible = false;
            tb_t3_activationCode.Visible = false;
            btn_t3_print.Visible = false;
        }

        private void btn_t3_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_t3_photo.Image = new Bitmap(open.FileName);
            }
        }

        private void btn_t3_submit_Click(object sender, EventArgs e)
        {
            if(t3_flag == 1)
            { 
                MemoryStream ms = new MemoryStream();
                pb_t3_photo.Image.Save(ms, ImageFormat.Jpeg);
                FunctionClass.Update_User(Int32.Parse(dgv_users.SelectedRows[0].Cells[0].Value.ToString()),tb_t3_name.Text, tb_t3_surname.Text, tb_t3_mail.Text, ms.ToArray(), tb_t3_phone.Text, dtp_t3_birthdate.Value);

                this.usersTableAdapter1.Fill(this._dp_gold_membershipDataSet1.Users);
                // separate load dgv_users data function ? (instead of using dataSet)
                tb_t3_activationCode.Text = "";
                tb_t3_activationCode.Visible = false;
                lbl_t3_activationCode.Visible = false;

                dtp_t3_birthdate.Enabled = false;
                btn_t3_upload.Enabled = false;
                btn_t3_submit.Enabled = false;

                dtp_t3_dateFrom.Visible = false;
                dtp_t3_dateFrom.Enabled = false;

                tb_t3_name.Enabled = false;
                tb_t3_surname.Enabled = false;
                tb_t3_mail.Enabled = false;
                tb_t3_phone.Enabled = false;
                btn_t3_upload.Enabled = false;
                t3_flag = -1;
                lbl_t3_search.Focus();

                ep_t3_name.Clear();
                ep_t3_surname.Clear();
                ep_t3_mail.Clear();
                ep_t3_phone.Clear();
                ep_t3_birthdate.Clear();
                ep_t3_dateFrom.Clear();
            }
            else if(t3_flag == 2)
            { 
                Int32 userID = Int32.Parse(dgv_users.SelectedRows[0].Cells[0].Value.ToString());
                FunctionClass.Insert_GoldCard(dtp_t3_dateFrom.Value, dtp_t3_dateFrom.Value.AddMonths(1), tb_t3_activationCode.Text, userID);
                btn_t3_print.Enabled = true;
                dtp_t3_dateFrom.Enabled = false;
                lbl_t3_dateTo.Enabled = false;
            }
    
        }

        private void tb_t3_search_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = new DataView(_dp_gold_membershipDataSet1.Tables[0]);
            dv.RowFilter = "name LIKE '%" + tb_t3_search.Text + "%' or surname LIKE '%" + tb_t3_search.Text + "%' or Convert(id, 'System.String') LIKE '%"  + tb_t3_search.Text + "%'";
          // dv.RowFilter += " or surname LIKE '%" + tb_t3_search.Text + "%'";
           // dv.RowFilter += " or id LIKE '%" + tb_t3_search.Text + "%'";      
            dgv_users.DataSource  = dv;
        }

        private void btn_t3_renew_Click(object sender, EventArgs e)
        {
            if (t3_flag == 1)
            {
                var data = (Byte[])(dgv_users.SelectedRows[0].Cells[4].Value);
                var ms = new MemoryStream(data);
                fill_Personal_Info(dgv_users.SelectedRows[0].Cells[1].Value.ToString(),
                    dgv_users.SelectedRows[0].Cells[2].Value.ToString(),
                    dgv_users.SelectedRows[0].Cells[3].Value.ToString(),
                    ms,
                    dgv_users.SelectedRows[0].Cells[5].Value.ToString(),
                    dgv_users.SelectedRows[0].Cells[6].Value.ToString()); 
            }
            t3_flag = 2;

            //generating AC
            long activationCode = FunctionClass.ActivationCodeGenerator();
            while (!FunctionClass.ValidateActivationCode(activationCode.ToString()))
            {
                activationCode = FunctionClass.ActivationCodeGenerator();
            }
            tb_t3_activationCode.Text = activationCode.ToString();
            lbl_t3_dateTo.Text = dtp_t3_dateFrom.Value.AddMonths(1).ToString("yyyy - MM - dd");
            dtp_t3_dateFrom.Visible = true;
            dtp_t3_dateFrom.Enabled = true;
            dtp_t3_birthdate.Enabled = false;
            btn_t3_upload.Enabled = false;
            tb_t3_name.Enabled = false;
            tb_t3_surname.Enabled = false;
            tb_t3_mail.Enabled = false;
            tb_t3_phone.Enabled = false;
            btn_t3_submit.Enabled = true;
            tb_t3_activationCode.Visible = true;
            lbl_t3_activationCode.Visible = true;
            btn_t3_print.Visible = true;

        }

        private void dtp_t3_dateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_t3_dateFrom.Enabled == true)
            {
                if (btn_t3_submit.Enabled == true)
                    btn_t3_submit.Enabled = false;

                dtp_t3_dateFrom.MinDate = DateTime.Today;
                if (dtp_t3_dateFrom.Value.Date < DateTime.Today.Date)
                {
                    this.ep_t3_dateFrom.Icon = Properties.Resources.err;
                    this.ep_t3_dateFrom.SetError(dtp_t3_dateFrom, "Not a correct date.");
                }
                else
                {
                    this.ep_t3_dateFrom.Icon = Properties.Resources.ok;
                    this.ep_t3_dateFrom.SetError(dtp_t3_dateFrom, "Okay.");
                    if (btn_t3_submit.Enabled == false)
                        btn_t3_submit.Enabled = true;
                }
            }
            lbl_t3_dateTo.Text = dtp_t3_dateFrom.Value.AddMonths(1).ToString("yyyy - MM - dd");
            
        }

        private void tb_t1_mail_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            ep_t1_mail.SetError(tb_t1_mail, "Validated");
            if (button1.Enabled == false)
                button1.Enabled = true;
        }

        private void tb_t1_mail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (button1.Enabled == true)
                button1.Enabled = false;

            string errorMsg;
            if (!FunctionClass.ValidateEmailAddress(tb_t1_mail.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tb_t1_mail.Select(0, tb_t1_mail.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.ep_t1_mail.SetError(tb_t1_mail, errorMsg);
                this.ep_t1_mail.Icon = Properties.Resources.err;
            }
            else
            {
                e.Cancel = false;
                this.ep_t1_mail.SetError(tb_t1_mail, "Okay.");
                this.ep_t1_mail.Icon = Properties.Resources.ok;
            }

        }

        private void tb_t1_name_Validated(object sender, EventArgs e)
        {
            ep_t1_name.SetError(tb_t1_name, "Validated");
            if (button1.Enabled == false)
                button1.Enabled = true;
        }

        private void tb_t1_name_Validating(object sender, CancelEventArgs e)
        {
            if (button1.Enabled == true)
                button1.Enabled = false;

            string errorMsg;
            if (!FunctionClass.ValidateString(tb_t1_name.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tb_t1_name.Select(0, tb_t1_name.Text.Length);
                // Set the ErrorProvider error with the text to display.  
                this.ep_t1_name.SetError(tb_t1_name, errorMsg);
                this.ep_t1_name.Icon = Properties.Resources.err;
            }
            else
            {
                e.Cancel = false;
                this.ep_t1_name.SetError(tb_t1_name, "Okay.");
                this.ep_t1_name.Icon = Properties.Resources.ok;
            }
           
        }

        private void tb_t1_surname_Validated(object sender, EventArgs e)
        {
            ep_t1_surname.SetError(tb_t1_surname, "Validated");
            if (button1.Enabled == false)
                button1.Enabled = true;
        }

        private void tb_t1_surname_Validating(object sender, CancelEventArgs e)
        {
            if (button1.Enabled == true)
                button1.Enabled = false;

            string errorMsg;
            if (!FunctionClass.ValidateString(tb_t1_surname.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tb_t1_surname.Select(0, tb_t1_surname.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.ep_t1_surname.SetError(tb_t1_surname, errorMsg);
                this.ep_t1_surname.Icon = Properties.Resources.err;
            }
            else
            {
                e.Cancel = false;
                this.ep_t1_surname.SetError(tb_t1_surname, "Okay.");
                this.ep_t1_surname.Icon = Properties.Resources.ok;
            
            }
        }

        private void tb_t1_phone_Validated(object sender, EventArgs e)
        {
            ep_t1_phone.SetError(tb_t1_phone, "Validated");
            if(button1.Enabled == false)
                button1.Enabled = true;
        }

        private void tb_t1_phone_Validating(object sender, CancelEventArgs e)
        {
            if (button1.Enabled == true)
                button1.Enabled = false;

            string errorMsg;
            if (!FunctionClass.ValidateNumber(tb_t1_phone.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tb_t1_phone.Select(0, tb_t1_phone.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.ep_t1_phone.SetError(tb_t1_phone, errorMsg);
                this.ep_t1_phone.Icon = Properties.Resources.err;
            }
            else
            {
                e.Cancel = false;
                this.ep_t1_phone.SetError(tb_t1_phone, "Okay.");
                this.ep_t1_phone.Icon = Properties.Resources.ok;
            }
        }

        private void tb_t1_activationCode_Validating(object sender, CancelEventArgs e)
        {
            if (button1.Enabled == true)
                button1.Enabled = false;
            
            //string errorMsg;
            //if (!FunctionClass.ValidateNumber(tb_t1_activationCode.Text, out errorMsg))
            //{
            //    // Cancel the event and select the text to be corrected by the user.
            //    e.Cancel = true;
            //    tb_t1_activationCode.Select(0, tb_t1_activationCode.Text.Length);

            //    // Set the ErrorProvider error with the text to display.  
            //    this.ep_t1_activationCode.SetError(tb_t1_activationCode, errorMsg);
            //    this.ep_t1_activationCode.Icon = Properties.Resources.err;
            //}
            //else
            //{
            //    e.Cancel = false;
                this.ep_t1_activationCode.SetError(tb_t1_activationCode, "Okay.");
                this.ep_t1_activationCode.Icon = Properties.Resources.ok;
            //}
        }

        private void tb_t1_activationCode_Validated(object sender, EventArgs e)
        {
            //ep_t1_activationCode.SetError(tb_t1_activationCode, "Validated");
        }

        private void dtp_t1_dateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
                button1.Enabled = false;

            dtp_t1_dateFrom.MinDate = DateTime.Today;
            if (dtp_t1_dateFrom.Value.Date < DateTime.Today.Date)
            {
                this.ep_t1_datefrom.Icon = Properties.Resources.err;
                this.ep_t1_datefrom.SetError(dtp_t1_dateFrom, "Грешка!");
            }
            else
            {
                this.ep_t1_datefrom.Icon = Properties.Resources.ok;
                this.ep_t1_datefrom.SetError(dtp_t1_dateFrom, "Okay.");
                if (button1.Enabled == false)
                    button1.Enabled = true;
            }
        }

        private void pb_t1_photo_Validated(object sender, EventArgs e)
        {
            ep_t1_photo.SetError(pb_t1_photo, "Validated");
        }

        private void pb_t1_photo_Validating(object sender, CancelEventArgs e)
        {
            if (button1.Enabled == true)
                button1.Enabled = false;

            string errorMsg;
           
            if (!FunctionClass.ValidateImage(pb_t1_photo.Image, pb_t1_photo.InitialImage, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                //pb_t1_photo.Select(); //?
                button_upload_slika.Select();
                // Set the ErrorProvider error with the text to display.  
                this.ep_t1_photo.SetError(pb_t1_photo, errorMsg);
                this.ep_t1_photo.Icon = Properties.Resources.err;
                MessageBox.Show("error icon");
            }
            else
            {
                e.Cancel = false;
                this.ep_t1_photo.SetError(pb_t1_photo, "Okay.");
                this.ep_t1_photo.Icon = Properties.Resources.ok;
                MessageBox.Show("ok icon");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
                button1.Enabled = false;
   
            dateTimePicker1.MaxDate = DateTime.Today;
            //if (dateTimePicker1.Value.Date > DateTime.Today.Date)
            //    dateTimePicker1.Value = DateTime.Today;
           
            if (dateTimePicker1.Value.Date == DateTime.Today.Date)
            {
                this.ep_t1_birthdate.Icon = Properties.Resources.err;
                this.ep_t1_birthdate.SetError(dateTimePicker1, "Внесете дата помала од " + DateTime.Today.ToString("dd.MM.yyyy"));
            }
            else
            {
                this.ep_t1_birthdate.Icon = Properties.Resources.ok;
                this.ep_t1_birthdate.SetError(dateTimePicker1, "Okay.");
                if (button1.Enabled == false)
                    button1.Enabled = true;           
            }

        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            if (ep_t1_name.GetError(tb_t1_name) == "Validated" &&
              ep_t1_surname.GetError(tb_t1_surname) == "Validated" &&
              ep_t1_mail.GetError(tb_t1_mail) == "Validated" &&
              ep_t1_phone.GetError(tb_t1_phone) == "Validated" &&
              ep_t1_birthdate.GetError(dateTimePicker1) == "Okay." &&
              ep_t1_datefrom.GetError(dtp_t1_dateFrom) == "Okay." &&
              !FunctionClass.SameAs(pb_t1_photo.Image, pb_t1_photo.InitialImage)
              )
            //  ep_t1_photo.GetError(pb_t1_photo) == "Validated")//&&
            // ep_t1_activationCode.GetError(tb_t1_activationCode) == "Validated")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void btn_t1_refresh_Click(object sender, EventArgs e)
        {
            //this.Refresh();
            //Application.Restart();
            tb_t1_name.Text = "";
            tb_t1_surname.Text = "";
            tb_t1_mail.Text = "";
            tb_t1_phone.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dtp_t1_dateFrom.Value = DateTime.Today;
            pb_t1_photo.Image = pb_t1_photo.InitialImage;
            tb_t1_activationCode.Text = "";

            ep_t1_name.Clear();
            ep_t1_surname.Clear();
            ep_t1_mail.Clear();
            ep_t1_phone.Clear();
            ep_t1_birthdate.Clear();
            ep_t1_datefrom.Clear();
            ep_t1_activationCode.Clear();
            ep_t1_photo.Clear();


        }

        private void tb_t2_userCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void tb_t2_serviceID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void tb_t2_serviceID_TextChanged(object sender, EventArgs e)
        {
            if (tb_t2_serviceID.Text != "")
            {
                DataSet ds = FunctionClass.Select_Service_By_ID(Int32.Parse(tb_t2_serviceID.Text));
                if (ds.Tables["Data"].Rows.Count > 0)
                {
                    btn_t2_submit.Enabled = true;
                }
                else
                {
                    btn_t2_submit.Enabled = false;
                }
            }
            else
                btn_t2_submit.Enabled = false;
        }

        private void tb_t1_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void tb_t1_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.KeyChar) || e.KeyChar == 8);
        }

        private void tb_t1_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.KeyChar) || e.KeyChar == 8);
        }

        private void tb_t3_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || Char.IsLetter(e.KeyChar));

        }

        private void tb_t3_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.KeyChar) || e.KeyChar == 8);
        }

        private void tb_t3_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.KeyChar) || e.KeyChar == 8);
        }

        private void tb_t3_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void tb_t3_name_Validated(object sender, EventArgs e)
        {
            ep_t3_name.SetError(tb_t3_name, "Validated");
            if (btn_t3_submit.Enabled == false)
                btn_t3_submit.Enabled = true;
        }

        private void tb_t3_name_Validating(object sender, CancelEventArgs e)
        {

            if (btn_t3_submit.Enabled == true)
                btn_t3_submit.Enabled = false;

            string errorMsg;
            if (!FunctionClass.ValidateString(tb_t3_name.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tb_t3_name.Select(0, tb_t3_name.Text.Length);
                // Set the ErrorProvider error with the text to display.  
                this.ep_t3_name.SetError(tb_t3_name, errorMsg);
                this.ep_t3_name.Icon = Properties.Resources.err;
            }
            else
            {
                e.Cancel = false;
                this.ep_t3_name.SetError(tb_t3_name, "Okay.");
                this.ep_t3_name.Icon = Properties.Resources.ok;
            }
        }

        private void tb_t3_surname_Validated(object sender, EventArgs e)
        {
            ep_t3_surname.SetError(tb_t3_surname, "Validated");
            if (btn_t3_submit.Enabled == false)
                btn_t3_submit.Enabled = true;
        }

        private void tb_t3_surname_Validating(object sender, CancelEventArgs e)
        {

            if (btn_t3_submit.Enabled == true)
                btn_t3_submit.Enabled = false;

            string errorMsg;
            if (!FunctionClass.ValidateString(tb_t3_surname.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tb_t3_surname.Select(0, tb_t3_surname.Text.Length);
                // Set the ErrorProvider error with the text to display.  
                this.ep_t3_surname.SetError(tb_t3_surname, errorMsg);
                this.ep_t3_surname.Icon = Properties.Resources.err;
            }
            else
            {
                e.Cancel = false;
                this.ep_t3_surname.SetError(tb_t3_surname, "Okay.");
                this.ep_t3_surname.Icon = Properties.Resources.ok;
            }
        }

        private void tb_t3_phone_Validated(object sender, EventArgs e)
        {
            ep_t3_phone.SetError(tb_t3_phone, "Validated");
            if (btn_t3_submit.Enabled == false)
                btn_t3_submit.Enabled = true;
        }

        private void tb_t3_phone_Validating(object sender, CancelEventArgs e)
        {
            if (btn_t3_submit.Enabled == true)
                btn_t3_submit.Enabled = false;

            string errorMsg;
            if (!FunctionClass.ValidateNumber(tb_t3_phone.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tb_t3_phone.Select(0, tb_t3_phone.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.ep_t3_phone.SetError(tb_t3_phone, errorMsg);
                this.ep_t3_phone.Icon = Properties.Resources.err;
            }
            else
            {
                e.Cancel = false;
                this.ep_t3_phone.SetError(tb_t3_phone, "Okay.");
                this.ep_t3_phone.Icon = Properties.Resources.ok;
            }
        }

        private void tb_t3_mail_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            ep_t3_mail.SetError(tb_t3_mail, "Validated");
            if (btn_t3_submit.Enabled == false)
                btn_t3_submit.Enabled = true;
        }

        private void tb_t3_mail_Validating(object sender, CancelEventArgs e)
        {
            if (btn_t3_submit.Enabled == true)
                btn_t3_submit.Enabled = false;

            string errorMsg;
            if (!FunctionClass.ValidateEmailAddress(tb_t3_mail.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tb_t3_mail.Select(0, tb_t3_mail.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.ep_t3_mail.SetError(tb_t3_mail, errorMsg);
                this.ep_t3_mail.Icon = Properties.Resources.err;
            }
            else
            {
                e.Cancel = false;
                this.ep_t3_mail.SetError(tb_t3_mail, "Okay.");
                this.ep_t3_mail.Icon = Properties.Resources.ok;
            }
        }

        private void dtp_t3_birthdate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_t3_birthdate.Enabled == true)
            {
                if (btn_t3_submit.Enabled == true)
                    btn_t3_submit.Enabled = false;

                dtp_t3_birthdate.MaxDate = DateTime.Today;
                if (dtp_t3_birthdate.Value.Date >= DateTime.Today.Date)
                {
                    this.ep_t3_birthdate.Icon = Properties.Resources.err;
                    this.ep_t3_birthdate.SetError(dtp_t3_birthdate, "Not a correct date.");
                }
                else
                {
                    this.ep_t3_birthdate.Icon = Properties.Resources.ok;
                    this.ep_t3_birthdate.SetError(dtp_t3_birthdate, "Okay.");
                    if (btn_t3_submit.Enabled == false)
                        btn_t3_submit.Enabled = true;
                }
            }
        }

        private void dtp_t3_birthdate_EnabledChanged(object sender, EventArgs e)
        {
            dtp_t3_birthdate_ValueChanged(this, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            Application.Exit();
        }

        private void dtp_t3_dateFrom_EnabledChanged(object sender, EventArgs e)
        {
            dtp_t3_dateFrom_ValueChanged(this, e);
        }

        private void tb_t4_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || Char.IsLetter(e.KeyChar));
        }

        private void tb_t4_search_KeyUp(object sender, KeyEventArgs e)
        {
            int id;
            string str = tb_t4_search.Text;
            if(str != String.Empty)
            {
                string[] words = str.Split(' ', ',');
                foreach(string s in words)
                {
                    bool isNumeric = int.TryParse(s, out id);
                    if (isNumeric)
                    {
                        DataSet d1 = FunctionClass.Select_User_By_UserID(id);
                        if (d1.Tables["Data"].Rows.Count > 0)
                        {
                            lbl_t4_userCode.Text = id.ToString();
                            lbl_t4_name.Text = ((DataRow)d1.Tables["Data"].Rows[0])["name"].ToString();
                            lbl_t4_surname.Text = ((DataRow)d1.Tables["Data"].Rows[0])["surname"].ToString();
                            lbl_t4_birthdate.Text = ((DateTime)((DataRow)d1.Tables["Data"].Rows[0])["dateOfBirth"]).ToString("dd.MM.yyyy");
                            lbl_t4_dateFrom.Text = ((DateTime)((DataRow)d1.Tables["Data"].Rows[0])["dateFrom"]).ToString("dd.MM.yyyy");
                            lbl_t4_age.Text = FunctionClass.CalculateAge((DateTime)((DataRow)d1.Tables["Data"].Rows[0])["dateOfBirth"]).ToString() + " години";
                            lbl_t4_dateTo.Text = ((DateTime)((DataRow)d1.Tables["Data"].Rows[0])["dateTo"]).ToString("dd.MM.yyyy");
                            var data = (Byte[])(((DataRow)d1.Tables["Data"].Rows[0])["photo"]);
                            var ms = new MemoryStream(data);
                            pb_t4_photo.Image = Image.FromStream(ms);
                            DataSet d2 = FunctionClass.Select_Activities_By_UserID(id);
                           
                            // fill dgv_activities
                            DataTable dt = d2.Tables["Data"];
                            dgv_activities.DataSource = dt;
                            dgv_activities.Columns[0].HeaderText = "Датум";
                            dgv_activities.Columns[1].HeaderText = "Услуга";

                            if (dgv_activities.DataSource != null && dgv_activities.Rows.Count > 0)
                                btn_t4_print.Enabled = true;
                            else
                                btn_t4_print.Enabled = false;
                        }
                      
                        break;
                    }
                   
                }
            }
            else
            {
                lbl_t4_userCode.Text = "";
                lbl_t4_name.Text = "";
                lbl_t4_surname.Text = "";
                lbl_t4_birthdate.Text = "";
                lbl_t4_dateFrom.Text = "";
                lbl_t4_age.Text = "";
                lbl_t4_dateTo.Text = "";
                pb_t4_photo.Image = pb_t4_photo.InitialImage;
                dgv_activities.DataSource = null;
                dgv_activities.Rows.Clear();
                btn_t4_print.Enabled = false;
            }

            


        }

        private void btn_t3_print_Click(object sender, EventArgs e)
        {
            Print pr = new Print();
            this.Hide();
            pr.setUserCode = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
            pr.setName = tb_t3_name.Text;
            pr.setSurname = tb_t3_surname.Text;
            pr.setMail = tb_t3_mail.Text;
            pr.setPhone = tb_t3_phone.Text;
            pr.setBirthdate = dtp_t3_birthdate.Value.ToString("dd.MM.yyyy");
            pr.setActivationCode = tb_t3_activationCode.Text;
            pr.setDateFrom = dtp_t3_dateFrom.Value.ToString("dd.MM.yyyy");
            pr.setDateTo = (dtp_t3_dateFrom.Value.AddMonths(1)).ToString("dd.MM.yyyy");
            pr.Show();
           
            //ID = -1;
            //tb_t3_name.Text = "";
            //tb_t3_surname.Text = "";
            //tb_t3_mail.Text = "";
            //pb_t3_photo.Image = Properties.Resources.slika;
            //tb_t3_phone.Text = "";
            //tb_t3_activationCode.Text = "";
            //dtp_t3_birthdate.Value = DateTime.Today;
            //dtp_t3_dateFrom.Value = DateTime.Today;

            btn_t3_print.Enabled = false;
            btn_t3_print.Visible = false;

        }

       
       






    }
}
