using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterArquivo
{
    public class ConverterPdf
    {
        public void Converter(string LocalArquivo, string LocalSalvar, string NomeArquivo)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var Dados = File.ReadAllText(LocalArquivo);

            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                textFormatter.DrawString(Dados, new XFont("Arial", 9),
                    XBrushes.Black,
                    new XRect(0, 0, page.Width, page.Height));

                doc.Save(LocalSalvar+ "\\" + NomeArquivo + ".pdf");

            }
        }
    }
}
