using FinalProject.CustonControlItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsLibrary1;
using WinFormsLibrary1.Modelos;

namespace WinFormsApp1.GruposEntidadesCRUD
{
    public partial class FrmAddAndEditGruposEntidades : Form
    {
        bool EditIsActive;
        int Id;
        Datos datos;

        public FrmAddAndEditGruposEntidades(bool editIsActive, int Id)
        {
            InitializeComponent();
            this.EditIsActive = editIsActive;
            this.Id = Id;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            datos = new Datos(connection);
        }

        #region "EVENTOS"

        private void FrmAddAndEditGruposEntidades_Load(object sender, EventArgs e)
        {
            LoadEditMode();
            LoadBox();
        }

        private void FrmAddAndEditGruposEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnRegGuardar_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            LoadBox();
        }

        private void BtnRegCancelar_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void BtnRegGuardar_Click_1(object sender, EventArgs e)
        {
            ProcesarForm();
        }

        #endregion

        #region "METODOS"

        private void LoadEditMode()
        {
            if (EditIsActive)
            {
                GruposEntidad gruposEntidad = datos.GetGruposEntidadesById(Id);
                TbxComentario.Text = gruposEntidad.Comentario;
                TbxDescripcion.Text = gruposEntidad.Descripcion;
                CkbNoEliminable.Checked = gruposEntidad.NoEliminable;
            }
        }

        private void LoadBox()
        {

            ComboBoxItem OptActiva = new ComboBoxItem
            {
                Text = "Activa",
                Value = 1,
            };

            ComboBoxItem OptInactiva = new ComboBoxItem
            {
                Text = "Inactiva",
                Value = 0,
            };

            CbxEstado.Items.Add(OptActiva);
            CbxEstado.Items.Add(OptInactiva);

           
            if (EditIsActive == true)
            {
                GruposEntidad entidad = datos.GetGruposEntidadesById(Id);

                for (int i = 0; i < CbxEstado.Items.Count; i++)
                {
                    ComboBoxItem item = CbxEstado.Items[i] as ComboBoxItem;

                    if (item.Text == entidad.Status)
                    {
                        CbxEstado.SelectedItem = item;
                    }
                }
            }
            else
            {
                CbxEstado.SelectedItem = OptActiva;
            }

        }

        private void ProcesarForm()
        {
            ComboBoxItem selectedItemEstado = CbxEstado.SelectedItem as ComboBoxItem;
            if (string.IsNullOrEmpty(TbxDescripcion.Text) || string.IsNullOrEmpty(TbxComentario.Text))
            {
                MessageBox.Show("Debe completar los campos para poder agregar un grupo", "ADVERTENCIA");
            }
            else
            {
                try
                {
                    GruposEntidad gruposEntidad = new GruposEntidad
                    {
                        Descripcion = TbxDescripcion.Text,
                        Comentario = TbxComentario.Text,
                        Status = selectedItemEstado.Text,
                        NoEliminable = CkbNoEliminable.Checked,
                    };

                    if (!EditIsActive)
                    {
                        bool res = datos.AddGruposEntidade(gruposEntidad);
                        if (res == true)
                        {
                            MessageBox.Show("El grupo de entidad se guardado con exito", "NOTIFICACION");
                            FrmGruposEntidades Frm = new FrmGruposEntidades();
                            Frm.WindowState = FormWindowState.Maximized;
                            Frm.MdiParent = FrmMenúPrincipal.instancia;
                            Frm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el grupo de entidad", "ADVERTENCIA");
                        }

                    }
                    else
                    {
                        gruposEntidad.IdGrupoEntidad = Id;
                        bool res = datos.EditGruposEntidade(gruposEntidad);
                        if (res == true)
                        {
                            MessageBox.Show("El grupo de entidad se edito con exito", "NOTIFICACION");
                            FrmGruposEntidades Frm = new FrmGruposEntidades();
                            Frm.WindowState = FormWindowState.Maximized;
                            Frm.MdiParent = FrmMenúPrincipal.instancia;
                            Frm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo editar el grupo de entidad", "ADVERTENCIA");
                        }
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error interno, Comuniquese con el Administrador", "ERROR");
                    Console.WriteLine(E);
                }
            }
        }

        private void Regresar()
        {
            FrmTiposEntidades Frm = new FrmTiposEntidades();
            Frm.WindowState = FormWindowState.Maximized;
            Frm.MdiParent = FrmMenúPrincipal.instancia;
            Frm.Show();
            this.Close();
        }

        #endregion

    }
}
