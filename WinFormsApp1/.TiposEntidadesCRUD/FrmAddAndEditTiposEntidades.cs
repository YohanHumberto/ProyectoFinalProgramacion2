using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.TiposEntidadesCRUD
{
    public partial class FrmAddAndEditTiposEntidades : Form
    {
        public FrmAddAndEditTiposEntidades()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddAndEditTiposEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
