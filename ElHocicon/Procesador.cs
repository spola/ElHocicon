using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ElHocicon
{
    public class Procesador : IDisposable
    {
        private static Regex reg = new Regex(@"(GET /propiedades/fichas.asp)|(GET /buscar_resp.asp)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        protected StreamReader Reader { get; set; }
        protected StreamWriter Writer { get; set; }

        public Procesador(string file)
        {
            if (string.IsNullOrEmpty(file))
            {
                throw new ArgumentException("file no es válido");
            }

            FileStream f = File.OpenRead(file);
            Reader = new StreamReader(f);

            string salida = Path.GetFileNameWithoutExtension(file) + ".out." + Path.GetExtension(file);
            salida = Path.GetDirectoryName(file) + "/out." + Path.GetFileName(file);
            Writer = new StreamWriter(salida, false);
        }

        public bool Coincide(string linea)
        {
            return reg.IsMatch(linea);
        }

        public void Run()
        {
            string linea;
            while ((linea = Reader.ReadLine()) != null)
            {
                if (Coincide(linea))
                {
                    Writer.WriteLine(linea);
                }
            }
        }



        #region IDisposable Members

        public void Dispose()
        {
            Reader.Close();
            Writer.Close();
        }

        #endregion
    }
}
