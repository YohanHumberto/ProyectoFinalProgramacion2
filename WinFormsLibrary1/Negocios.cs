using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1
{
    public class Negocios
    {
        public bool VerificarLimiteCredito(int credito)
        {
            if (credito <= 0) return false; else return true;
        }
    }
}
