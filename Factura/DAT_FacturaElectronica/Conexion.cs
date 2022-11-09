using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAT_FacturaElectronica
{
    public class Conexion
    {
        private SqlConnection _conexion = new SqlConnection("Server=DESKTOP-OQI8SVP\\SQLEXPRESS;Initial Catalog=Factura;Integrated Security=True;");
        public SqlConnection Aconeccion()
        {
            if (_conexion.State == ConnectionState.Closed)
                _conexion.Open();
            return _conexion;
        }
        public SqlConnection Cconeccion()
        {
            if (_conexion.State == ConnectionState.Open)
                _conexion.Close();
            return _conexion;
        }
    }
}
