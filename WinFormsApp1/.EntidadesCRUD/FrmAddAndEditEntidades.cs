using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.EntidadesCRUD
{
    public partial class FrmAddAndEditEntidades : Form
    {

        bool EditIsActive;

        public FrmAddAndEditEntidades(bool editIsActive)
        {
            InitializeComponent();
            this.EditIsActive = editIsActive;
        }

        #region
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegCancelar_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void TbxIdTipoEntidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region "Metodos Privados"

        private void ProcesarForm()
        {
            if (string.IsNullOrEmpty(TbxDescripcion.Text) || string.IsNullOrEmpty(TbxDireccion.Text) || string.IsNullOrEmpty(TbxLocalidad.Text))
            { 
            }
        }

        private void Regresar()
        {

        }

        #endregion

        private void FrmAddAndEditEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
