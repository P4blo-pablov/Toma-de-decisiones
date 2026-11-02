using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Toma_de_decisiones
{
    public class ReporteDecisionesManager
    {
        
        
        //-------------------------------------
        // RUTA PDF
        //-------------------------------------

        private static string rutaArchivo;

        //private static string contenido = "";
        public static string DecisionEstrategica = "";
        public static string ObtenerRutaArchivo()
        {
            return rutaArchivo;
        }

        //-------------------------------------
        // DATOS GENERALES
        //-------------------------------------

        public static List<string> Integrantes =
            new List<string>();

        public static string Proposito = "";

        //-------------------------------------
        // OBJETIVOS
        //-------------------------------------

        public static List<Objetivo> Objetivos =
            new List<Objetivo>();

        //-------------------------------------
        // ESTRATEGIAS
        //-------------------------------------

        public static List<Estrategia> Estrategias =
            new List<Estrategia>();

        //-------------------------------------
        // IMAGENES
        //-------------------------------------

        public static string RutaMatrizIR = "";

        public static string RutaResultadosIR = "";

        //-------------------------------------
        // DECISION FINAL
        //-------------------------------------

        public static string DecisionFinal = "";

        //-------------------------------------
        // IMAGENES FORMULARIO 4
        //-------------------------------------

        public static string RutaTablaEstrategias = "";

        public static List<string> RutasMatrices =
            new List<string>();

        //-------------------------------------
        // CONFIGURAR RUTA
        //-------------------------------------

        public static void ConfigurarRuta(
            string ruta)
        {
            rutaArchivo = ruta;

            string directorio =
                Path.GetDirectoryName(
                    rutaArchivo);

            if (!Directory.Exists(
                directorio))
            {
                Directory.CreateDirectory(
                    directorio);
            }
        }

        //-------------------------------------
        // SELECCIONAR RUTA
        //-------------------------------------

        public static bool SeleccionarRutaArchivo()
        {
            SaveFileDialog saveDialog =
                new SaveFileDialog();

            saveDialog.Filter =
                "Archivos PDF (*.pdf)|*.pdf";

            saveDialog.Title =
                "Guardar reporte";

            saveDialog.FileName =
                "Reporte_Decisiones_" +
                DateTime.Now.ToString(
                    "yyyyMMdd_HHmmss") +
                ".pdf";

            if (saveDialog.ShowDialog()
                == DialogResult.OK)
            {
                ConfigurarRuta(
                    saveDialog.FileName);

                return true;
            }

            return false;
        }

        //-------------------------------------
        // GUARDAR INTEGRANTES
        //-------------------------------------

        public static void GuardarIntegrantes(
            List<string> lista)
        {
            Integrantes = new List<string>(lista); ;
        }

        //-------------------------------------
        // GUARDAR PROPOSITO
        //-------------------------------------

        public static void GuardarProposito(
            string texto)
        {
            Proposito = texto;
        }

        //-------------------------------------
        // GUARDAR OBJETIVOS
        //-------------------------------------

        public static void GuardarObjetivos(
    List<Objetivo> lista)
        {
            Objetivos = new List<Objetivo>(lista);
        }

        //-------------------------------------
        // GUARDAR ESTRATEGIAS
        //-------------------------------------

        public static void GuardarEstrategias(
            List<Estrategia> lista)
        {
            Estrategias = new List<Estrategia>(lista); ;
        }

        //-------------------------------------
        // GUARDAR IMAGENES
        //-------------------------------------

        public static void GuardarImagenesIR(
            string matriz,
            string resultados)
        {
            RutaMatrizIR = matriz;

            RutaResultadosIR = resultados;
        }

        //-------------------------------------
        // GUARDAR DECISION FINAL
        //-------------------------------------

        public static void GuardarDecisionFinal(
            string texto)
        {
            DecisionFinal = texto;
        }

        //-------------------------------------
        // GUARDAR TABLA ESTRATEGIAS
        //-------------------------------------

        public static void GuardarTablaEstrategias(
            string ruta)
        {
            RutaTablaEstrategias = ruta;
        }

        //-------------------------------------
        // GUARDAR MATRICES
        //-------------------------------------

        public static void GuardarMatrices(
            List<string> rutas)
        {
            RutasMatrices = rutas;
        }

        //-------------------------------------
        // GUARDAR DECISION
        //-------------------------------------

        public static void GuardarDecisionEstrategica(
            string texto)
        {
            DecisionEstrategica = texto;
        }

        //-------------------------------------
        // AGREGAR OBJETIVO PDF
        //-------------------------------------

        private static void AgregarObjetivoPDF(
            Document documento,
            Objetivo obj)
        {
            Font normal =
                FontFactory.GetFont(
                    FontFactory.HELVETICA,
                    11);

            documento.Add(
                new Paragraph(
                    "ID: " + obj.Id,
                    normal));

            documento.Add(
                new Paragraph(
                    "Nombre: " + obj.Nombre,
                    normal));

            documento.Add(
                new Paragraph(
                    "Prioridad: " +
                    obj.Prioridad,
                    normal));

            documento.Add(
                new Paragraph(
                    "Tipo: " +
                    obj.Tipo,
                    normal));

            documento.Add(
                new Paragraph(
                    "Optimización: " +
                    obj.Optimizacion,
                    normal));

            //---------------------------------
            // CUANTITATIVO
            //---------------------------------

            if (obj.Tipo ==
                TipoObjetivo.Cuantitativo)
            {
                documento.Add(
                    new Paragraph(
                        "Valor: " +
                        obj.ValoresCualitativos[0]
                        .Codigo,
                        normal));
            }

            //---------------------------------
            // CUALITATIVO
            //---------------------------------

            else
            {
                documento.Add(
                    new Paragraph(
                        "Valores:",
                        normal));

                foreach (ValorCualitativo v
                    in obj.ValoresCualitativos)
                {
                    documento.Add(
                        new Paragraph(
                            "(" +
                            v.Codigo +
                            ") " +
                            v.Descripcion,
                            normal));
                }
            }

            documento.Add(
                new Paragraph(
                    "--------------------------------"));
        }

        //-------------------------------------
        // GENERAR REPORTE
        //-------------------------------------

        public static void GuardarReporte()
        {
            //---------------------------------
            // VALIDAR RUTA
            //---------------------------------

            if (string.IsNullOrEmpty(
                rutaArchivo))
            {
                if (!SeleccionarRutaArchivo())
                    return;
            }

            //---------------------------------
            // CREAR DOCUMENTO
            //---------------------------------

            Document documento =
                new Document(
                    PageSize.A4,
                    40,
                    40,
                    40,
                    40);

            PdfWriter.GetInstance(
                documento,
                new FileStream(
                    rutaArchivo,
                    FileMode.Create));

            documento.Open();

            //---------------------------------
            // FUENTES
            //---------------------------------

            Font tituloFont =
                FontFactory.GetFont(
                    FontFactory.HELVETICA_BOLD,
                    20);

            Font subtituloFont =
                FontFactory.GetFont(
                    FontFactory.HELVETICA_BOLD,
                    15);

            //---------------------------------
            // TITULO
            //---------------------------------

            Paragraph titulo =
                new Paragraph(
                    "REPORTE DE TOMA DE DECISIONES",
                    tituloFont);

            titulo.Alignment =
                Element.ALIGN_CENTER;

            documento.Add(titulo);

            documento.Add(
                new Paragraph("\n"));

            //---------------------------------
            // INTEGRANTES
            //---------------------------------

            documento.Add(
                new Paragraph(
                    "INTEGRANTES",
                    subtituloFont));

            documento.Add(
                new Paragraph("\n"));

            foreach (string integrante
                in Integrantes)
            {
                documento.Add(
                    new Paragraph(
                        "• " + integrante));
            }

            documento.Add(
                new Paragraph("\n"));

            //---------------------------------
            // PROPOSITO
            //---------------------------------

            documento.Add(
                new Paragraph(
                    "PROPOSITO",
                    subtituloFont));

            documento.Add(
                new Paragraph("\n"));

            documento.Add(
                new Paragraph(
                    Proposito));

            documento.Add(
                new Paragraph("\n"));

            //---------------------------------
            // OBJETIVOS OBLIGATORIOS
            //---------------------------------

            documento.Add(
                new Paragraph(
                    "OBJETIVOS OBLIGATORIOS",
                    subtituloFont));

            documento.Add(
                new Paragraph("\n"));

            foreach (Objetivo obj
                in Objetivos)
            {
                if (obj.Prioridad !=
                    TipoPrioridad.Obligatorio)
                {
                    continue;
                }

                AgregarObjetivoPDF(
                    documento,
                    obj);
            }

            //---------------------------------
            // OBJETIVOS DESEADOS
            //---------------------------------

            documento.Add(
                new Paragraph(
                    "\nOBJETIVOS DESEADOS",
                    subtituloFont));

            documento.Add(
                new Paragraph("\n"));

            foreach (Objetivo obj
                in Objetivos)
            {
                if (obj.Prioridad !=
                    TipoPrioridad.Deseado)
                {
                    continue;
                }

                AgregarObjetivoPDF(
                    documento,
                    obj);
            }

            //---------------------------------
            // NUEVA PAGINA
            //---------------------------------

            //documento.NewPage();

            //---------------------------------
            // IMPORTANCIA RELATIVA
            //---------------------------------

            documento.Add(
                new Paragraph(
                    "IMPORTANCIA RELATIVA",
                    subtituloFont));

            documento.Add(
                new Paragraph("\n"));

            //---------------------------------
            // MATRIZ
            //---------------------------------

            if (File.Exists(
                RutaMatrizIR))
            {
                iTextSharp.text.Image imgMatriz =
                    iTextSharp.text.Image
                    .GetInstance(
                        RutaMatrizIR);

                imgMatriz.ScaleToFit(
                    250f,
                    240f);

                documento.Add(
                    imgMatriz);
            }

            documento.Add(
                new Paragraph("\n"));

            //---------------------------------
            // RESULTADOS
            //---------------------------------

            if (File.Exists(
                RutaResultadosIR))
            {
                iTextSharp.text.Image imgResultados =
                    iTextSharp.text.Image
                    .GetInstance(
                        RutaResultadosIR);

                imgResultados.ScaleToFit(
                    200f,
                    200f);

                documento.Add(
                    imgResultados);
            }

            //---------------------------------
            // ESTRATEGIAS
            //---------------------------------

            documento.NewPage();

            documento.Add(
                new Paragraph(
                    "ESTRATEGIAS",
                    subtituloFont));

            documento.Add(
                new Paragraph("\n"));

            if (File.Exists(
                RutaTablaEstrategias))
            {
                iTextSharp.text.Image imgTabla =
                    iTextSharp.text.Image
                    .GetInstance(
                        RutaTablaEstrategias);

                imgTabla.ScaleToFit(
                    520f,
                    300f);

                documento.Add(
                    imgTabla);
            }

            //---------------------------------
            // MATRICES
            //---------------------------------

            documento.NewPage();

            documento.Add(new Paragraph("TABLAS Y MATRICES", subtituloFont));
            documento.Add(new Paragraph("\n"));

            foreach (string ruta in RutasMatrices)
            {
                if (File.Exists(ruta))
                {
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ruta);

                    // Calcular el tamaño proporcional más pequeño
                    // Ancho máximo de la página A4 es ~550 (con márgenes)
                    float maxWidth = 500f;
                    float maxHeight = 350f;  // Altura máxima reducida

                    // Escalar la imagen manteniendo proporción
                    if (img.Width > maxWidth || img.Height > maxHeight)
                    {
                        float ratioWidth = maxWidth / img.Width;
                        float ratioHeight = maxHeight / img.Height;
                        float ratio = Math.Min(ratioWidth, ratioHeight);

                        img.ScalePercent(ratio * 100);
                    }
                    else
                    {
                        // Si es más pequeña, escalar al 80% para que sea más compacta
                        img.ScalePercent(80f);
                    }

                    // Alinear al centro
                    img.Alignment = Element.ALIGN_CENTER;

                    documento.Add(img);
                    documento.Add(new Paragraph("\n"));
                    documento.Add(new Paragraph(" ")); // Espacio adicional entre imágenes
                }
            }

            //---------------------------------
            // DECISION
            //---------------------------------

            documento.Add(
                new Paragraph(
                    "DECISION",
                    subtituloFont));

            documento.Add(
                new Paragraph("\n"));

            documento.Add(
                new Paragraph(
                    DecisionEstrategica));

            documento.Add(
                new Paragraph("\n"));

            //---------------------------------
            // DECISION FINAL
            //---------------------------------

            if (!string.IsNullOrWhiteSpace(
                DecisionFinal))
            {
                documento.NewPage();

                documento.Add(
                    new Paragraph(
                        "DECISION FINAL",
                        subtituloFont));

                documento.Add(
                    new Paragraph("\n"));

                documento.Add(
                    new Paragraph(
                        DecisionFinal));
            }

            //---------------------------------
            // CERRAR
            //---------------------------------

            documento.Close();

            //---------------------------------
            // MENSAJE
            //---------------------------------

            MessageBox.Show(
                "PDF generado correctamente",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //-------------------------------------
        // LIMPIAR TODO
        //-------------------------------------

        public static void LimpiarReporte()
        {
            Integrantes.Clear();

            Proposito = "";

            Objetivos.Clear();

            Estrategias.Clear();

            RutaMatrizIR = "";

            RutaResultadosIR = "";

            DecisionFinal = "";
        }

        //-------------------------------------
        // VERIFICAR CONTENIDO
        //-------------------------------------

        public static bool HayContenidoEnReporte()
        {
            return
                Integrantes.Count > 0
                ||
                !string.IsNullOrWhiteSpace(
                    Proposito)
                ||
                Objetivos.Count > 0
                ||
                Estrategias.Count > 0;
        }

        public static void GuardarMatricesSeparadas(List<Tuple<string, string>> matrices)
        {
            RutasMatrices.Clear();

            foreach (var item in matrices)
            {
                // Guardar la matriz
                if (File.Exists(item.Item1))
                {
                    RutasMatrices.Add(item.Item1);
                }

                // Guardar la tabla ER
                if (File.Exists(item.Item2))
                {
                    RutasMatrices.Add(item.Item2);
                }
            }
        }
    }

}
