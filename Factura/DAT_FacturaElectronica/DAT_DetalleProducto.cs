using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAT_FacturaElectronica
{
    public class DAT_DetalleProducto
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable table;
        SqlCommand cmd = new SqlCommand();
        public DataTable MostrarDetallesdelproducto()
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "MostrarDetF";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            cmd.Connection=conexion.Cconeccion();
            return table;
        }
        public void InsertarDetallesdelproducto(int cantidad, double precio, int Cfactura, int Cproducto)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "InserDetalleF";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@Fac_codigo", Cfactura);
            cmd.Parameters.AddWithValue("@prod_codigo", Cproducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();

        }

        public void EditarDetallesDelProducto(int cantidad, double precio, int Cfactura, int Cproducto, int Cdetallep)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "EditarDeF";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@Fac_codigo", Cfactura);
            cmd.Parameters.AddWithValue("@prod_codigo", Cproducto);
            cmd.Parameters.AddWithValue("@IdDTF", Cdetallep);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }

        public void EliminarDetallesDelProducto(int IdDt)
        {
            cmd.Connection = conexion.Aconeccion();
            cmd.CommandText = "EliminarDetF";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdDTF", IdDt);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conexion.Cconeccion();
        }
    }
}
