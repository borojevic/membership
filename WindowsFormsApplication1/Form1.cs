﻿using System;
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
        public Form1()
        {
            InitializeComponent();

          
            dateTimePicker3.MaxDate = DateTime.Today.AddDays(1);
            dateTimePicker3.Value = DateTime.Today;
            
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            pictureBox3.Image = null;
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

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
            string tB7 = tB_korisnichki_kod.Text;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

     
     

    }
}
