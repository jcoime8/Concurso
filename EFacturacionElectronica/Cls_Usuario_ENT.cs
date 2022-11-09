using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_FacturacionElectronica
{
    public class Cls_Usuario_ENT
    {
        private int usu_codigo;
        private string usu_login;
        private string usu_clave;

        public int Usu_codigo { get => usu_codigo; set => usu_codigo = value; }
        public string Usu_login { get => usu_login; set => usu_login = value; }
        public string Usu_clave { get => usu_clave; set => usu_clave = value; }
    }
}
