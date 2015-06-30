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
        //

    }
}
