using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.EntidadesCRUD;

namespace WinFormsApp1
{
    public partial class FrmMenúPrincipal : Form
    {

        public static FrmMenúPrincipal instancia = new FrmMenúPrincipal();

        private FrmMenúPrincipal()
        {
            InitializeComponent();
        }

        #region "EVENTOS"

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFrmEntidades();
        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFrmTipoEntidades();
        }

        private void gruposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFrmGrupoEntiadades();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFrmAcercaDe();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarLogin();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        #endregion

        #region "Metodos Privados"

        private void MostrarFrmEntidades()
        {
            FrmEntidades Frm = new FrmEntidades();
            Frm.WindowState = FormWindowState.Maximized;
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void MostrarFrmGrupoEntiadades()
        {
            FrmGruposEntidades Frm = new FrmGruposEntidades();
            Frm.WindowState = FormWindowState.Maximized;
            Frm.MdiParent = this;
            Frm.Show();
        }
       
        private void MostrarFrmTipoEntidades()
        {
            FrmTiposEntidades Frm = new FrmTiposEntidades();
            Frm.MdiParent = this;
            Frm.WindowState = FormWindowState.Maximized;
            Frm.Show();
        }

        private void MostrarFrmAcercaDe()
        {
            FrmAcercaDe Frm = new FrmAcercaDe();
            Frm.MdiParent = this;
            Frm.WindowState = FormWindowState.Maximized;
            Frm.Show();
        }

        private void MostrarLogin()
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void Salir()
        {
            Application.Exit();
        }


        #endregion

        #region "METODOS PUBLICOS"

        public void AbrirFrmAddAndEditEntidades(bool editIsActive, int Index)
        {
            FrmAddAndEditEntidades Frm = new FrmAddAndEditEntidades(editIsActive, Index);
            Frm.WindowState = FormWindowState.Maximized;
            Frm.MdiParent = this;
            Frm.Show();
        }

        #endregion

        private void FrmMenúPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
