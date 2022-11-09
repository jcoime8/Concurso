using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAT_FacturaElectronica;
using Microsoft.SqlServer.Server;

namespace BLL_FacturaElectronica
{
    public class Cls_Producto
    {
        private DAT_Productos producto = new DAT_Productos();
        public DataTable MostrarProductos()
        {
            DataTable dt = new DataTable();
            dt= producto.MostrarProductos();
            return dt;
        }

        public void Insertarproductos(string name, string precio, string stock, string Catcodigo)
        {
            producto.InsertarProducto(name, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(Catcodigo));
        }

        public void EditarProductos(string name, string precio, string stock, string Catcodigo, string Procodigo)
        {
            producto.EditarProducto(name, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(Catcodigo), Convert.ToInt32(Procodigo));             
        }

        public void EliminarProducto(string id_producto)
        {
            producto.EliminarProducto(Convert.ToInt32(id_producto));
        }
    }
}
