using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();

            lbl_issueDate.Text = DateTime.Today.ToString("dd.MM.yyyy") + ",";
        }

        private void Print_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string l1 = lbl_userCode.Text;
            string tB1 = lbl_userCode_value.Text;

            string l2 = lbl_name.Text;
            string tB2 = lbl_name_value.Text;

            string l3 = lbl_surname.Text;
            string tB3 = lbl_surname_value.Text;

            string l4 = lbl_mail.Text;
            string tB4 = lbl_mail_value.Text;

            string l5 = lbl_phone.Text;
            string tB5 = lbl_phone_value.Text;

            string l6 = lbl_birthdate.Text;
            string tB6 = lbl_birthdate_value.Text;

            string l7 = lbl_activationCode.Text;
            string tB7 = lbl_activationCode_value.Text;

            string l8 = lbl_issueDate.Text;
            string tB8 = lbl_skopje.Text;

            string l9 = lbl_issuer.Text;
            string tB9 = lbl_signature.Text;

            string title = lbl_title.Text;

            Graphics g = e.Graphics;
            Font printFont = new Font("Arial", 13);
            float fltLineHeight = printFont.GetHeight() + 2;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            //g.DrawString("Спортски Центар \"Борис Трајковски\" ", new Font("Arial", 11), Brushes.Black, x, y);
            //y += fltLineHeight;
            g.DrawImage(pb_scbtLogo.Image, x, y, 190, 95);
            x += 330;
            g.DrawImage(pb_finkiLogo.Image, x, y, 265, 75);
            //y += fltLineHeight;
            y += 190;
            x -= 330;

            x += 145;
            g.DrawString(title, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, x, y);
            x += 15;
            y += fltLineHeight+50;

            g.DrawString(l1 + "  "+ tB1, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l2 + "  " + tB2, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l3 + "  " + tB3, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l4 + "  " + tB4, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l5 + "  " + tB5, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l6 + "  " + tB6, printFont, Brushes.Black, x, y);
            y += fltLineHeight;
            g.DrawString(l7 + "  " + tB7, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, x, y);
            y += fltLineHeight+250;

            x -= 45;
            g.DrawString(l8, printFont, Brushes.Black, x, y);
            x+=320;
            g.DrawString(l9, printFont, Brushes.Black, x, y);
            x -= 320;
            y += fltLineHeight;
            g.DrawString(tB8, printFont, Brushes.Black, x, y);
            x += 320;
            g.DrawString(tB9, printFont, Brushes.Black, x, y);
            
        }


    }
}
