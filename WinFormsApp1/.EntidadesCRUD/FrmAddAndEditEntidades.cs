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

namespace WinFormsApp1.EntidadesCRUD
{
    public partial class FrmAddAndEditEntidades : Form
    {

        bool EditIsActive;
        int Id;
        Datos datos;

        public FrmAddAndEditEntidades(bool editIsActive, int Id)
        {
            InitializeComponent();
            this.EditIsActive = editIsActive;
            this.Id = Id;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            datos = new Datos(connection);
        }

        #region "EVENTOS"

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegGuardar_Click(object sender, EventArgs e)
        {
            ProcesarForm();
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


        private void FrmAddAndEditEntidades_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmAddAndEditEntidades_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void CbxIdGrupoEntidad_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadTipoEntidadComboBox();
        }
        #endregion

        #region "Metodos Privados"

        private void LoadComboBox()
        {
            ComboBoxItem OptDefault = new ComboBoxItem
                {
                    Text = "Seleccione una Opccion",
                    Value = -1,
                };
            //Física o Jurídica
            ComboBoxItem OptFísica = new ComboBoxItem
            {
                Text = "Física",
                Value = 1,
            };
            ComboBoxItem OptJurídica = new ComboBoxItem
            {
                Text = "Jurídica",
                Value = 2,
            };

            // RNC, Cédula, y Pasaporte
            ComboBoxItem OptRNC = new ComboBoxItem
            {
                Text = "RNC",
                Value = 1,
            };
            ComboBoxItem OptCédula = new ComboBoxItem
            {
                Text = "Cédula",
                Value = 2,
            };
            ComboBoxItem OptPasaporte = new ComboBoxItem
            {
                Text = "Pasaporte",
                Value = 3,
            };

            //Admin, Supervisor, User
            ComboBoxItem OptAdmin = new ComboBoxItem
            {
                Text = "Admin",
                Value = 1,
            };
            ComboBoxItem OptSupervisor = new ComboBoxItem
            {
                Text = "Supervisor",
                Value = 2,
            };
            ComboBoxItem OptUser = new ComboBoxItem
            {
                Text = "User",
                Value = 3,
            };

            //Activa Innactiva
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

            CbxTipoEntidad.Items.Add(OptFísica);
            CbxTipoEntidad.Items.Add(OptJurídica);

            CbxTipoDocumento.Items.Add(OptRNC);
            CbxTipoDocumento.Items.Add(OptCédula);
            CbxTipoDocumento.Items.Add(OptPasaporte);

            CbxRolUserEntidad.Items.Add(OptAdmin);
            CbxRolUserEntidad.Items.Add(OptSupervisor);
            CbxRolUserEntidad.Items.Add(OptUser);

            CbxEstado.Items.Add(OptActiva);
            CbxEstado.Items.Add(OptInactiva);

            if (EditIsActive == false)
            {
                CbxTipoEntidad.SelectedItem = OptJurídica;
                CbxTipoDocumento.SelectedItem = OptRNC;
                CbxRolUserEntidad.SelectedItem = OptUser;
                CbxEstado.SelectedItem = OptActiva;

                LoadGruposEntidadComboBox();
            }
            else if(EditIsActive == true)
            {

                Entidad entidad = datos.GetEntidadesById(Id);


                for (int i = 0; i < CbxTipoEntidad.Items.Count; i++)
                {
                    ComboBoxItem item = CbxTipoEntidad.Items[i] as ComboBoxItem;

                    if (item.Text == entidad.TipoEntidad)
                    {
                        CbxTipoEntidad.SelectedItem = item;
                    }
                }


                for (int i = 0; i < CbxTipoDocumento.Items.Count; i++)
                {
                    ComboBoxItem item = CbxTipoDocumento.Items[i] as ComboBoxItem;

                    if (item.Text == entidad.TipoDocumento)
                    {
                        CbxTipoDocumento.SelectedItem = item;
                    }
                }

                for (int i = 0; i < CbxRolUserEntidad.Items.Count; i++)
                {
                    ComboBoxItem item = CbxRolUserEntidad.Items[i] as ComboBoxItem;

                    if (item.Text == entidad.RolUserEntidad)
                    {
                        CbxRolUserEntidad.SelectedItem = item;
                    }
                }

                for (int i = 0; i < CbxEstado.Items.Count; i++)
                {
                    ComboBoxItem item = CbxEstado.Items[i] as ComboBoxItem;

                    if (item.Text == entidad.Status)
                    {
                        CbxEstado.SelectedItem = item;
                    }
                }


        
                LoadGruposEntidadComboBox();
                LoadTipoEntidadComboBox();

            }

        }

        private void LoadTipoEntidadComboBox()
        {
            ComboBoxItem selectedItemGrupoEntidad = CbxIdGrupoEntidad.SelectedItem as ComboBoxItem;

            if (CbxIdGrupoEntidad.Text != "Seleccione una Opccion")
            {
                CbxIdTipoEntidad.Items.Clear();

                ComboBoxItem OptDefault = new ComboBoxItem
                {
                    Text = "Seleccione una Opccion",
                    Value = -1,
                };

                List<ComboBoxItem> listComboboxTE = new List<ComboBoxItem>();

                List<TiposEntidad> ListTiposEntidads = datos.GetListTiposEntidades(Convert.ToInt32(selectedItemGrupoEntidad.Value));

                if (ListTiposEntidads != null)
                {
                    foreach (TiposEntidad item in ListTiposEntidads)
                    {
                        listComboboxTE.Add(new ComboBoxItem
                        {
                            Text = item.Descripcion,
                            Value = item.IdGrupoEntidad,
                        });
                    }

                    foreach (ComboBoxItem item in listComboboxTE)
                    {
                        CbxIdTipoEntidad.Items.Add(item);
                    }
                    CbxIdTipoEntidad.Items.Add(OptDefault);
                    CbxIdTipoEntidad.SelectedItem = OptDefault;
                }
                else
                {
                    MessageBox.Show("IS null GetListTipoesEntidades", "ALERT");
                }
            }
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

        private void ProcesarForm()
        {

            ComboBoxItem selectedItemIdGrupoEntidad = CbxIdGrupoEntidad.SelectedItem as ComboBoxItem;
            ComboBoxItem selectedItemIdTipoEntidad = CbxIdTipoEntidad.SelectedItem as ComboBoxItem;
            ComboBoxItem selectedItemTipoEntidad = CbxTipoEntidad.SelectedItem as ComboBoxItem;
            ComboBoxItem selectedItemTipoDocumento = CbxTipoDocumento.SelectedItem as ComboBoxItem;
            ComboBoxItem selectedItemRolUserEntidad = CbxRolUserEntidad.SelectedItem as ComboBoxItem;
            ComboBoxItem selectedItemEstado = CbxEstado.SelectedItem as ComboBoxItem;
   

            if (string.IsNullOrEmpty(TbxDescripcion.Text) || string.IsNullOrEmpty(TbxDireccion.Text) || string.IsNullOrEmpty(TbxLocalidad.Text) ||
                string.IsNullOrEmpty(TbxNumeroDocumento.Text) || string.IsNullOrEmpty(TbxTeléfonos.Text) || string.IsNullOrEmpty(TbxURLPaginaWeb.Text) ||
                string.IsNullOrEmpty(TbxURLFacebook.Text) || string.IsNullOrEmpty(TbxURLInstagram.Text) || string.IsNullOrEmpty(TbxURLTwitter.Text) ||
                string.IsNullOrEmpty(TbxURLTikTok.Text) || string.IsNullOrEmpty(TbxLimiteCredito.Text) || string.IsNullOrEmpty(TbxUserNameEntidad.Text) ||
                string.IsNullOrEmpty(TbxPassworEntidad.Text) || string.IsNullOrEmpty(TbxComentario.Text) || selectedItemIdGrupoEntidad.Value == -1 ||
                selectedItemIdTipoEntidad.Value == -1 || selectedItemTipoEntidad.Value == -1 || selectedItemTipoDocumento.Value == -1 || selectedItemRolUserEntidad.Value == -1 ||
                selectedItemEstado.Value == -1)
            {
                MessageBox.Show("Debe completar los campos para poder agregar una entidad", "ADVERTENCIA");
            }
            else
            {
                try
                {
                    Entidad newEntidad = new Entidad {
                    Descripcion = TbxDescripcion.Text,
                    Direccion = TbxDireccion.Text,
                    Localidad = TbxLocalidad.Text,
                    TipoEntidad = selectedItemTipoEntidad.Text,
                    TipoDocumento = selectedItemTipoDocumento.Text,
                    NumeroDocumento = Convert.ToInt32(TbxNumeroDocumento.Text),
                    Teléfonos = TbxTeléfonos.Text,
                    URLPaginaWeb = TbxURLPaginaWeb.Text,
                    URLFacebook = TbxURLFacebook.Text,
                    URLInstagram = TbxURLInstagram.Text,
                    URLTwitter = TbxURLTwitter.Text,
                    URLTikTok = TbxURLTikTok.Text,
                    IdGrupoEntidad = selectedItemIdGrupoEntidad.Value,
                    IdTipoEntidad = selectedItemIdTipoEntidad.Value,
                    LimiteCredito = Convert.ToDecimal(TbxLimiteCredito.Text),
                    UserNameEntidad = TbxUserNameEntidad.Text,
                    PassworEntidad = TbxPassworEntidad.Text,
                    RolUserEntidad = selectedItemRolUserEntidad.Text,
                    Comentario = TbxComentario.Text,
                    Status = selectedItemEstado.Text,
                    NoEliminable = CkbNoEliminable.Checked,
                };
                    bool res = datos.AddEntidad(newEntidad);

                    if(res == true)
                    {
                        MessageBox.Show("La entidad se agrego con exito", "NOTIFICACION");
                        FrmEntidades Frm = new FrmEntidades();
                        Frm.WindowState = FormWindowState.Maximized;
                        Frm.MdiParent = FrmMenúPrincipal.instancia;
                        Frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la entidad", "ADVERTENCIA");
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
            FrmEntidades Frm = new FrmEntidades();
            Frm.WindowState = FormWindowState.Maximized;
            Frm.MdiParent = FrmMenúPrincipal.instancia;
            Frm.Show();
            this.Close();
        }

        #endregion

        private void CbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
