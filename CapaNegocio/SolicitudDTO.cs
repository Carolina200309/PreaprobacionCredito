namespace CapaNegocio
{
    public class SolicitudDTO
    {
        public SolicitudDTO()
        {

        }

        public SolicitudDTO(string tipoDocumento, int numeroDocumento, int ingresosTotales, int egresosTotales, int montoSolicitado, int plazoSolicitado)
        {
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.ingresosTotales = ingresosTotales;
            this.egresosTotales = egresosTotales;
            this.montoSolicitado = montoSolicitado;
            this.plazoSolicitado = plazoSolicitado;
        }

        public string tipoDocumento { get; set; }
        public int numeroDocumento { get; set; }
        public int ingresosTotales { get; set; }
        public int egresosTotales { get; set; }
        public int montoSolicitado { get; set; }
        public int plazoSolicitado { get; set; }
    }

}
