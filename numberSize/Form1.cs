﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        _sizes size = new _sizes();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
                size.setSize(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                textBox3.Text = ("" + size.getSize());

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

                MessageBox.Show("" + size.getSize() + size.getValue());
            

           
        }
    }
}
