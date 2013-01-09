using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElHocicon.Test
{
    [TestClass]
    public class Procesador_Run
    {
        [TestMethod]
        public void TestMethod1()
        {
            Procesador main = new Procesador("./test.txt");

            main.Run();
        }
    }
}
