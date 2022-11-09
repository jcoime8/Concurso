using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT_FacturaElectronica;

namespace BLL_FacturaElectronica
{
    public class Cls_ModoDePago
    {
        private DAT_ModoDePago modo_pago = new DAT_ModoDePago();
        public DataTable MostrarMP() 
        {
            DataTable tabla = new DataTable();
            tabla = modo_pago.MostrarMP();
            return tabla;
        }
        public void insertarMP(string name, string detail)
        {
            modo_pago.InsertarMP(name, detail);
        }
        public void EditarMP(string name, string detail, string idMP)
        {
            modo_pago.EditarMP(name,detail,Convert.ToInt32(idMP));
        }
        public void EliminarMP(string idMP)
        {
            modo_pago.EliminarMP(Convert.ToInt32(idMP));
        }
    }
}
