using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.EntidadesCRUD;
using WinFormsLibrary1;
using WinFormsLibrary1.Modelos;

namespace WinFormsApp1
{
    public partial class FrmEntidades : Form
    {

        Datos datos;
        int IndexDB = -1;

        public FrmEntidades()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            datos = new Datos(connection);
            InitializeComponent();
        }

        #region "EVENTOS"
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEntidades_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FrmEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
              this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IndexDB = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                ActivarBotones();
            }
#pragma warning disable CS0168 // La variable 'E' se ha declarado pero nunca se usa
            catch (Exception E)
#pragma warning restore CS0168 // La variable 'E' se ha declarado pero nunca se usa
            {
                MessageBox.Show("ERROR", "Notificacion");
            }
        }

        #endregion

        #region "METODOS PRIVADOS"

        private void LoadData()
        {
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = datos.GetAllEntidades();
        }

        private void ActivarBotones()
        {
            BtnEditar.Visible = true;
            BtnEliminar.Visible = true;
        }

        private void Agregar()
        {
            FrmMenúPrincipal.instancia.AbrirFrmAddAndEditEntidades(false, -1);
            this.Close();
        }

        private void Editar()
        {
            if (IndexDB != -1)
            {
                FrmMenúPrincipal.instancia.AbrirFrmAddAndEditEntidades(true, IndexDB);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una entidad para poder editarla","ADVERTENCIA");
            }
        }

        private void Eliminar()
        {
            if(IndexDB != -1)
            {
              bool res =  datos.DeleteEntidad(IndexDB);
              if(res == true)
              {
                    MessageBox.Show("Entidad Eliminada conexito", "NOTIFICACION");
                    LoadData();
              }
              else
              {
                    MessageBox.Show("Error no se pudo eliminar la entidad", "ADVERTENCIA");
              }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una entidad para poder eliminarla","ADVERTENCIA");
            }
        }

        #endregion

       
    }
}
