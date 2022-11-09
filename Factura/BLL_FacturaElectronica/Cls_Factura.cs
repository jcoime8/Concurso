using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT_FacturaElectronica;
using Microsoft.SqlServer.Server;

namespace BLL_FacturaElectronica
{
    public class Cls_Factura
    {
        private DAT_Factura factura = new DAT_Factura();
        public DataTable MostaraFactura() 
        {
            DataTable table = new DataTable();
            table = factura.MostrarFac();
            return table;
        }

        public void InsertarF(string Ccodigo, string Cmodop, string Fecha)
        {
            factura.InsertarFactura(Convert.ToInt32(Ccodigo), Convert.ToInt32(Cmodop), Fecha);
        }

        public void EditarF(string fecha, string IdFactura)
        {
            factura.Editar(fecha, Convert.ToInt32(IdFactura));
        }
        public void EliminarF(string idFactura)
        {
            factura.EliminarFactura(Convert.ToInt32(idFactura));
        }
    }
}
