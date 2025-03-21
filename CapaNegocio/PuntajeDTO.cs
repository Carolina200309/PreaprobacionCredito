namespace CapaNegocio
{
    public class PuntajeDTO
    {
        public PuntajeDTO()
        {

        }

        public PuntajeDTO(string tipoDocumento, int numeroDocumento, int puntaje)
        {
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.puntaje = puntaje;
        }

        public string tipoDocumento { get; set; }
        public int numeroDocumento { get; set; }
        public int puntaje { get; set; }
    }

}
