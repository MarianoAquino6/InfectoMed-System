using InfectoMed_System.Entidades;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace InfectoMed_System.Herramientas
{
    public class GeneradorPDF
    {
        private string _rutaArchivo;

        /// <summary>
        /// Genera un documento PDF para la consulta ambulatoria de un paciente.
        /// </summary>
        /// <param name="consulta">Consulta ambulatoria.</param>
        /// <param name="paciente">Paciente de la consulta.</param>
        /// <param name="medico">Médico que realizó la consulta.</param>
        /// <returns>Ruta del archivo PDF generado.</returns>
        public string GenerarPDF(ConsultaHC consulta, Paciente paciente, Medico medico)
        {
            try
            {
                // Crear un nuevo documento PDF usando MigraDoc
                MigraDoc.DocumentObjectModel.Document document = new MigraDoc.DocumentObjectModel.Document();

                // Agregar una sección al documento
                Section section = document.AddSection();

                // Configurar la página
                section.PageSetup.PageFormat = PageFormat.A4;
                section.PageSetup.Orientation = Orientation.Portrait;

                // Crear la tabla para la primera parte del documento
                Table table = section.AddTable();
                table.AddColumn(Unit.FromCentimeter(5));  // Columna para la FOTO
                table.AddColumn(Unit.FromCentimeter(10)); // Columna para el texto CONSULTA AMBULATORIA

                // Agregar la primera fila con la FOTO y el texto CONSULTA AMBULATORIA
                Row row1 = table.AddRow();
                var imageCell = row1.Cells[0];
                var image = imageCell.AddImage("LOGO2.png"); // Reemplaza "utn.png" con la ruta de tu imagen

                // Ajustar el tamaño de la imagen (puedes ajustar estos valores según tus preferencias)
                image.Width = Unit.FromCentimeter(4.8);
                image.Height = Unit.FromCentimeter(2.8);

                var textCell = row1.Cells[1];
                var paragraph = textCell.AddParagraph("CONSULTA AMBULATORIA INFECTOLOGICA");
                paragraph.Format.Alignment = ParagraphAlignment.Center;
                // Hacer el texto en negrita
                paragraph.Format.Font.Bold = true;

                // Centrar verticalmente el texto en la celda
                textCell.VerticalAlignment = VerticalAlignment.Center;

                // Configurar el estilo de borde para la tabla
                table.Borders.Color = Colors.Black;
                table.Borders.Width = 0.5;  // Puedes ajustar el ancho del borde según tus preferencias

                // Configurar el estilo de borde para las celdas de la tabla
                foreach (Row row in table.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        cell.Borders.Color = Colors.Black;
                        cell.Borders.Width = 0.5;  // Puedes ajustar el ancho del borde según tus preferencias
                    }
                }

                // Agregar las siguientes filas con la información del paciente
                AddRowWithInfo(table, "PACIENTE", paciente.Nombre);
                AddRowWithInfo(table, "DNI", paciente.DNI);
                AddRowWithInfo(table, "FECHA", consulta.Fecha.ToString("dd/MM/yyyy"));

                // Separación entre la primera parte y el resto del contenido
                section.AddParagraph(); // Puedes ajustar el espacio según tus preferencias

                // Agregar cuerpo del PDF
                AddSectionWithTitle(section, "Motivo Consulta:", consulta.MotivoConsulta);
                AddSectionWithTitle(section, "Enfermedad Actual y Antecedentes de la misma:", consulta.EnfermedadActual);
                AddSectionWithTitle(section, "Antecedentes Personales:", consulta.AntecedentesPersonales);

                AddSectionWithTitle(section, "Examen Fisico:",
                    $"-Inspeccion: {consulta.Inspeccion}\n" +
                    $"-Signos Vitales: {consulta.SignosVitales}\n" +
                    $"-Sistema Tegumentario: {consulta.Tegumentario}\n" +
                    $"-Sistema Linfoganglionar: {consulta.Linfo}\n" +
                    $"-Sistema Venoso Superficial y Profundo: {consulta.Venoso}\n" +
                    $"-Sistema Osteo-Articulo-Muscular: {consulta.Osteo}\n" +
                    $"-Cabeza y Cuello: {consulta.Cabeza}\n" +
                    $"-Sistema Nervioso: {consulta.Nervioso}\n" +
                    $"-Sistema Cardiovascular: {consulta.Cardio}\n" +
                    $"-Sistema Respiratorio: {consulta.Respi}\n" +
                    $"-Abdomen: {consulta.Abdomen}\n" +
                    $"-Otros: {consulta.Otros}");

                AddSectionWithTitle(section, "Estudio Complementario:", consulta.ExamenesComplementarios);
                AddSectionWithTitle(section, "Resumen Semiologico:", consulta.ResumenSemiologico);
                AddSectionWithTitle(section, "Diagnostico Presuntivo:", consulta.DiagnosticoPresuntivo);
                AddSectionWithTitle(section, "Diagnosticos Diferenciales:", consulta.DiagnosticosDiferenciales);
                AddSectionWithTitle(section, "Tratamiento u Orden Medica:", consulta.TratamientoOrden);
                AddSectionWithTitle(section, "Aclaraciones:", consulta.Aclaraciones);

                // Agregar pie del documento con "NOMBRE MEDICO - MN"
                Paragraph footer = section.Footers.Primary.AddParagraph($"Dr. {medico.Nombre} - M.N. {medico.Matricula}");

                //////////////////////// GUARDAR PDF

                //// Obtener la ruta del directorio de documentos
                string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                //// Crear la ruta completa del directorio "SYSTEMA INFECTO"
                string sistemaInfectoPath = Path.Combine(documentosPath, "INFECTOMED");
                string pathTemp = Path.Combine(sistemaInfectoPath, "Temp");


                //// Verificar si la carpeta "INFECTOMED" existe, si no, crearla
                if (!Directory.Exists(pathTemp))
                {
                    Directory.CreateDirectory(pathTemp);
                }

                //// Guardar el documento en la carpeta "SYSTEMA INFECTO"
                string nombreArchivo = $"ConsultaAmbulatoria{paciente.DNI}.pdf";
                _rutaArchivo = Path.Combine(sistemaInfectoPath, nombreArchivo);

                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false);
                pdfRenderer.Document = document;
                pdfRenderer.RenderDocument();
                pdfRenderer.PdfDocument.Save(_rutaArchivo);

                return _rutaArchivo;
            }
            catch (Exception ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                return null;
            }
        }

        // Método para agregar una sección con título y contenido
        private void AddSectionWithTitle(Section parentSection, string title, string content)
        {
            Paragraph sectionTitle = parentSection.AddParagraph(title);
            sectionTitle.Format.Font.Bold = true;

            Paragraph sectionContent = parentSection.AddParagraph(content);
            sectionContent.Format.SpaceAfter = "0.5cm"; // Ajusta según tus preferencias
        }

        /// <summary>
        /// Agrega una fila a una tabla con información específica.
        /// </summary>
        /// <param name="table">Tabla a la que se agregará la fila.</param>
        /// <param name="label">Etiqueta de la información.</param>
        /// <param name="value">Valor de la información.</param>
        /// <param name="rowHeight">Altura de la fila en centímetros (opcional, por defecto 0).</param>
        private void AddRowWithInfo(Table table, string label, string value, double rowHeight = 0)
        {
            Row row = table.AddRow();
            if (rowHeight > 0)
            {
                row.Height = Unit.FromCentimeter(rowHeight);
            }
            row.Cells[0].AddParagraph(label + ":").Format.Font.Bold = true;
            row.Cells[1].AddParagraph(value);
        }

        /// <summary>
        /// Elimina el archivo PDF generado para un paciente.
        /// </summary>
        /// <param name="paciente">Paciente cuyo archivo PDF se desea eliminar.</param>
        public void EliminarPDF(Paciente paciente)
        {
            if (File.Exists(_rutaArchivo))
            {
                File.Delete(_rutaArchivo);
            }
        }

        /// <summary>
        /// Genera un documento PDF para el tratamiento o estudio solicitado para un paciente.
        /// </summary>
        /// <param name="consulta">Consulta con el tratamiento u estudio solicitado.</param>
        /// <param name="paciente">Paciente al que se le realiza el tratamiento o estudio.</param>
        /// <param name="medico">Médico que realiza la solicitud del tratamiento o estudio.</param>
        /// <returns>Ruta del archivo PDF generado.</returns>
        public string GenerarPDFTratamientoOrden(ConsultaHC consulta, Paciente paciente, Medico medico)
        {
            try
            {
                // Crear un nuevo documento PDF usando MigraDoc
                MigraDoc.DocumentObjectModel.Document document = new MigraDoc.DocumentObjectModel.Document();

                // Agregar una sección al documento
                Section section = document.AddSection();

                // Configurar la página
                section.PageSetup.PageFormat = PageFormat.A4;
                section.PageSetup.Orientation = Orientation.Portrait;

                // Crear la tabla para la primera parte del documento
                Table table = section.AddTable();
                table.AddColumn(Unit.FromCentimeter(7));  // Columna para la FOTO
                table.AddColumn(Unit.FromCentimeter(10)); // Columna para el texto CONSULTA AMBULATORIA

                // Agregar la primera fila con la FOTO y el texto CONSULTA AMBULATORIA
                Row row1 = table.AddRow();
                var imageCell = row1.Cells[0];
                var image = imageCell.AddImage("LOGO2.png"); // Reemplaza "utn.png" con la ruta de tu imagen

                // Ajustar el tamaño de la imagen (puedes ajustar estos valores según tus preferencias)
                image.Width = Unit.FromCentimeter(5);
                image.Height = Unit.FromCentimeter(3);
                imageCell.Format.Alignment = ParagraphAlignment.Center;

                var textCell = row1.Cells[1];
                var paragraph = textCell.AddParagraph("CONSULTA AMBULATORIA INFECTOLOGICA");
                paragraph.Format.Alignment = ParagraphAlignment.Center;
                // Hacer el texto en negrita
                paragraph.Format.Font.Bold = true;

                // Centrar verticalmente el texto en la celda
                textCell.VerticalAlignment = VerticalAlignment.Center;

                // Configurar el estilo de borde para la tabla
                table.Borders.Color = Colors.Black;
                table.Borders.Width = 0.5;  // Puedes ajustar el ancho del borde según tus preferencias

                // Configurar el estilo de borde para las celdas de la tabla
                foreach (Row row in table.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        cell.Borders.Color = Colors.Black;
                        cell.Borders.Width = 0.5;  // Puedes ajustar el ancho del borde según tus preferencias
                    }
                }

                // Agregar las siguientes filas con la información del paciente
                AddRowWithInfo(table, "PACIENTE", paciente.Nombre);
                AddRowWithInfo(table, "DNI", paciente.DNI);
                AddRowWithInfo(table, "OBRA SOCIAL Y PLAN", paciente.PlanObraSocial);
                AddRowWithInfo(table, "NUMERO DE SOCIO", paciente.NumeroSocio);
                AddRowWithInfo(table, "TRATAMIENTO O ESTUDIO/S SOLICITADO/S", consulta.TratamientoOrden, 2.5);
                AddRowWithInfo(table, "ACLARACIONES", consulta.Aclaraciones);
                AddRowWithInfo(table, "DIAGNOSTICO", consulta.DiagnosticoPresuntivo);
                AddRowWithInfo(table, "FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                AddRowWithInfo(table, "MEDICO SOLICITANTE", $"Dr. {medico.Nombre} - M.N. {medico.Matricula}");
                AddRowWithInfo(table, "FIRMA", "", 2.5);

                //////////////////////// GUARDAR PDF

                //// Obtener la ruta del directorio de documentos
                string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                //// Crear la ruta completa del directorio "SYSTEMA INFECTO"
                string sistemaInfectoPath = Path.Combine(documentosPath, "SYSTEMA INFECTO TEMPORAL");

                //// Verificar si la carpeta "SYSTEMA INFECTO" existe, si no, crearla
                if (!Directory.Exists(sistemaInfectoPath))
                {
                    Directory.CreateDirectory(sistemaInfectoPath);
                }

                //// Guardar el documento en la carpeta "SYSTEMA INFECTO"
                string nombreArchivo = $"Tratamiento{paciente.DNI}.pdf";
                _rutaArchivo = Path.Combine(sistemaInfectoPath, nombreArchivo);

                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false);
                pdfRenderer.Document = document;
                pdfRenderer.RenderDocument();
                pdfRenderer.PdfDocument.Save(_rutaArchivo);

                return _rutaArchivo;
            }
            catch (Exception ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                return null;
            }
        }
    }
}