namespace CapaNegocio
{
    public class Logica
    {
        private FuenteDeDatos fuenteDeDatos;


        public Logica(FuenteDeDatos fuenteDeDatos)
        {
            this.fuenteDeDatos = fuenteDeDatos;
        }

        public string aprobacionCredito(string tipoDocumento, int numeroDocumento, int ingresosTotales, int egresosTotales, int montoSolicitado, int plazoSolicitado)
        {
            //Ejemplo para prueba juan
            int capacidadPago = ingresosTotales - egresosTotales;

            if (capacidadPago < montoSolicitado / plazoSolicitado)
                return "Negado";

            return "Aprobado";
        }

    }
}
