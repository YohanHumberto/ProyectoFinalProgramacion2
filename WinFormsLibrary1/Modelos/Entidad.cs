using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1.Modelos
{
    public class Entidad
    {
        public int IdEntidad { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string TipoEntidad { get; set; }
        public string TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string Teléfonos { get; set; }
        public string URLPaginaWeb { get; set; }
        public string URLFacebook { get; set; }
        public string URLInstagram { get; set; }
        public string URLTwitter { get; set; }
        public string URLTikTok { get; set; }
        public int IdGrupoEntidad { get; set; }
        public int IdTipoEntidad { get; set; }
        public float LimiteCredito { get; set; }
        public string UserNameEntidad { get; set; }
        public string PassworEntidad { get; set; }
        public string RolUserEntidad { get; set; }
        public string Comentario { get; set; }
        public string Status { get; set; }
        public bool NoEliminable { get; set; }
    }
}
