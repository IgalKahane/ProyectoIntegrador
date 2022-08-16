using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EjemploClase12.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EjemploClase12.ADO.NET
{
    internal class ProductoVendidoHandler
    {
        public List<ProductosVendidos> GetUsuario(string nombreUsuario)
        {
            // See https://aka.ms/new-console-template for more information


            string connectionstring = @"Server DESKTOP-VMN25V6;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {

                var queryDelete = "SELECT * FROM Usuario where NombreUsuario = @Usuario";

                var parametro = new SqlParameter();

                parametro.ParameterName = "Usuario";
                parametro.SqlDbType = SqlDbType.VarChar;
                parametro.Value = nombreUsuario;
                connection.Open();

                using (SqlCommand comandoDelete = new SqlCommand(queryDelete, connection))
                {

                    comandoDelete.Parameters.Add(parametro);
                    comandoDelete.ExecuteNonQuery();


                }

            }

        }

    }
}