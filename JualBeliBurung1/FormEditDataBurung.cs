﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JualBeliBurung
{
    public partial class FormEditDataBurung : Form
    {
        public FormEditDataBurung()
        {
            InitializeComponent();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            FormAdmin formadmin = new FormAdmin();
            formadmin.Show();
            this.Hide();
        }

        private void FormEditDataBurung_Load(object sender, EventArgs e)
        {

        }
    }
}
