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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Agregar();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Editar();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
                FrmAddAndEditGruposEntidades Frm = new FrmAddAndEditGruposEntidades(true, IndexDB);
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
               bool res = datos.DeleteGruposEntidade(IndexDB);
                if (res) { MessageBox.Show("GrupoEntidad Elimanada con exito", "NOTIFICACION"); LoadData(); } else { MessageBox.Show("Error No se pudo eliminar el grupoentidad", "ADVERTENCIA"); }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo de entidad para poder eliminarlo", "ADVERTENCIA");
            }
        }

        private void Buscar()
        {
            if (!string.IsNullOrEmpty(TbxBuscar.Text))
            {
                dataGridView2.ClearSelection();
                dataGridView2.DataSource = datos.GetAllByDescriptionGruposEntidades(TbxBuscar.Text);
            }
            else
            {
                LoadData();
            }
        }

        #endregion

    }
}
