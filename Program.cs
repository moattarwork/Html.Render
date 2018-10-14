using System;
using Aspose.Html;
using Aspose.Html.Dom.Events;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Pdf;
using EvoPdf.HtmlToPdfClient;
using SelectPdf;

namespace pdf
{
    class Program
    {
        static HTMLDocument html;
        static void Main(string[] args)
        {
            // var configuration = new Configuration() {Security = new };
            // html = new HTMLDocument("index.html", configuration);
            // using (var renderer = new HtmlRenderer())
            // {
            //     renderer.Render(new PdfDevice("output.pdf"), TimeSpan.FromSeconds(10), html);
            // }

            HtmlToPdf converter = new HtmlToPdf();
 
            // convert the url to pdf
            PdfDocument doc = converter.ConvertUrl("file:///c:/_samples/pdf/index.html");
            
            // save pdf document
            doc.Save("output-report.pdf");
            
            // close pdf document
            doc.Close();

        }
    }
}
