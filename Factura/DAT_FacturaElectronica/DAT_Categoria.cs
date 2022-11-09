using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAT_FacturaElectronica
{
    public class DAT_Categoria
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable table;
        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarCat()
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "MostrarCategorias";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            cmd.Connection = conexion.Cconeccion();
            return table;
        }

        public void InsertarCat(string Name, string Detail)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "InsertarCat";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cnombre", Name);
            cmd.Parameters.AddWithValue("@Cdetalle", Detail);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }

        public void EditarCat(string Name, string Detail, int IdCat)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "EditarCat";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cnombre", Name);
            cmd.Parameters.AddWithValue("@Cdetalle", Detail);
            cmd.Parameters.AddWithValue("@idCat", IdCat);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }

        public void EliminarCat(int idCat)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "EliminarCat";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCat", idCat);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }
    }
}
