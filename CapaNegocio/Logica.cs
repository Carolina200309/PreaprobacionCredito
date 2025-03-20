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

            if (plazoSolicitado < 1 || plazoSolicitado > 72)
                return "Negado";
            
            
            int balanza = ingresosTotales - egresosTotales;

            if (balanza <= 0)
                return "Negado";
            

            float relacionCreditoBalanza = (montoSolicitado / plazoSolicitado) / balanza;
            if (relacionCreditoBalanza >= 0.95f)
                return "Negado";
            
            int puntaje = fuenteDeDatos.consultarPuntaje(tipoDocumento, nroDoc);

            if (relacionCreditoBalanza >= 0.7f) // Entre .7 y .95
                return puntaje >= 800 ? "Aprobado" : "Negado";
            if (relacionCreditoBalanza >= 0.4f) // .4 y .7
                return puntaje >= 600 ? "Aprobado" : "Negado";
            
            // < .4
            return puntaje >= 400 ? "Aprobado" : "Negado";
        }

    }
}
