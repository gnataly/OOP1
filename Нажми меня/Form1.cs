﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Нажми_меня
{
    public partial class Form1 : Form
    {
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "НАЖМИ МЕНЯ";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k++;
            if (k == 1) button1.Text = "Вы нажа-а-а-а-ли меня!!!!";
            else Close();
        }
    }
}
