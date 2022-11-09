using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_FacturacionElectronica;
namespace DAL_FacturacionElectronica
{
    public class Cls_Usuario_DAL
    {
        //public void InsertarUsuario(Cls_Usuario_ENT usuario)
        //{
        //    using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL_FacturacionElectronica.Properties.Settings.connect"].ToString()))
        //    {
        //        cnx.Open();
        //        const string sqlQuery =
        //            "INSERT INTO modo_pago (usu_login, usu_clave) VALUES (@login, @clave)";
        //        using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
        //        {
        //            cmd.Parameters.AddWithValue("@login", usuario.Usu_login);
        //            cmd.Parameters.AddWithValue("@clave", usuario.Usu_clave);
        //            cmd.ExecuteNonQuery();
        //        }
        //        cnx.Close();
        //    }
        //}
        //public List<Cls_ModoPago_ENT> ConsultarTodosUsuario()
        //{
        //    List<Cls_ModoPago_ENT> modo_pagos = new List<Cls_ModoPago_ENT>();
        //    using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL_FacturacionElectronica.Properties.Settings.connect"].ToString()))
        //    {
        //        cnx.Open();

        //        const string sqlQuery = "SELECT * FROM modo_pago ORDER BY mpo_codigo ASC";
        //        using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
        //        {
        //            SqlDataReader dataReader = cmd.ExecuteReader();
        //            while (dataReader.Read())
        //            {
        //                Cls_ModoPago_ENT modo_pago = new Cls_ModoPago_ENT
        //                {
        //                    Mpo_nombre = Convert.ToString(dataReader["Mpo_nombre"]),
        //                    Mpo_detalle = Convert.ToString(dataReader["Mpo_detalle"])
        //                };
        //                modo_pagos.Add(modo_pago);
        //            }
        //        }
        //    }
        //    return modo_pagos;
        //}
        public Cls_Usuario_ENT BuscarUsuario(string login, string clave)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnect"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM usuario WHERE usu_login = @login and usu_clave = @clave";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Cls_Usuario_ENT usuario = new Cls_Usuario_ENT
                        {
                            Usu_login = Convert.ToString(dataReader["Usu_login"]),
                            Usu_clave = Convert.ToString(dataReader["Usu_login"])
                        };
                        return usuario;
                    }
                }
            }
            return null;
        }
        //public void ModificarUsuario(Cls_ModoPago_ENT modo_pago)
        //{
        //    using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL_FacturacionElectronica.Properties.Settings.connect"].ToString()))
        //    {
        //        cnx.Open();
        //        const string sqlQuery =
        //            "UPDATE modo_pago SET mpo_nombre = @mpo_nombre, detalle = @mpo_detalle WHERE mpo_codigo = @mpo_codigo";
        //        using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
        //        {
        //            cmd.Parameters.AddWithValue("@mpo_nombre", modo_pago.Mpo_nombre);
        //            cmd.Parameters.AddWithValue("@mpo_detalle", modo_pago.Mpo_detalle);
        //            cmd.Parameters.AddWithValue("@mpo_codigo", modo_pago.Mpo_codigo);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
        //public void EliminarUsuario(int codigo)
        //{
        //    using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL_FacturacionElectronica.Properties.Settings.connect"].ToString()))
        //    {
        //        cnx.Open();
        //        const string sqlQuery = "DELETE FROM modo_pago WHERE mpo_codigo = @mpo_codigo";
        //        using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
        //        {
        //            cmd.Parameters.AddWithValue("@mpo_codigo", codigo);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}
