using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_FacturacionElectronica
{
    public class ClsConexion_DAL
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-N5SVJSE\\SQLEXPRESS;Initial Catalog=facturacion_electronica;Integrated Security=True");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
