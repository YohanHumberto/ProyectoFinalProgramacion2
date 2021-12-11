using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.GruposEntidadesCRUD;
using WinFormsLibrary1;
using WinFormsLibrary1.Modelos;

namespace WinFormsApp1
{
    public partial class FrmGruposEntidades : Form
    {
        Datos datos;
        int IndexDB = -1;
        public FrmGruposEntidades()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            datos = new Datos(connection);
            InitializeComponent();
        }

        #region "EVENTOS"
        private void FrmGruposEntidades_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FrmGruposEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dataGridview2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IndexDB = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                ActivarBotones();
            }
            catch (Exception E)
            {
                MessageBox.Show("ERROR", "Notificacion");
            }
        }

        #endregion

        #region "METODOS PRIVADOS"

        private void LoadData()
        {
            dataGridView2.ClearSelection();
            dataGridView2.DataSource = datos.GetAllGruposEntidades();
        }

        private void ActivarBotones()
        {
            button5.Visible = true;
            button4.Visible = true;
        }

        private void Agregar()
        {
            FrmAddAndEditGruposEntidades Frm = new FrmAddAndEditGruposEntidades(false, -1);
            Frm.MdiParent = FrmMenúPrincipal.instancia;
            Frm.Show();
            this.Close();
        }

        private void Editar()
        {
            if (IndexDB != -1)
            {
                FrmAddAndEditGruposEntidades Frm = new FrmAddAndEditGruposEntidades(false, IndexDB);
                Frm.MdiParent = FrmMenúPrincipal.instancia;
                Frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo de entidad para poder editarlo", "ADVERTENCIA");
            }
        }
        private void Eliminar()
        {
            if (IndexDB != -1)
            {
                datos.DeleteGruposEntidade(IndexDB);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo de entidad para poder eliminarlo", "ADVERTENCIA");
            }
        }

        #endregion
    }
}
