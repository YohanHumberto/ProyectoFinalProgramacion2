using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1.Modelos
{
    public class GruposEntidad
    {
        public int IdGrupoEntidad { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        public string Status { get; set; }
        public bool NoEliminable { get; set; }
    }
}
