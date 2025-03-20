using CapaNegocio;
using Microsoft.Data.SqlClient;
using System.Numerics;

namespace CapaDatos
{
    public class ConexionSQLServer : FuenteDeDatos
    {
        private SqlConnection conexion;

        public ConexionSQLServer()
        {
            this.conexion = new SqlConnection(@"TrustServerCertificate=True;Password=2003;Persist Security Info=True;User ID=sa;Initial Catalog=CentralRiesgo;Data Source=DESKTOP-VJ6Q10E\SQLEXPRESS");
        }

        public int consultarPuntaje(string tipoDoc, int nroDoc)
        {
            conexion.Open();

            string select = string.Format(
                "SELECT puntaje FROM centralRiesgo WHERE tipoDoc = '{0}' AND nroDoc = '{1}'",
                tipoDoc, nroDoc
                );

            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader dataReader = comando.ExecuteReader();

            int puntaje = 0;

            while (dataReader.Read())
            {
                puntaje = int.Parse(dataReader.GetValue(0).ToString());

            }

            conexion.Close();

            return puntaje;
        }
    }
}
