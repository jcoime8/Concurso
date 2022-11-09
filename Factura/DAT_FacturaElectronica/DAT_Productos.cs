using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAT_FacturaElectronica
{
    public class DAT_Productos
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable table;
        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarProductos()
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "MostrarPro";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            cmd.Connection = conexion.Cconeccion();
            return table;
        }

        public void InsertarProducto(string name, double precio, int stock, int Catcodigo)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "InsertarPro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", name);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@Catcodigo", Catcodigo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }
        public void EditarProducto(string name, double precio, int stock, int Catcodigo, int ProCodigo)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "InsertarPro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", name);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@Catcodigo", Catcodigo);
            cmd.Parameters.AddWithValue("@Codigo", ProCodigo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }

        public void EliminarProducto(int Procodigo)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "EliminarPro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCodigo", Procodigo);
            cmd.ExecuteNonQuery ();
            cmd.Parameters.Clear();
            cmd.Connection=conexion.Cconeccion ();
        }

    }
}
