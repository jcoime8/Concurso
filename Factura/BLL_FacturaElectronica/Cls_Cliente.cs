using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT_FacturaElectronica;

namespace BLL_FacturaElectronica
{
    public class Cls_Cliente
    {
        private DAT_Cliente objetoC = new DAT_Cliente();

        public DataTable mostraCliente()
        {
            DataTable dt = new DataTable();
            dt = objetoC.Mostrar();
            return dt;
        }

        public void insertarCliente(string ced, string apellido, string nombre, string direccion, string fechaN, string telefono, string email)
        {
            objetoC.Insertar(ced,apellido,nombre,direccion,fechaN,telefono,email);

        }

        public void editarCliente(string ced, string apellido, string nombre, string direccion, string fechaN, string telefono, string email, int id)
        {
            objetoC.Editar(ced,apellido,nombre,direccion, fechaN, telefono, email, id);
        }
        
        public void eliminar(int id)
        {
            objetoC.Eliminar(id);
        }
    }
}
