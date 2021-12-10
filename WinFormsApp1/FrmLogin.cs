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

namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {

        Datos datos;

        public FrmLogin()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            datos = new Datos(connection);
            InitializeComponent();
        }

        #region "EVENTOS"
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region "Metodos Privados"

        private void Login()
        {
            Entidad entidad = datos.GetEntidadesByUserName(TbxUserNameEntidad.Text);

            if (entidad != null)
            {
                if(TbxPasswordEntidad.Text == entidad.PassworEntidad && TbxUserNameEntidad.Text == entidad.UserNameEntidad)
                {
                    FrmMenúPrincipal menu = FrmMenúPrincipal.instancia;
                    menu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contrasena incorrectos", "Advertencia");
                }
            }
            else
            {
                MessageBox.Show("ERROR EN EL SERVER","Advertencia");
            }
        }

        #endregion
    }
}
