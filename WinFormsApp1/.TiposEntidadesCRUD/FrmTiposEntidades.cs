using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.TiposEntidadesCRUD;
using WinFormsLibrary1;
using WinFormsLibrary1.Modelos;

namespace WinFormsApp1
{
    public partial class FrmTiposEntidades : Form
    {
        Datos datos;
        int IndexDB = -1;

        public FrmTiposEntidades()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            datos = new Datos(connection);
        }
        #region "Eventos"
        
        private void FrmTiposEntidades_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IndexDB = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                ActivarBotones();
            }
            catch (Exception E)
            {
                MessageBox.Show("ERROR", "Notificacion");
            }
        }
        private void FrmTiposEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        #endregion
        #region "METODOS PRIVADOS"

        private void LoadData()
        {
            dataGridView1.DataSource = datos.GetAllTiposEntidades();
        }

        private void ActivarBotones()
        {
            BtnEditar.Visible = true;
            BtnEliminar.Visible = true;
        }

        private void Agregar()
        {
            FrmAddAndEditTiposEntidades Frm = new FrmAddAndEditTiposEntidades(false, -1);
            Frm.MdiParent = FrmMenúPrincipal.instancia;
            Frm.Show();
            this.Close();
        }

        private void Editar()
        {
            if (IndexDB != -1)
            {
                FrmAddAndEditTiposEntidades Frm = new FrmAddAndEditTiposEntidades(true, IndexDB);
                Frm.MdiParent = FrmMenúPrincipal.instancia;
                Frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de entidad para poder editarla", "ADVERTENCIA");
            }
        }

        private void Eliminar()
        {
            if (IndexDB != -1)
            {
                datos.DeleteTiposEntidade(IndexDB);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de entidad para poder eliminarla", "ADVERTENCIA");
            }
        }

        #endregion

       
    }
}
