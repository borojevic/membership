using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Int32 ID;

        public Form1()
        {
            InitializeComponent();

        }
        
        

        private void button5_Click(object sender, EventArgs e)
        {
            dateTimePicker3.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            dateTimePicker4.Visible = true;
            dateTimePicker4.Enabled = true;
            //DateTime dt = Convert.ToDateTime(label26.Text);
            //dateTimePicker4.Value = dt;
            
        }


        //
        // upload image
        //
        private void button_upload_slika_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = new Bitmap(open.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(open.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validacii
            //
            //
            MemoryStream ms = new MemoryStream();
            pictureBox3.Image.Save(ms, ImageFormat.Jpeg);
            FunctionClass.Insert_User(textBox1.Text, textBox2.Text, textBox3.Text, ms.ToArray(), textBox4.Text, dateTimePicker1.Value, dateTimePicker2.Value);
            
            DataSet ds = FunctionClass.Select_User_By_ID(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value);
            //Int32 
            ID = Int32.Parse(((DataRow) ds.Tables["Data"].Rows[0])["id"].ToString());

            long activationCode = FunctionClass.ActivationCodeGenerator();
            while (!FunctionClass.ValidateActivationCode(activationCode.ToString()))
            {
                activationCode = FunctionClass.ActivationCodeGenerator();
            }
            tb_activationCode.Text = activationCode.ToString();
            FunctionClass.Insert_GoldCard(dateTimePicker2.Value, dateTimePicker2.Value.AddMonths(1), activationCode.ToString(), ID);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            pictureBox3.Image = null;
            textBox4.Text = "";
            //tb_activationCode.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;


            
        }

    /* printanje - ketiiiiiiiiiiiiiiiiiiiiiii
        private void button7_Click(object sender, EventArgs e)
        {

            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string l1 = label1.Text;
            string tB1 = textBox1.Text;

            string l2 = label2.Text;
            string tB2 = textBox2.Text;

            string l3 = label3.Text;
            string tB3 = textBox3.Text;

            string l4 = label4.Text;
            string tB4 = textBox4.Text;

            string l5 = label5.Text;
            string tB5 = dateTimePicker1.Text;

            string l6 = label14.Text;
            string tB6 = dateTimePicker2.Text;

            string l7 = L_korisnichki_kod.Text;
            string tB7 = tb_activationCode.Text;

            string l8 = label27.Text;
            //string tB8 = textBox4.Text;

            Graphics g = e.Graphics;
            Font printFont = new Font("Arial", 13);
            float fltLineHeight = printFont.GetHeight() + 2;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            //g.DrawString("Спортски Центар \"Борис Трајковски\" ", new Font("Arial", 11), Brushes.Black, x, y);
            //y += fltLineHeight;
            g.DrawImage(pictureBox4.Image, x, y, 190, 100);
            x += 310;
            g.DrawImage(pictureBox5.Image, x, y, 260, 75);
            //y += fltLineHeight;
            y += 150;
            x -= 310;
            g.DrawString(l1  + tB1, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l2  + tB2, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l3  + tB3, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l4  + tB4, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l5  + tB5, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l6  + tB6, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l7  + tB7, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l8 , printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            y += 20;
            g.DrawImage(pictureBox3.Image, x, y, 166, 200);

        }
        */


        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker3.MaxDate = DateTime.Today.AddDays(1);
            dateTimePicker3.Value = DateTime.Today;

        }

        private void btn_printForm_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Print pr = new Print();
            f1.Hide();
            pr.setUserCode = ID.ToString();
            pr.setName = textBox1.Text;
            pr.setSurname = textBox2.Text;
            pr.setMail = textBox3.Text;
            pr.setPhone = textBox4.Text;
            pr.setBirthdate = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            pr.setActivationCode = tb_activationCode.Text;
            pr.Show();

           
        }

     
        private void tb_t2_userCode_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = FunctionClass.Select_GoldCard_By_UserID(Int32.Parse(tb_t2_userCode.Text));
            if (ds.Tables["Data"].Rows.Count > 0)
            {
                lbl_t2_name.Text = ((DataRow)ds.Tables["Data"].Rows[0])["name"].ToString();
                lbl_t2_surname.Text = ((DataRow)ds.Tables["Data"].Rows[0])["surname"].ToString();
                lbl_t2_dateFrom.Text = ((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateFrom"]).ToString("dd.MM.yyyy");
                lbl_t2_dateTo.Text = ((DateTime)((DataRow)ds.Tables["Data"].Rows[0])["dateTo"]).ToString("dd.MM.yyyy");
                var data = (Byte[])(((DataRow)ds.Tables["Data"].Rows[0])["photo"]);
                var ms = new MemoryStream(data);
                pb_t2_photo.Image = Image.FromStream(ms);
                tb_t2_time.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            }
        }

        private void btn_t2_submit_Click(object sender, EventArgs e)
        {
            FunctionClass.Insert_Activity(Convert.ToDateTime(tb_t2_time.Text), tb_t2_serviceID.Text, Int32.Parse(tb_t2_userCode.Text));
            
            
            
        }

        
     
     

    }
}
