using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hangman.UnitTestsWcf
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // declare una variable para acceder al wcf
            var hangmanWcf = new WcfHangmanTools.HangmanToolsClient();
            var elResultado = hangmanWcf.SumarCantidades(10, 20);

            Assert.AreEqual(30, elResultado);
        }
    }
}
