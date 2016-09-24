using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.BusinessLogic;

namespace Hangman.UnitTests
{
    [TestClass]
    public class LetraContenidaEnPalabra
    {
        [TestMethod]
        public void LaLetraXNoEstaContenidaEnLaPalabraMama()
        {
            // definimos el escenario de los valores a enviar
            char laLetra = 'X';
            string laPalabra = "mama";
            bool elResultadoEsperado = false;

            // invocamos al método correspondiente
            //var laReferenciaDinamica = new Herramientas();
            Herramientas laReferenciaDinamica = new Herramientas();
            bool elResultadoReal =
                laReferenciaDinamica.UnaLetraEstaContenidaEnUnaPalabra(
                    laLetra, laPalabra);

            // comparar el resultado real con el esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoReal);

        }



        [TestMethod]
        public void LaLetraASiEstaContenidaEnLaPalabraMama()
        {
            // definimos el escenario de los valores a enviar
            char laLetra = 'a';
            string laPalabra = "mama";
            bool elResultadoEsperado = true;

            // invocamos al método correspondiente
            //var laReferenciaDinamica = new Herramientas();
            Herramientas laReferenciaDinamica = new Herramientas();
            bool elResultadoReal = 
                laReferenciaDinamica.UnaLetraEstaContenidaEnUnaPalabra(
                    laLetra, laPalabra);

            // comparar el resultado real con el esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoReal);

        }

        [TestMethod]
        public void LaLetraAMayusculaSiEstaContenidaEnLaPalabraMama()
        {
            // definimos el escenario de los valores a enviar
            char laLetra = 'A';
            string laPalabra = "mama";
            bool elResultadoEsperado = true;

            // invocamos al método correspondiente
            //var laReferenciaDinamica = new Herramientas();
            Herramientas laReferenciaDinamica = new Herramientas();
            bool elResultadoReal =
                laReferenciaDinamica.UnaLetraEstaContenidaEnUnaPalabra(
                    laLetra, laPalabra);

            // comparar el resultado real con el esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoReal);

        }


    }
}
