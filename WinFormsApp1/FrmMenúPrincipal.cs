using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void Salir()
        {
            Application.Exit();
        }

        #endregion

    }
}
