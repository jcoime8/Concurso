using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT_FacturaElectronica;

namespace BLL_FacturaElectronica
{
    public class Cls_Categoria
    {
        private DAT_Categoria categoria = new DAT_Categoria();
        public DataTable MostrarCategoria()
        {
            DataTable tabla = new DataTable();
            tabla = categoria.MostrarCat();
            return tabla;
        }

        public void InsertarCategoria(string name, string detail)
        {
            categoria.InsertarCat(name, detail);
        }

        public void EditarCategoria(string name, string detail, string IdCat)
        {
            categoria.EditarCat(name, detail, Convert.ToInt32(IdCat));
        }

        public void EliminarCategori(string IdCat)
        {
            categoria.EliminarCat(Convert.ToInt32(IdCat));
        }
    }
}
