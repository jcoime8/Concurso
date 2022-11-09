using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAT_FacturaElectronica
{
    public class DAT_ModoDePago
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable table;
        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarMP()
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "MostrarModoP";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            cmd.Connection = conexion.Cconeccion();
            return table;
        }

        public void InsertarMP(string Name, string Detail)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "InsertarModoP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Mnombre", Name);
            cmd.Parameters.AddWithValue("@Pdetalle", Detail);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection=conexion.Cconeccion();
        }

        public void EditarMP(string Name, string Detail, int IdMP)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "EditarMP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Mnombre", Name);
            cmd.Parameters.AddWithValue("@Pdetalle", Detail);
            cmd.Parameters.AddWithValue("@idMP", IdMP);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }

        public void EliminarMP(int idMP)
        {
            cmd.Connection= conexion.Aconeccion();
            cmd.CommandText = "EliminarMP";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMP", idMP);
            cmd.ExecuteNonQuery ();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }


    }
}
