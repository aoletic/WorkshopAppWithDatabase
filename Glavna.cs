﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baze2_MOZAIK
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
            

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Alat();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Radnici();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Radnici_na_alatima();
            newForm.Show();
        }
    }
}
