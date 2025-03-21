using CapaNegocio;

namespace CapaDatosMemoria
{
    public class DatosPrueba:  FuenteDeDatos
    {
        private List<PuntajeDTO> puntajes;

        public DatosPrueba()
        {
            this.puntajes = new List<PuntajeDTO>();
            this.puntajes.Add(new PuntajeDTO("CC", 123456, 800));
            this.puntajes.Add(new PuntajeDTO("CC", 654321, 600));
            this.puntajes.Add(new PuntajeDTO("TI", 111111, 400));
            this.puntajes.Add(new PuntajeDTO("TI", 151515, 300));
        }

        public int consultarPuntaje(string tipoDoc, int nroDoc)
        {
            PuntajeDTO registro = puntajes.FirstOrDefault(s => s.tipoDocumento == tipoDoc && s.numeroDocumento == nroDoc);

            if (registro == null) return 0;

            return registro.puntaje;
        }
    }
}
