using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_FacturacionElectronica;
using DAL_FacturacionElectronica;
namespace BLL_FacturacionElectronica
{
    public class Cls_Usuario_BLL
    {
        private Cls_Usuario_DAL usuario = new Cls_Usuario_DAL();
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public Cls_Usuario_ENT TraerPorId(string Usuario, string Clave)
        {
            stringBuilder.Clear();

            if (Usuario == "") stringBuilder.Append("Por favor proporcione un valor de usuario valido");
            if (Clave == "") stringBuilder.Append("Por favor proporcione un valor de clave valido");
            if (stringBuilder.Length == 0)
            {
                return usuario.BuscarUsuario(Usuario, Clave);
            }
            return null;
        }
    }
}
