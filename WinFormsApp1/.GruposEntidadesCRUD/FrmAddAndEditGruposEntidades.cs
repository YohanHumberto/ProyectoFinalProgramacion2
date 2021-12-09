using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.GruposEntidadesCRUD
{
    public partial class FrmAddAndEditGruposEntidades : Form
    {
        public FrmAddAndEditGruposEntidades()
        {
            InitializeComponent();
        }

        private void FrmAddAndEditGruposEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
