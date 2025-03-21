using CapaDatosMemoria;
using CapaNegocio;

namespace CapaNegocioTest
{
    [TestClass]
    public sealed class LogicaTest
    {
        private Logica logica;
        public LogicaTest()
        {
            this.logica = new Logica(new DatosPrueba());
        }

        [TestMethod]
        public void probarPlazo()
        {
            string resultadoEsperado = "Negado";
            string resultadoObtenido = logica.aprobacionCredito("CC", 83289, 93825, 1000, 1000, 100);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void ProbarSiLaBalanzaEsCeroONegativa()
        {
            string resultadoEsperado = "Negado";
            string resultadoObtenido = logica.aprobacionCredito("CC", 123456, 20000, 25000, 5000, 24); 

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void ProbarSiLaRelacionBalaznzaEsIgualOSuperiorA095()
        {
            string resultadoEsperado = "Negado";
            string resultadoObtenido = logica.aprobacionCredito("CC", 123456, 2000, 1000, 3000, 3);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void ProbarSiLARelacionSiEsMayorOIgualA07YMenorA095ConPuntajeBajo()
        {
            string resultadoEsperado = "Negado";
            string resultadoObtenido = logica.aprobacionCredito("CC", 654321, 3000, 2000, 4000, 5); //  puntaje =600

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            
        }

        [TestMethod]
        public void ProbarSiLARelacionSiEsMayorOIgualA07YMenorA095ConPuntajeAlto()
        {
            string resultadoEsperado = "Aprobado";
            string resultadoObtenido = logica.aprobacionCredito("CC", 123456, 80000, 20000, 45000, 24); //  puntaje = 800

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void ProbarSiLARelacionSiEsMayorOIgualA04YMenorA07ConPuntajeBajo()
        {
            string resultadoEsperado = "Negado";
            string resultadoObtenido = logica.aprobacionCredito("TI", 151515, 5000, 3500, 9000, 12); // puntaje = 300

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void ProbarSiLARelacionSiEsMayorOIgualA04YMenorA07ConPuntajeAlto()
        {
            string resultadoEsperado = "Aprobado";
            string resultadoObtenido = logica.aprobacionCredito("CC", 654321, 80000, 20000, 20000, 36); //  puntaje = 800

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void ProbarSiLaRelacionEsMenorA04ConPuntajeBajo()
        {
            string resultadoEsperado = "Negado";
            string resultadoObtenido = logica.aprobacionCredito("TI", 151515, 100000, 30000, 20000, 60); // puntaje=300

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void ProbarSiLaRelacionEsMenorA04ConPuntajeAlto()
        {
            string resultadoEsperado = "Aprobado";
            string resultadoObtenido = logica.aprobacionCredito("TI", 111111, 100000, 30000, 20000, 60); // puntaje = 400

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }



    }
}
