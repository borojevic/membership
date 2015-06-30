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

            label25.Text = "25.01.1993";
            label26.Text = "27-06-2015";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker4.Visible = true;
            dateTimePicker4.Enabled = true;
            //DateTime dt = Convert.ToDateTime(label26.Text);
            //dateTimePicker4.Value = dt;
            label26.Visible = false;
        }
    }
}
