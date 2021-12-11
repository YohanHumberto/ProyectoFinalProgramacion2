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

namespace WinFormsApp1.TiposEntidadesCRUD
{
    public partial class FrmAddAndEditTiposEntidades : Form
    {
        bool EditIsActive;
        int Id;
        Datos datos;

        public FrmAddAndEditTiposEntidades(bool editIsActive, int Id)
        {
            InitializeComponent();
            this.EditIsActive = editIsActive;
            this.Id = Id;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            datos = new Datos(connection);
        }

        #region "Eventos"
        private void ChNoEliminable_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BtnRegGuardar_Click(object sender, EventArgs e)
        {
            ProcesarForm();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void FrmAddAndEditTiposEntidades_Load(object sender, EventArgs e)
        {
            loadCbx();
        }
        private void TbxDireccion_TextChanged(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_VisibleChanged(object sender, EventArgs e)
        {
        }
        private void FrmAddAndEditTiposEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnRegCancelar_Click(object sender, EventArgs e)
        {
            Regresar();
        }



        #endregion;
        #region "Metodos"
        private void loadCbx()
        {
            ComboBoxItem OptDefault = new ComboBoxItem
            {
                Text = "Seleccione una Opccion",
                Value = -1,
            };
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

            CbxEstado.Items.Add(OptDefault);
            CbxEstado.Items.Add(OptActiva);
            CbxEstado.Items.Add(OptInactiva);
            CbxEstado.SelectedItem = OptDefault;



            if (EditIsActive == false)
            {

                LoadGruposEntidadComboBox();
            }
            else if (EditIsActive == true)
            {
                TiposEntidad entidad = datos.GetTiposEntidadesById(Id);

                for (int i = 0; i < CbxEstado.Items.Count; i++)
                {
                    ComboBoxItem item = CbxEstado.Items[i] as ComboBoxItem;

                    if (item.Text == entidad.Status)
                    {
                        CbxEstado.SelectedItem = item;
                    }
                }
                LoadGruposEntidadComboBox();
            }
        }

        private void ProcesarForm()
        {
            ComboBoxItem selectedItemIdGrupoEntidad = CbxIdGrupoEntidad.SelectedItem as ComboBoxItem;
            ComboBoxItem selectedItemEstado = CbxEstado.SelectedItem as ComboBoxItem;

            if (string.IsNullOrEmpty(TbxDescripcion.Text) || string.IsNullOrEmpty(CbxIdGrupoEntidad.Text) || string.IsNullOrEmpty(TbxComentario.Text))
            {
                MessageBox.Show("Debe completar los campos para poder agregar una entidad", "ADVERTENCIA");
            }
            else
            {
                try
                {
                    TiposEntidad tiposEntidad = new TiposEntidad
                    {
                        Descripcion = TbxDescripcion.Text,
                        IdGrupoEntidad = selectedItemIdGrupoEntidad.Value,
                        Comentario = TbxComentario.Text,

                        Status = selectedItemEstado.Text,
                        NoEliminable = CkbNoEliminable.Checked,
                    };
                    bool res = datos.AddTiposEntidade(tiposEntidad);
                    if (res == true)
                    {
                        MessageBox.Show("El tipo de entidad se agrego con exito", "NOTIFICACION");
                        FrmTiposEntidades Frm = new FrmTiposEntidades();
                        Frm.WindowState = FormWindowState.Maximized;
                        Frm.MdiParent = FrmMenúPrincipal.instancia;
                        Frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el tipo de entidad", "ADVERTENCIA");
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Interno Cominiquese cone el admin", "ERROR");
                    Console.WriteLine(e);
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

        private void LoadGruposEntidadComboBox()
        {

            CbxIdGrupoEntidad.Items.Clear();

            ComboBoxItem OptDefault = new ComboBoxItem
            {
                Text = "Seleccione una Opccion",
                Value = -1,
            };

            List<ComboBoxItem> listComboboxGE = new List<ComboBoxItem>();

            List<GruposEntidad> ListGruposEntidads = datos.GetListGruposEntidades();

            if (ListGruposEntidads == null)
            {
                MessageBox.Show("IS null GetListGruposEntidades", "ALERT");
            }
            else
            {
                foreach (GruposEntidad item in ListGruposEntidads)
                {
                    listComboboxGE.Add(new ComboBoxItem
                    {
                        Text = item.Descripcion,
                        Value = item.IdGrupoEntidad,
                    });
                }

                foreach (ComboBoxItem item in listComboboxGE)
                {
                    CbxIdGrupoEntidad.Items.Add(item);
                }
                CbxIdGrupoEntidad.Items.Add(OptDefault);
                CbxIdGrupoEntidad.SelectedItem = OptDefault;
            }
        }


        #endregion;


    }
}
