using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ENT_FacturacionElectronica;
namespace DAL_FacturacionElectronica
{
    public class Cls_ModoPago_DAL
    {
        public void Insertar(Cls_ModoPago_ENT modo_pago)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL_FacturacionElectronica.Properties.Settings.connect"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "INSERT INTO modo_pago (mpo_nombre, mpo_detalle) VALUES (@nombre, @detalle)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@nombre", modo_pago.Mpo_nombre);
                    cmd.Parameters.AddWithValue("@detalle",modo_pago.Mpo_detalle);
                    cmd.ExecuteNonQuery();
                }
                cnx.Close();
            }
        }
        public List<Cls_ModoPago_ENT> ConsultarTodos()
        {
            List<Cls_ModoPago_ENT> modo_pagos = new List<Cls_ModoPago_ENT>();
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL_FacturacionElectronica.Properties.Settings.connect"].ToString()))
            {
                cnx.Open();

                const string sqlQuery = "SELECT * FROM modo_pago ORDER BY mpo_codigo ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Cls_ModoPago_ENT modo_pago = new Cls_ModoPago_ENT
                        {
                            Mpo_nombre = Convert.ToString(dataReader["Mpo_nombre"]),
                            Mpo_detalle = Convert.ToString(dataReader["Mpo_detalle"])
                        };
                        modo_pagos.Add(modo_pago);
                    }
                }
            }
            return modo_pagos;
        }
        public Cls_ModoPago_ENT Buscar(int idProducto)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL_FacturacionElectronica.Properties.Settings.connect"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM Producto WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        Cls_ModoPago_ENT modo_pago = new Cls_ModoPago_ENT
                        {
                            Mpo_nombre = Convert.ToString(dataReader["Mpo_nombre"]),
                            Mpo_detalle = Convert.ToString(dataReader["Mpo_detalle"])
                        };
                        return modo_pago;
                    }
                }
            }
            return null;
        }
        public void Modificar(Cls_ModoPago_ENT modo_pago)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL_FacturacionElectronica.Properties.Settings.connect"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE modo_pago SET mpo_nombre = @mpo_nombre, detalle = @mpo_detalle WHERE mpo_codigo = @mpo_codigo";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@mpo_nombre", modo_pago.Mpo_nombre);
                    cmd.Parameters.AddWithValue("@mpo_detalle", modo_pago.Mpo_detalle);
                    cmd.Parameters.AddWithValue("@mpo_codigo", modo_pago.Mpo_codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Eliminar(int codigo)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL_FacturacionElectronica.Properties.Settings.connect"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM modo_pago WHERE mpo_codigo = @mpo_codigo";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@mpo_codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}