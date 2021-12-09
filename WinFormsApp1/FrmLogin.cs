using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsLibrary1;

namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {

        Datos datos = new Datos();

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region "EVENTOS"
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region "Metodos Privados"

        private void Login()
        {
            datos
        }

        #endregion
    }
}
