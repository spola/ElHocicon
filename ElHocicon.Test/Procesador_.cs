using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElHocicon.Test
{
    [TestClass]
    public class Procesador_
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentoNulo()
        {
            Procesador proc = new Procesador(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentoVacio()
        {
            Procesador proc = new Procesador(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ArchivoNoExiste()
        {
            Procesador proc = new Procesador("bla");
        }
    }
}
