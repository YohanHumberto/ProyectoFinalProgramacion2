﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }


        #region "EVENTOS"
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }
        #endregion

        #region "Metodos Privados"
        private void ShowLogin()
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
        #endregion

    }
}
