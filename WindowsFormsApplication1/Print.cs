﻿using System;
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
    }
}
