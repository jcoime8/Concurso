using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAT_FacturaElectronica
{
    public class DAT_Factura
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable table;
        SqlCommand cmd = new SqlCommand();
        public DataTable MostrarFac()
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "MostrarFActura";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            cmd.Connection=conexion.Cconeccion();
            return table;
        }
        public void InsertarFactura(int Ccodigo, int Mcodigo, string Fecha)
        {
            cmd.Connection= conexion.Aconeccion();
            cmd.CommandText = "InsertarFechaF";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ccodigo", Ccodigo);
            cmd.Parameters.AddWithValue("@Mcodigo", Mcodigo);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        } 

        public void Editar (string Fecha, int idFactura )
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "EditarFecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }

        public void EliminarFactura(int idFactura)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "EliminarFactura ";
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);
            cmd.Parameters.Clear();
            cmd.ExecuteNonQuery ();
            cmd.Connection=conexion.Cconeccion ();
        }

    }
}
