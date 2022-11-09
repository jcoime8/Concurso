using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT_FacturaElectronica;

namespace BLL_FacturaElectronica
{
    public class Cls_DetalleDelProducto
    {
        private DAT_DetalleProducto dtp = new DAT_DetalleProducto();

        public DataTable MostrarDetallesDelproducto() 
        {
            DataTable table = new DataTable();
            table = dtp.MostrarDetallesdelproducto();
            return table;
        }

        public void InsertarDetallesDelProducto(string cantidad, string precio, string Cfactura, string Cproducto)
        {
            dtp.InsertarDetallesdelproducto(Convert.ToInt32(cantidad), Convert.ToDouble(precio), Convert.ToInt32(Cfactura), Convert.ToInt32(Cproducto));
        }
        public void EditarDetallesDelProducto(string cantidad, string precio, string Cfactura, string Cproducto, string IdDTP)
        {
            dtp.EditarDetallesDelProducto(Convert.ToInt32(cantidad), Convert.ToDouble(precio), Convert.ToInt32(Cfactura), Convert.ToInt32(Cproducto), Convert.ToInt32(IdDTP));
        }
        public void EliminarDetalleDelProducto(string id)
        {
            dtp.EliminarDetallesDelProducto(Convert.ToInt32(id));
        }
    }
}
