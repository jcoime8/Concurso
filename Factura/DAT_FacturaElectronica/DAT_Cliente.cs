using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAT_FacturaElectronica
{
    public class DAT_Cliente
    {
        private Conexion Cd_conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            cmd.Connection = Cd_conexion.Aconeccion();
            cmd.CommandText = "Mostrar";
            cmd.CommandType = CommandType.StoredProcedure;
            leer= cmd.ExecuteReader();
            tabla.Load(leer);
            cmd.Connection= Cd_conexion.Cconeccion();
            return tabla;
        }
        public void Insertar(string ced, string apellido, string nombre, string direccion, string fechaN, string telefono, string email)
        {
            cmd.Connection = Cd_conexion.Aconeccion();
            cmd.CommandText = "insertarCliente";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", ced);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@fechaDeNacimiento", fechaN);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = Cd_conexion.Cconeccion();
        }

        public void Editar(string ced, string apellido, string nombre, string direccion, string fechaN, string telefono, string email, int id)
        {
            cmd.Connection = Cd_conexion.Aconeccion();
            cmd.CommandText = "EditarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", ced);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@fechaDeNacimiento", fechaN);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@id_Cliente", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = Cd_conexion.Cconeccion(); 
        }

        public void Eliminar(int id)
        {
            cmd.Connection= Cd_conexion.Aconeccion();
            cmd.CommandText = "eliminarCliente";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_Cliente", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = Cd_conexion.Cconeccion();
        }

    }
}
