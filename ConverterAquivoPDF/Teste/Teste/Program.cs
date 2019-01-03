using System;
using System.IO;
using System.Text;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string LocalArquivo = @"D:\EHSSitemas\Niveus\ConverterAquivoPDF\JANEIRO2018.ofc";
            string DESTINO = @"D:";

            File.Copy(LocalArquivo, DESTINO + "\\JANEIRO2018.xml", true);
            var arquivo = File.ReadAllText(DESTINO + "\\JANEIRO2018.xml");
            StringBuilder resultado = new StringBuilder();

            var sr = File.OpenRead(LocalArquivo);
            resultado.Append(sr);
            Console.Write(arquivo);

            Console.ReadKey();
        }
    }
}
