using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiPrimeraApp.Consola
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }

    public static class EjerciciosBaseDatos
    {
        public static int InsertarArtista(string nombreArtista)
        {
            var dataTable = new DataTable();
            var cadena = "server=.;database=chinook;trusted_connection=true";
            using (var sqlConnection = new SqlConnection(cadena))
            {
                using (var cmd = new SqlCommand("InsertArtist", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", nombreArtista);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return Convert.ToInt32(dataTable.Rows[0][0]);
        }


        public static void ListarTablaArtista()
        {
            var dt = new DataTable();
            var cadena = "server=.;database=chinook;trusted_connection=true";



            // 1. Para conectar a BD y obtener la data en un data table
            using (var conn = new SqlConnection(cadena))
            {
                using (var cmd = new SqlCommand("GetListOfArtist", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            // 2. Imprimir los datos en consola

            Console.WriteLine(dt.Rows.Count);

        }
    }
}
