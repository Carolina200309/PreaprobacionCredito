using CapaDatos;

namespace CapaPresentacion
{
    internal class Logica
    {
        private ConexionSQLServer conexionSQLServer;

        public Logica(ConexionSQLServer conexionSQLServer)
        {
            this.conexionSQLServer = conexionSQLServer;
        }
    }
}