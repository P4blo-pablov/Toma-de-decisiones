using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Toma_de_decisiones
{
    public partial class ingreso_Estrategias : Form
    {
        private List<Objetivo> objetivos;
        private List<Estrategia> estrategias = new List<Estrategia>();
        private Dictionary<int, Dictionary<int, int>>erPorObjetivo =new Dictionary<int, Dictionary<int, int>>();
        private List<DataGridViewRow>estrategiasValidas =new List<DataGridViewRow>();
        private List<Tuple<string, string>>imagenesMatrices =new List<Tuple<string, string>>();
        private List<string> rutasTablasFinales = new List<string>();
        public ingreso_Estrategias(List<Objetivo> listaObjetivos)
        {

            InitializeComponent();

            objetivos = listaObjetivos;

            ConfigurarDataGrid();
        }
        private void ConfigurarDataGrid()
        {
            //-----------------------------------
            // LIMPIAR
            //-----------------------------------

            dgvEstrategias.Columns.Clear();

            //-----------------------------------
            // PRIMERA COLUMNA
            //-----------------------------------

            dgvEstrategias.Columns.Add(
                "Estrategia",
                "Estrategia");

            //-----------------------------------
            // COLUMNAS DE OBJETIVOS
            //-----------------------------------

            foreach (Objetivo obj in objetivos)
            {
                dgvEstrategias.Columns.Add(
                    "OBJ_" + obj.Id,
                    obj.Nombre);
            }

            //-----------------------------------
            // ESTILO
            //-----------------------------------

            dgvEstrategias.RowHeadersVisible = false;

            dgvEstrategias.AllowUserToAddRows = true;

            dgvEstrategias.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private List<DataGridViewRow>
        ObtenerFilasValidas()
        {
            List<DataGridViewRow> lista =
                new List<DataGridViewRow>();

            foreach (DataGridViewRow fila
                in dgvEstrategias.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                if (fila.DefaultCellStyle
                    .BackColor != Color.Red)
                {
                    lista.Add(fila);
                }
            }

            return lista;
        }

        private string GuardarFlowComoImagen(
    FlowLayoutPanel flow,
    string nombre)
        {
            Bitmap bmp =
                new Bitmap(
                    flow.DisplayRectangle.Width,
                    flow.DisplayRectangle.Height);

            flow.DrawToBitmap(
                bmp,
                new Rectangle(
                    0,
                    0,
                    flow.DisplayRectangle.Width,
                    flow.DisplayRectangle.Height));

            string carpeta =
                Application.StartupPath +
                "\\Temp";

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(
                    carpeta);
            }

            string ruta =
                carpeta +
                "\\" +
                nombre +
                ".png";

            bmp.Save(ruta);

            return ruta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //-----------------------------------
            // RECORRER FILAS
            //-----------------------------------
            estrategiasValidas.Clear();

            foreach (DataGridViewRow fila
                in dgvEstrategias.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                bool valida = true;

                //-----------------------------------
                // RECORRER OBJETIVOS
                //-----------------------------------

                foreach (Objetivo obj
                    in objetivos)
                {
                    //-----------------------------------
                    // SOLO OBLIGATORIOS
                    //-----------------------------------

                    if (obj.Prioridad !=
                        TipoPrioridad.Obligatorio)
                    {
                        continue;
                    }

                    //-----------------------------------
                    // VALOR ESTRATEGIA
                    //-----------------------------------

                    int valorEstrategia =
                        Convert.ToInt32(
                            fila.Cells[
                                "OBJ_" + obj.Id]
                                .Value);

                    //-----------------------------------
                    // VALOR OBJETIVO
                    //-----------------------------------

                    int valorObjetivo =
                        obj.ValoresCualitativos[0]
                        .Codigo;

                    //-----------------------------------
                    // MENOR
                    //-----------------------------------

                    if (obj.Optimizacion ==
                        TipoOptimizacion.Menor)
                    {
                        if (valorEstrategia >
                            valorObjetivo)
                        {
                            valida = false;
                        }
                    }

                    //-----------------------------------
                    // MAYOR
                    //-----------------------------------

                    else
                    {
                        if (valorEstrategia <
                            valorObjetivo)
                        {
                            valida = false;
                        }
                    }
                }

                //-----------------------------------
                // PINTAR FILA
                //-----------------------------------

                if (!valida)
                {
                    fila.DefaultCellStyle.BackColor =
                        Color.Red;
                }
            }
        }

        private void CrearMatrizEstrategia(Objetivo obj,List<DataGridViewRow> filas)
        {
            //-----------------------------------
            // PANEL DE LA MATRIZ (solo la matriz)
            //-----------------------------------
            Panel panelMatrizCompleto = new Panel();
            panelMatrizCompleto.AutoSize = true;
            panelMatrizCompleto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMatrizCompleto.BorderStyle = BorderStyle.FixedSingle;

            Label tituloMatriz = new Label();
            tituloMatriz.Text = obj.Nombre + " - MATRIZ DE COMPARACIÓN";
            tituloMatriz.Font = new Font("Arial", 10, FontStyle.Bold);
            tituloMatriz.Top = 5;
            tituloMatriz.Left = 5;
            tituloMatriz.AutoSize = true;
            panelMatrizCompleto.Controls.Add(tituloMatriz);

            Panel panelMatriz = new Panel();
            panelMatriz.Top = 30;
            panelMatriz.Left = 5;
            panelMatriz.AutoScroll = false;
            panelMatriz.AutoSize = true;
            panelMatriz.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMatrizCompleto.Controls.Add(panelMatriz);

            //-----------------------------------
            // PANEL DE LA TABLA ER (solo la tabla)
            //-----------------------------------
            Panel panelERCompleto = new Panel();
            panelERCompleto.AutoSize = true;
            panelERCompleto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelERCompleto.BorderStyle = BorderStyle.FixedSingle;

            Label tituloER = new Label();
            tituloER.Text = obj.Nombre + " - TABLA DE EFICACIA RELATIVA (ER)";
            tituloER.Font = new Font("Arial", 10, FontStyle.Bold);
            tituloER.Top = 5;
            tituloER.Left = 5;
            tituloER.AutoSize = true;
            panelERCompleto.Controls.Add(tituloER);

            Panel panelER = new Panel();
            panelER.Top = 30;
            panelER.Left = 5;
            panelER.AutoSize = true;
            panelER.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelERCompleto.Controls.Add(panelER);

            //-----------------------------------
            // GENERAR CONTENIDO
            //-----------------------------------
            GenerarMatriz(obj, filas, panelMatriz, panelER);

            // Forzar actualización
            panelMatriz.PerformLayout();
            panelER.PerformLayout();
            panelMatrizCompleto.PerformLayout();
            panelERCompleto.PerformLayout();
            Application.DoEvents();

            // Ajustar tamaños
            panelMatrizCompleto.Width = panelMatriz.Width + 20;
            panelMatrizCompleto.Height = panelMatriz.Height + 50;

            panelERCompleto.Width = Math.Max(panelER.Width + 20, 250);
            panelERCompleto.Height = panelER.Height + 50;

            //-----------------------------------
            // AGREGAR AMBOS PANELES AL FLOW (separados)
            //-----------------------------------
            flowMatrices.Controls.Add(panelMatrizCompleto);
            flowMatrices.Controls.Add(panelERCompleto);

            // Guardar imágenes
            string rutaMatriz = GuardarControlComoImagen(panelMatrizCompleto, "matriz_completa_" + obj.Id);
            string rutaER = GuardarControlComoImagen(panelERCompleto, "tabla_er_" + obj.Id);

            imagenesMatrices.Add(Tuple.Create(rutaMatriz, rutaER));
        }

        private void GenerarTablaERGeneral()
        {
            Panel panel = new Panel();
            panel.Width = 900;
            panel.Height = 300;
            panel.BorderStyle = BorderStyle.FixedSingle;

            Label titulo = new Label();
            titulo.Text = "TABLA DE EFICACIAS RELATIVAS (TODOS LOS OBJETIVOS)";
            titulo.Font = new Font("Arial", 12, FontStyle.Bold);
            titulo.Left = 10;
            titulo.Top = 10;
            titulo.AutoSize = true;
            panel.Controls.Add(titulo);

            DataGridView dgv = new DataGridView();
            dgv.Left = 10;
            dgv.Top = 50;
            dgv.Width = 850;
            dgv.Height = 200;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;

            dgv.Columns.Add("EST", "Producto");

            foreach (Objetivo obj in objetivos)
            {
                dgv.Columns.Add("OBJ_" + obj.Id, obj.Nombre);
            }

            foreach (DataGridViewRow fila in ObtenerFilasValidas())
            {
                int estrategia = Convert.ToInt32(fila.Cells["Estrategia"].Value);
                int row = dgv.Rows.Add();
                dgv.Rows[row].Cells[0].Value = estrategia;

                int col = 1;
                foreach (Objetivo obj in objetivos)
                {
                    int er = 0;
                    if (erPorObjetivo.ContainsKey(obj.Id))
                    {
                        if (erPorObjetivo[obj.Id].ContainsKey(estrategia))
                        {
                            er = erPorObjetivo[obj.Id][estrategia];
                        }
                    }
                    dgv.Rows[row].Cells[col].Value = er;
                    col++;
                }
            }

            panel.Controls.Add(dgv);
            flowMatrices.Controls.Add(panel);

            string ruta = GuardarControlComoImagen(panel, "tabla_er_general");
            rutasTablasFinales.Add(ruta);
        }

        private void GenerarTablaDecision()
        {
            Panel panel = new Panel();
            panel.Width = 1300;
            panel.Height = 400;
            panel.BorderStyle = BorderStyle.FixedSingle;

            Label titulo = new Label();
            titulo.Text = "SELECCIONAR LA ESTRATEGIA OPTIMA";
            titulo.Font = new Font("Arial", 14, FontStyle.Bold);
            titulo.Left = 10;
            titulo.Top = 10;
            titulo.AutoSize = true;
            panel.Controls.Add(titulo);

            DataGridView dgv = new DataGridView();
            dgv.Left = 10;
            dgv.Top = 50;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv.Columns.Add("OBJ", "Obj");
            dgv.Columns["OBJ"].Width = 50;
            dgv.Columns.Add("IR", "I.R.");
            dgv.Columns["IR"].Width = 50;

            List<DataGridViewRow> filasValidas = ObtenerFilasValidas();

            foreach (DataGridViewRow fila in filasValidas)
            {
                int estrategia = Convert.ToInt32(fila.Cells["Estrategia"].Value);
                dgv.Columns.Add("ER_" + estrategia, estrategia + " ER");
                dgv.Columns.Add("EP_" + estrategia, estrategia + " EP");
            }

            Dictionary<int, int> sumas = new Dictionary<int, int>();

            foreach (Objetivo obj in objetivos)
            {
                int row = dgv.Rows.Add();
                int ir = erPorObjetivo[obj.Id].Values.Max();
                dgv.Rows[row].Cells[0].Value = obj.Id;
                dgv.Rows[row].Cells[1].Value = ir;

                int col = 2;
                foreach (DataGridViewRow fila in filasValidas)
                {
                    int estrategia = Convert.ToInt32(fila.Cells["Estrategia"].Value);
                    int er = 0;
                    if (erPorObjetivo[obj.Id].ContainsKey(estrategia))
                    {
                        er = erPorObjetivo[obj.Id][estrategia];
                    }
                    int ep = ir * er;
                    dgv.Rows[row].Cells[col].Value = er;
                    dgv.Rows[row].Cells[col + 1].Value = ep;

                    if (!sumas.ContainsKey(estrategia))
                    {
                        sumas[estrategia] = 0;
                    }
                    sumas[estrategia] += ep;
                    col += 2;
                }
            }

            int filaTotal = dgv.Rows.Add();
            dgv.Rows[filaTotal].Cells[0].Value = "Σ";

            int mayor = sumas.Values.Max();
            int mejor = sumas.First(x => x.Value == mayor).Key;

            int c = 3;
            foreach (var item in sumas)
            {
                dgv.Rows[filaTotal].Cells[c].Value = item.Value;
                if (item.Value == mayor)
                {
                    dgv.Rows[filaTotal].Cells[c].Style.ForeColor = Color.Red;
                }
                c += 2;
            }

            txtDecision.Text = "Después de realizar el análisis correspondiente llegamos a la conclusión de escoger la estrategia N° " + mejor;

            panel.Controls.Add(dgv);
            flowMatrices.Controls.Add(panel);

            string ruta = GuardarControlComoImagen(panel, "tabla_decision");
            rutasTablasFinales.Add(ruta);
        }

        private void GenerarMatriz(Objetivo obj,List<DataGridViewRow> filas,Panel panelMatriz,Panel panelER)
        {
            //-----------------------------------
            // CONFIGURACION
            //-----------------------------------
            panelER.AutoSize = true;
            panelER.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            int tamaño = 35;

            int y = 10;

            //-----------------------------------
            // ER
            //-----------------------------------

            Dictionary<int, int> er =new Dictionary<int, int>();

            //-----------------------------------
            // INICIALIZAR ER
            //-----------------------------------

            foreach (DataGridViewRow fila in filas)
            {
                int numero =
                    Convert.ToInt32(
                        fila.Cells["Estrategia"]
                        .Value);

                er[numero] = 0;
            }

            Dictionary<int, int> erActual =new Dictionary<int, int>();
            //-----------------------------------
            // MATRIZ
            //-----------------------------------

            for (int i = 0;
                i < filas.Count - 1;
                i++)
            {
                for (int j = i + 1;
                    j < filas.Count;
                    j++)
                {
                    //-----------------------------------
                    // DATOS
                    //-----------------------------------

                    int nombre1 =
                        Convert.ToInt32(
                        filas[i].Cells["Estrategia"]
                        .Value);

                    int nombre2 =
                        Convert.ToInt32(
                            filas[j].Cells["Estrategia"]
                            .Value);

                    int valor1 =
                        Convert.ToInt32(
                            filas[i].Cells[
                                "OBJ_" + obj.Id]
                                .Value);

                    int valor2 =
                        Convert.ToInt32(
                            filas[j].Cells[
                                "OBJ_" + obj.Id]
                                .Value);

                    //-----------------------------------
                    // CREAR CELDAS
                    //-----------------------------------

                    Label arriba =
     CrearCeldaMatriz(
         filas[i].Cells["Estrategia"].Value.ToString(),
         j * tamaño,
         y,
         tamaño);

                    Label abajo =
                        CrearCeldaMatriz(
                            filas[j].Cells["Estrategia"].Value.ToString(),
                            j * tamaño,
                            y + tamaño,
                            tamaño);

                    //-----------------------------------
                    // DECIDIR GANADOR
                    //-----------------------------------

                    bool ganaArriba = false;

                    //-----------------------------------
                    // MAYOR
                    //-----------------------------------

                    if (obj.Optimizacion ==
                        TipoOptimizacion.Mayor)
                    {
                        ganaArriba =
                            valor1 >= valor2;
                    }

                    //-----------------------------------
                    // MENOR
                    //-----------------------------------

                    else
                    {
                        ganaArriba =
                            valor1 <= valor2;
                    }

                    //-----------------------------------
                    // PINTAR
                    //-----------------------------------

                    if (ganaArriba)
                    {
                        arriba.BackColor =
                            Color.Red;

                        arriba.ForeColor =
                            Color.White;

                        er[nombre1]++;
                    }
                    else
                    {
                        abajo.BackColor =
                            Color.Red;

                        abajo.ForeColor =
                            Color.White;

                        er[nombre2]++;
                    }

                    //-----------------------------------
                    // AGREGAR
                    //-----------------------------------

                    panelMatriz.Controls
                        .Add(arriba);

                    panelMatriz.Controls
                        .Add(abajo);
                }

                //-----------------------------------
                // BAJAR
                //-----------------------------------

                y += tamaño * 2;
            }

            erPorObjetivo[obj.Id] = er;

            //-----------------------------------
            // TABLA ER
            //-----------------------------------

            int posY = 10;

            //-----------------------------------
            // TITULOS
            //-----------------------------------

            Label t1 =
                CrearLabelER(
                    "Estrategia",
                    10,
                    posY,
                    120,
                    true);

            Label t2 =
                CrearLabelER(
                    "ER",
                    140,
                    posY,
                    50,
                    true);

            panelER.Controls.Add(t1);

            panelER.Controls.Add(t2);

            posY += 30;

            //-----------------------------------
            // DATOS
            //-----------------------------------

            foreach (var item in er)
            {
                Label l1 =
                    CrearLabelER(
                        item.Key.ToString(),
                        10,
                        posY,
                        120,
                        false);

                Label l2 =
                    CrearLabelER(
                        item.Value.ToString(),
                        140,
                        posY,
                        50,
                        false);

                panelER.Controls.Add(l1);

                panelER.Controls.Add(l2);

                posY += 25;
            }
        }
        private Label CrearCeldaMatriz(
    string texto,
    int x,
    int y,
    int tamaño)
        {
            Label lbl =
                new Label();

            lbl.Text = texto;

            lbl.Left = x;

            lbl.Top = y;

            lbl.Width = tamaño;

            lbl.Height = tamaño;

            lbl.TextAlign =
                ContentAlignment.MiddleCenter;

            lbl.BorderStyle =
                BorderStyle.FixedSingle;

            lbl.BackColor =
                Color.White;

            return lbl;
        }
        private Label CrearLabelER(
    string texto,
    int x,
    int y,
    int ancho,
    bool titulo)
        {
            Label lbl =
                new Label();

            lbl.Text = texto;

            lbl.Left = x;

            lbl.Top = y;

            lbl.Width = ancho;

            lbl.Height = 25;

            lbl.TextAlign =
                ContentAlignment.MiddleCenter;

            lbl.BorderStyle =
                BorderStyle.FixedSingle;

            if (titulo)
            {
                lbl.Font =
                    new Font(
                        "Arial",
                        9,
                        FontStyle.Bold);
            }

            return lbl;
        }

        private string GuardarDataGridComoImagen(
    DataGridView dgv,
    string nombre)
        {
            //-----------------------------------
            // QUITAR SCROLL
            //-----------------------------------

            dgv.ClearSelection();

            //-----------------------------------
            // CALCULAR TAMAÑO REAL
            //-----------------------------------

            int ancho = 0;
            int alto = dgv.ColumnHeadersHeight;

            //-----------------------------------
            // SUMAR ANCHOS
            //-----------------------------------

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                ancho += col.Width;
            }

            //-----------------------------------
            // SUMAR ALTOS
            //-----------------------------------

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (!fila.IsNewRow)
                {
                    alto += fila.Height;
                }
            }

            //-----------------------------------
            // MARGEN
            //-----------------------------------

            ancho += 20;
            alto += 20;

            //-----------------------------------
            // GUARDAR TAMAÑO ORIGINAL
            //-----------------------------------

            int anchoOriginal = dgv.Width;
            int altoOriginal = dgv.Height;

            //-----------------------------------
            // AJUSTAR DGV
            //-----------------------------------

            dgv.Width = ancho;
            dgv.Height = alto;

            //-----------------------------------
            // CREAR BITMAP
            //-----------------------------------

            Bitmap bmp =
                new Bitmap(ancho, alto);

            //-----------------------------------
            // FONDO BLANCO
            //-----------------------------------

            using (Graphics g =
                Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }

            //-----------------------------------
            // DIBUJAR DGV
            //-----------------------------------

            dgv.DrawToBitmap(
                bmp,
                new Rectangle(
                    0,
                    0,
                    ancho,
                    alto));

            //-----------------------------------
            // RESTAURAR TAMAÑO
            //-----------------------------------

            dgv.Width = anchoOriginal;
            dgv.Height = altoOriginal;

            //-----------------------------------
            // CARPETA
            //-----------------------------------

            string carpeta =
                Application.StartupPath +
                "\\Temp";

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            //-----------------------------------
            // RUTA
            //-----------------------------------

            string ruta =
                carpeta +
                "\\" +
                nombre +
                ".png";

            //-----------------------------------
            // GUARDAR
            //-----------------------------------

            bmp.Save(
                ruta,
                System.Drawing.Imaging.ImageFormat.Png);

            bmp.Dispose();

            return ruta;
        }

        private string GuardarControlComoImagen(
    Control control,
    string nombre)
        {
            //-----------------------------------
            // BITMAP
            //-----------------------------------

            Bitmap bmp =
                new Bitmap(
                    control.Width,
                    control.Height);

            control.DrawToBitmap(
                bmp,
                new Rectangle(
                    0,
                    0,
                    control.Width,
                    control.Height));

            //-----------------------------------
            // CARPETA
            //-----------------------------------

            string carpeta =
                Application.StartupPath +
                "\\Temp";

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(
                    carpeta);
            }

            //-----------------------------------
            // RUTA
            //-----------------------------------

            string ruta =
                carpeta +
                "\\" +
                nombre +
                ".png";

            bmp.Save(ruta);

            return ruta;
        }

        private List<string> GuardarPanelesFlow()
        {
            List<string> rutas =
                new List<string>();

            string carpeta =
                Application.StartupPath +
                "\\Temp";

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(
                    carpeta);
            }

            int contador = 1;

            foreach (Control control
                in flowMatrices.Controls)
            {
                Bitmap bmp =
                    new Bitmap(
                        control.Width,
                        control.Height);

                control.DrawToBitmap(
                    bmp,
                    new Rectangle(
                        0,
                        0,
                        control.Width,
                        control.Height));

                string ruta =
                    carpeta +
                    "\\panel_" +
                    contador +
                    ".png";

                bmp.Save(ruta);

                rutas.Add(ruta);

                contador++;
            }

            return rutas;
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            flowMatrices.Controls.Clear();
            imagenesMatrices.Clear();
            rutasTablasFinales.Clear();

            List<DataGridViewRow> filas = ObtenerFilasValidas();

            // Crear matriz y tabla ER por cada objetivo (separados)
            foreach (Objetivo obj in objetivos)
            {
                CrearMatrizEstrategia(obj, filas);
            }

            // Generar tabla general de ER
            GenerarTablaERGeneral();

            // Generar tabla de decisión
            GenerarTablaDecision();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            //-----------------------------------
            // TABLA ESTRATEGIAS
            //-----------------------------------

            string rutaTabla =
                GuardarDataGridComoImagen(
                    dgvEstrategias,
                    "tabla_estrategias");

            ReporteDecisionesManager
                .GuardarTablaEstrategias(
                    rutaTabla);

            //-----------------------------------
            // GUARDAR MATRICES
            //-----------------------------------

            ReporteDecisionesManager
    .GuardarMatricesSeparadas(
        imagenesMatrices);

            //-----------------------------------
            // AGREGAR TABLAS FINALES
            //-----------------------------------

            foreach (string ruta in rutasTablasFinales)
            {
                if (File.Exists(ruta))
                {
                    ReporteDecisionesManager
                        .RutasMatrices
                        .Add(ruta);
                }
            }

            //-----------------------------------
            // GUARDAR DECISION
            //-----------------------------------

            ReporteDecisionesManager
                .GuardarDecisionEstrategica(
                    txtDecision.Text);

            //-----------------------------------
            // GENERAR PDF
            //-----------------------------------

            ReporteDecisionesManager
                .GuardarReporte();

            //-----------------------------------
            // ABRIR PDF
            //-----------------------------------

            System.Diagnostics.Process.Start(
                ReporteDecisionesManager
                .ObtenerRutaArchivo());
        }
    }
}
