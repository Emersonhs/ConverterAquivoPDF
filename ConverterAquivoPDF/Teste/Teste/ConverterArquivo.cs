using PdfSharp.Charting;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Teste
{
    public class ConverterArquivo
    {
        public void Converter()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var xmlInputData = File.ReadAllText(@"D:\EHSSitemas\Niveus\ConverterAquivoPDF\JANEIRO2018.ofc",Encoding.UTF8);
            // C#
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                textFormatter.DrawString(xmlInputData, new XFont("Arial",10), 
                    XBrushes.Black, 
                    new XRect(0, 0, page.Width, page.Height));

                doc.Save("arquivo.pdf");
                
            }

        }
    }
}
