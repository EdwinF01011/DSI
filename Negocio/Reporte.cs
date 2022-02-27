using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI.Negocio
{
    public class Reporte
    {
        Clscontacto contacto = new Clscontacto();

        public void createPdf(int numberRows, IList<Clscontacto> listado, string[] parametros)
        {
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string categoria = ClsUsuario.categoria_busqueda, usuario = ClsUsuario.CCusuario.Trim();
            DataGridView Dgv = new DataGridView();

            PdfWriter pdfwrites = new PdfWriter("reporteDE.pdf");// el nombre o la carpteta donde se guardará
            PdfDocument pdf = new PdfDocument(pdfwrites);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(80, 40, 65, 40);
            var parrafo = new Paragraph("Directorio Empresarial");
            parrafo.SetFontSize(20);
            var pCategoria = new Paragraph(categoria).SetFontSize(14);
            var time = new Paragraph(System.DateTime.Now.ToString("dd/MM/yyyy"));
            var timeYear = new Paragraph(System.DateTime.Now.Year.ToString("yyyy"));
            var timeYear1 = System.DateTime.Now.Year.ToString();

            var parrafo2 = new Paragraph("Reporte automático del software, generado por el usuario " + usuario + " en la fecha estipulada, con los siguientes parámetros de búsqueda.");

            string[] columnas = { "Nombre", "Razón Social", "Sector", "País", "Ciudad" };
            float[] tamanios = { 6, 6, 6, 6, 6 };//ancho columna, en este caso, dejar 3 sin []
            Table tabla1 = new Table(UnitValue.CreatePercentArray(tamanios));

            var parrafoRows = new Paragraph("Filas encontradas: " + numberRows);

            string[] columnas2 = { "Nombre", "Razón Social", "Sector", "Correo", "Teléfono", "País", "Ciudad" };
            float[] tamanios2 = { 6, 6, 6, 6, 6, 6, 6 };//ancho columna, en este caso, dejar 3 sin []
            Table tabla2 = new Table(UnitValue.CreatePercentArray(tamanios2));

            var parrafoPie = new Paragraph("Reporte de búsqueda \n © DIRECTORIO EMPRESARIAL " + timeYear1);

            documento.Add(parrafo).SetFont(fontContenido);
            documento.Add(pCategoria).SetFont(fontContenido);
            documento.Add(time).SetFont(fontContenido);
            documento.Add(parrafo2).SetFont(fontContenido);

            foreach (var columna in columnas)
            {
                tabla1.AddHeaderCell(new Cell().Add(new Paragraph(columna)).SetFont(fontColumnas).SetFontSize(11));
            }
            tabla1.AddCell(new Cell().Add(new Paragraph(parametros[0]).SetFontSize(9)));
            tabla1.AddCell(new Cell().Add(new Paragraph(parametros[1]).SetFontSize(9)));
            tabla1.AddCell(new Cell().Add(new Paragraph(parametros[2]).SetFontSize(9)));
            tabla1.AddCell(new Cell().Add(new Paragraph(parametros[3]).SetFontSize(9)));
            tabla1.AddCell(new Cell().Add(new Paragraph(parametros[4]).SetFontSize(9)));

            foreach (var columna in columnas2)
            {
                tabla2.AddHeaderCell(new Cell().Add(new Paragraph(columna)).SetFont(fontColumnas).SetFontSize(11));
            }

            for (int i = 0; i < numberRows; i++)
            {
               
                //tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Nombre.ToString())));
                //tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].RazSocial.ToString())));
                //tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Sector.ToString())));
                //tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Correo.ToString())));
                //tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Telefono.ToString())));
                //tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Pais.ToString())));
                //tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Ciudad.ToString())));

                tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Nombre.ToString()).SetFontSize(9)));
                tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].RazSocial.ToString()).SetFontSize(9)));
                tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Sector.ToString()).SetFontSize(9)));
                tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Correo.ToString()).SetFontSize(9)));
                tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Telefono.ToString()).SetFontSize(9)));
                tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Pais.ToString()).SetFontSize(9)));
                tabla2.AddCell(new Cell().Add(new Paragraph(listado[i].Ciudad.ToString()).SetFontSize(9)));
            }

            documento.Add(tabla1);
            documento.Add(parrafoRows).SetFont(fontContenido);
            documento.Add(tabla2).SetFontSize(7);
            documento.Add(parrafoPie).SetFontSize(4);
            documento.Close();
        }




    }
}
