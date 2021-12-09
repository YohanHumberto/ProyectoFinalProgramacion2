using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmEntidades : Form
    {
        public FrmEntidades()
        {
            InitializeComponent();
        }

        private void FrmEntidades_Load(object sender, EventArgs e)
        {

        }

        private void FrmEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
              this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
