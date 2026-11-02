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
    public partial class Def_objetivos : Form
    {
        //-----------------------------------------
        // LISTAS GLOBALES
        //-----------------------------------------

        private List<Objetivo> objetivos =
            new List<Objetivo>();

        private List<Label> celdasMatriz =
            new List<Label>();


        //-----------------------------------------
        // CONSTRUCTOR
        //-----------------------------------------

        private Objetivo objetivoEditando = null;
        public Def_objetivos()
        {

            InitializeComponent();

            ConfigurarCombobox();

            ConfigurarControles();
        }


        //-----------------------------------------
        // CONFIGURAR CONTROLES
        //-----------------------------------------

        private void ConfigurarControles()
        {
            //-------------------------------------
            // PANELES
            //-------------------------------------

            panelMatriz.AutoScroll = true;

            panelResultados.AutoScroll = true;

            //-------------------------------------
            // INICIO
            //-------------------------------------

            txtValor.Enabled = false;

            dgvValor.Enabled = false;

            //-------------------------------------
            // DATAGRIDVIEW
            //-------------------------------------

            dgvValor.Columns.Clear();

            dgvValor.AllowUserToAddRows = true;

            dgvValor.RowHeadersVisible = false;

            dgvValor.Columns.Add(
                "Codigo",
                "Valor");

            dgvValor.Columns.Add(
                "Descripcion",
                "Descripción");

            dgvValor.Columns[0].Width = 50;

            dgvValor.Columns[1].Width = 100;

            dgvValor.Columns[0].ValueType = typeof(int);

            dgvValor.Columns[0].DefaultCellStyle.NullValue = null;

            dgvValor.DefaultCellStyle.NullValue = null;
        }


        //-----------------------------------------
        // CONFIGURAR COMBOBOX
        //-----------------------------------------

        private void ConfigurarCombobox()
        {
            //-------------------------------------
            // LIMPIAR
            //-------------------------------------

            cmbPrioridad.Items.Clear();

            cmbTipo.Items.Clear();

            cmbOptimo.Items.Clear();

            //-------------------------------------
            // PRIORIDAD
            //-------------------------------------

            cmbPrioridad.Items.Add(
                TipoPrioridad.Obligatorio);

            cmbPrioridad.Items.Add(
                TipoPrioridad.Deseado);

            //-------------------------------------
            // TIPO
            //-------------------------------------

            cmbTipo.Items.Add(
                TipoObjetivo.Cuantitativo);

            cmbTipo.Items.Add(
                TipoObjetivo.Cualitativo);

            //-------------------------------------
            // OPTIMIZACION
            //-------------------------------------

            cmbOptimo.Items.Add(
                TipoOptimizacion.Mayor);

            cmbOptimo.Items.Add(
                TipoOptimizacion.Menor);

            //-------------------------------------
            // VACIOS
            //-------------------------------------

            cmbPrioridad.SelectedIndex = -1;

            cmbTipo.SelectedIndex = -1;

            cmbOptimo.SelectedIndex = -1;

            //-------------------------------------
            // ESTILO
            //-------------------------------------

            cmbPrioridad.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbTipo.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbOptimo.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        //-----------------------------------------
        // CAMBIO DE TIPO
        //-----------------------------------------

        private void cmbTipo_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            //-------------------------------------
            // SIN SELECCION
            //-------------------------------------

            if (cmbTipo.SelectedIndex == -1)
                return;

            //-------------------------------------
            // TIPO
            //------------------------------------

            //-------------------------------------
            // CUANTITATIVO
            //-------------------------------------

            if (cmbTipo.SelectedIndex == 0)
            {
                txtValor.Enabled = true;

                dgvValor.Enabled = false;

                dgvValor.Rows.Clear();
            }

            //-------------------------------------
            // CUALITATIVO
            //-------------------------------------

            else
            {
                txtValor.Enabled = false;

                txtValor.Clear();

                dgvValor.Enabled = true;
            }
        }

        //-----------------------------------------
        // VALIDAR
        //-----------------------------------------

        private bool ValidarFormulario()
        {
            //-------------------------------------
            // NOMBRE
            //-------------------------------------

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese un nombre");

                return false;
            }

            //-------------------------------------
            // PRIORIDAD
            //-------------------------------------

            if (cmbPrioridad.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione prioridad");

                return false;
            }

            //-------------------------------------
            // TIPO
            //-------------------------------------

            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione tipo");

                return false;
            }

            //-------------------------------------
            // OPTIMO
            //-------------------------------------

            if (cmbOptimo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione optimización");

                return false;
            }

            //-------------------------------------
            // CUANTITATIVO
            //-------------------------------------

            if (cmbTipo.Text ==
                "Cuantitativo")
            {
                int numero;

                if (!int.TryParse(
                    txtValor.Text,
                    out numero))
                {
                    MessageBox.Show(
                        "Ingrese un valor numérico");

                    return false;
                }
            }

            return true;
        }


        //-----------------------------------------
        // MOSTRAR OBJETIVO
        //-----------------------------------------

        private void MostrarObjetivo(
            Objetivo obj)
        {
            string texto =
                "[" + obj.Id + "] " +
                obj.Nombre +
                " | " +
                obj.Optimizacion +
                " | ";

            //-------------------------------------
            // CUANTITATIVO
            //-------------------------------------

            if (obj.Tipo ==
                TipoObjetivo.Cuantitativo)
            {
                texto +=
                    obj.ValoresCualitativos[0]
                    .Codigo;
            }

            //-------------------------------------
            // CUALITATIVO
            //-------------------------------------

            else
            {
                foreach (ValorCualitativo valor
                    in obj.ValoresCualitativos)
                {
                    texto +=
                        "( " +
                        valor.Codigo +
                        " )" +
                        valor.Descripcion;
                }
            }

            lstbObjetivos.Items.Add(texto);
        }


        //-----------------------------------------
        // LIMPIAR
        //-----------------------------------------

        private void LimpiarFormulario()
        {
            txtNombre.Clear();

            txtValor.Clear();

            dgvValor.Rows.Clear();

            cmbPrioridad.SelectedIndex = -1;

            cmbTipo.SelectedIndex = -1;

            cmbOptimo.SelectedIndex = -1;

            txtValor.Enabled = false;

            dgvValor.Enabled = false;

            txtNombre.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ActualizarListBox()
        {
            //-------------------------------------
            // LIMPIAR
            //-------------------------------------

            lstbObjetivos.Items.Clear();

            //-------------------------------------
            // RECORRER
            //-------------------------------------

            foreach (Objetivo obj
                in objetivos)
            {
                MostrarObjetivo(obj);
            }
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //-------------------------------------
            // VALIDAR
            //-------------------------------------

            if (!ValidarFormulario())
                return;

            //-------------------------------------
            // CREAR OBJETIVO
            //-------------------------------------

            Objetivo obj;

            if (objetivoEditando == null)
            {
                //---------------------------------
                // NUEVO
                //---------------------------------

                obj = new Objetivo();

                obj.Id =
                    objetivos.Count + 1;
            }
            else
            {
                //---------------------------------
                // EDITAR
                //---------------------------------

                obj = objetivoEditando;

                obj.ValoresCualitativos.Clear();
            }

            //-------------------------------------
            // DATOS BASICOS
            //-------------------------------------

            obj.Nombre =
                txtNombre.Text.Trim();

            obj.Prioridad =
                (TipoPrioridad)
                cmbPrioridad.SelectedItem;

            obj.Tipo =
                (TipoObjetivo)
                cmbTipo.SelectedItem;

            obj.Optimizacion =
                (TipoOptimizacion)
                cmbOptimo.SelectedItem;

            //-------------------------------------
            // CUANTITATIVO
            //-------------------------------------

            if (obj.Tipo ==
                TipoObjetivo.Cuantitativo)
            {
                ValorCualitativo valor =
                    new ValorCualitativo();

                valor.Codigo =
                    Convert.ToInt32(
                        txtValor.Text);

                valor.Descripcion = "";

                obj.ValoresCualitativos
                    .Add(valor);
            }

            //-------------------------------------
            // CUALITATIVO
            //-------------------------------------

            else
            {
                foreach (DataGridViewRow fila
                    in dgvValor.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    if (fila.Cells[0].Value == null)
                        continue;

                    ValorCualitativo valor =
                        new ValorCualitativo();

                    valor.Codigo =
                        Convert.ToInt32(
                            fila.Cells[0].Value);

                    valor.Descripcion =
                        fila.Cells[1].Value
                        ?.ToString();

                    obj.ValoresCualitativos
                        .Add(valor);
                }
            }

            //-------------------------------------
            // GUARDAR
            //-------------------------------------

            if (objetivoEditando == null)
            {
                objetivos.Add(obj);
            }

            //-------------------------------------
            // MOSTRAR
            //-------------------------------------

            MostrarObjetivo(obj);
            ActualizarListBox();

            //-------------------------------------
            // LIMPIAR
            //-------------------------------------

            LimpiarFormulario();
            objetivoEditando = null;
        }

        //-----------------------------------------
        // CREAR CELDA
        //-----------------------------------------

        private Label CrearCelda(
            string texto,
            int x,
            int y,
            int tamaño)
        {
            Label lbl =
                new Label();

            lbl.Width =
                tamaño;

            lbl.Height =
                tamaño;

            lbl.Left =
                x;

            lbl.Top =
                y;

            lbl.Text =
                texto;

            lbl.TextAlign =
                ContentAlignment.MiddleCenter;

            lbl.BorderStyle =
                BorderStyle.FixedSingle;

            lbl.BackColor =
                Color.White;

            lbl.ForeColor =
                Color.Black;

            lbl.Font =
                new Font(
                    "Arial",
                    12,
                    FontStyle.Bold);

            //-------------------------------------
            // EVENTO CLICK
            //-------------------------------------

            lbl.Click +=
                CambiarColorCelda;

            //-------------------------------------
            // GUARDAR
            //-------------------------------------

            celdasMatriz.Add(lbl);

            return lbl;
        }


        //-----------------------------------------
        // CAMBIAR COLOR CELDA
        //-----------------------------------------

        private void CambiarColorCelda(
            object sender,
            EventArgs e)
        {
            Label lbl =
                (Label)sender;

            bool rojo =
                lbl.BackColor ==
                Color.Red;

            lbl.BackColor =
                rojo
                ? Color.White
                : Color.Red;

            lbl.ForeColor =
                rojo
                ? Color.Black
                : Color.White;
        }


        //-----------------------------------------
        // CALCULAR IR
        //-----------------------------------------

        private int CalcularIR(
            int idObjetivo)
        {
            int contador = 0;

            foreach (Label lbl
                in celdasMatriz)
            {
                if (lbl.BackColor ==
                    Color.Red
                    &&
                    lbl.Text ==
                    idObjetivo.ToString())
                {
                    contador++;
                }
            }

            return contador;
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            //-------------------------------------
            // VALIDAR
            //-------------------------------------

            if (objetivos.Count < 2)
            {
                MessageBox.Show(
                    "Debe agregar mínimo 2 objetivos");

                return;
            }

            //-------------------------------------
            // LIMPIAR
            //-------------------------------------

            panelMatriz.Controls.Clear();

            celdasMatriz.Clear();

            //-------------------------------------
            // CONFIGURACION
            //-------------------------------------

            int n =
                objetivos.Count;

            int tamaño =
                30;

            int y = 20;

            //-------------------------------------
            // GENERAR MATRIZ
            //-------------------------------------

            for (int fila = 0;
                fila < n - 1;
                fila++)
            {
                int cantidad =
                    n - fila - 1;

                //---------------------------------
                // FILA SUPERIOR
                //---------------------------------

                for (int col = 0;
                    col < cantidad;
                    col++)
                {
                    Label superior =
                        CrearCelda(

                            objetivos[fila]
                            .Id
                            .ToString(),

                            (fila + col)
                            * tamaño,

                            y,

                            tamaño);

                    panelMatriz.Controls
                        .Add(superior);
                }

                //---------------------------------
                // FILA INFERIOR
                //---------------------------------

                for (int col = 0;
                    col < cantidad;
                    col++)
                {
                    Label inferior =
                        CrearCelda(

                            objetivos[
                                fila + col + 1]
                                .Id
                                .ToString(),

                            (fila + col)
                            * tamaño,

                            y + tamaño,

                            tamaño);

                    panelMatriz.Controls
                        .Add(inferior);
                }

                //---------------------------------
                // BAJAR
                //---------------------------------

                y += tamaño * 2;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //-------------------------------------
            // LIMPIAR
            //-------------------------------------

            panelResultados.Controls.Clear();

            //-------------------------------------
            // TITULOS
            //-------------------------------------

            CrearResultado(
                "Objetivo",
                20,
                20,
                90,
                true);

            CrearResultado(
                "I.R.",
                140,
                20,
                30,
                true);

            //-------------------------------------
            // FILAS
            //-------------------------------------

            int y = 60;

            foreach (Objetivo obj
                in objetivos)
            {
                int ir =
                    CalcularIR(obj.Id);

                CrearResultado(
                    obj.Nombre,
                    20,
                    y,
                    90,
                    false);

                CrearResultado(
                    ir.ToString(),
                    140,
                    y,
                    30,
                    false);

                y += 30;
            }
        }


        //-----------------------------------------
        // CREAR RESULTADO
        //-----------------------------------------

        private void CrearResultado(string texto, int x, int y, int ancho, bool titulo)
        {
            Label lbl =
                new Label();

            lbl.Text =
                texto;

            lbl.Left =
                x;

            lbl.Top =
                y;

            lbl.Width =
                ancho;

            lbl.Height =
                25;

            lbl.TextAlign =
                ContentAlignment.MiddleCenter;

            lbl.BorderStyle =
                BorderStyle.FixedSingle;

            if (titulo)
            {
                lbl.Font =
                    new Font(
                        "Arial",
                        10,
                        FontStyle.Bold);
            }

            panelResultados.Controls
                .Add(lbl);
        }

        private string GuardarPanelResultadosComoImagen(Panel panel, string nombre)
        {
            //-------------------------------------
            // CALCULAR TAMAÑO SEGÚN OBJETIVOS
            //-------------------------------------

            int margen = 20;
            int anchoColumna1 = 100;  // Ancho para nombre del objetivo
            int anchoColumna2 = 50;   // Ancho para I.R.
            int altoFila = 30;

            int anchoReal = anchoColumna1 + anchoColumna2 + (margen * 2) + 10;
            int altoReal = (objetivos.Count + 1) * altoFila + (margen * 2) + 10;

            //-------------------------------------
            // CREAR IMAGEN
            //-------------------------------------

            Bitmap bmp = new Bitmap(anchoReal, altoReal);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Fondo blanco
                g.Clear(Color.White);

                // Configurar calidad
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                int xInicio = margen;
                int yInicio = margen;

                using (Pen pen = new Pen(Color.Black, 1))
                using (Font fontTitulo = new Font("Arial", 10, FontStyle.Bold))
                using (Font fontNormal = new Font("Arial", 9, FontStyle.Regular))
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    // =====================================
                    // DIBUJAR ENCABEZADOS
                    // =====================================

                    // Encabezado "Objetivo"
                    Rectangle rectObjetivo = new Rectangle(xInicio, yInicio, anchoColumna1, altoFila);
                    g.FillRectangle(Brushes.LightGray, rectObjetivo);
                    g.DrawRectangle(pen, rectObjetivo);
                    g.DrawString("Objetivo", fontTitulo, Brushes.Black, rectObjetivo, sf);

                    // Encabezado "I.R."
                    Rectangle rectIR = new Rectangle(xInicio + anchoColumna1, yInicio, anchoColumna2, altoFila);
                    g.FillRectangle(Brushes.LightGray, rectIR);
                    g.DrawRectangle(pen, rectIR);
                    g.DrawString("I.R.", fontTitulo, Brushes.Black, rectIR, sf);

                    // =====================================
                    // DIBUJAR FILAS DE DATOS
                    // =====================================

                    int y = yInicio + altoFila;

                    foreach (Objetivo obj in objetivos)
                    {
                        int ir = CalcularIR(obj.Id);

                        // Celda del nombre del objetivo
                        Rectangle rectNombre = new Rectangle(xInicio, y, anchoColumna1, altoFila);
                        g.DrawRectangle(pen, rectNombre);
                        g.DrawString(obj.Nombre, fontNormal, Brushes.Black, rectNombre, sf);

                        // Celda del valor I.R.
                        Rectangle rectValorIR = new Rectangle(xInicio + anchoColumna1, y, anchoColumna2, altoFila);
                        g.DrawRectangle(pen, rectValorIR);
                        g.DrawString(ir.ToString(), fontNormal, Brushes.Black, rectValorIR, sf);

                        y += altoFila;
                    }
                }
            }

            //-------------------------------------
            // GUARDAR IMAGEN
            //-------------------------------------

            string carpeta = Application.StartupPath + "\\Temp";

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string ruta = carpeta + "\\" + nombre + ".png";
            bmp.Save(ruta, System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();

            return ruta;
        }

        private string GuardarPanelComoImagen(Panel panel, string nombre)
        {
            //-------------------------------------
            // CALCULAR TAMAÑO BASADO EN LA ESTRUCTURA DE LA MATRIZ
            //-------------------------------------

            int tamaño = 35;  // Mismo tamaño que en btnGenerarMatriz
            int espacioEntreCeldas = 2;
            int celdaTotal = tamaño + espacioEntreCeldas;
            int margen = 10;

            int n = objetivos.Count;

            // Calcular número total de comparaciones
            int totalComparaciones = (n * (n - 1)) / 2;

            // Calcular dimensiones necesarias
            int ancho = margen + (totalComparaciones * celdaTotal) + margen;
            int alto = margen + ((n - 1) * celdaTotal) + (celdaTotal * 2) + margen;

            //-------------------------------------
            // CREAR BITMAP
            //-------------------------------------

            Bitmap bmp = new Bitmap(ancho, alto*2);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Configurar calidad
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                // Fondo blanco
                g.Clear(Color.White);

                // Dibujar cada celda manualmente respetando sus colores
                foreach (Label lbl in celdasMatriz)
                {
                    if (lbl == null) continue;

                    Rectangle rect = new Rectangle(
                        lbl.Left,
                        lbl.Top,
                        lbl.Width,
                        lbl.Height);

                    // Dibujar fondo con el color actual de la celda
                    using (SolidBrush brush = new SolidBrush(lbl.BackColor))
                    {
                        g.FillRectangle(brush, rect);
                    }

                    // Dibujar borde
                    using (Pen pen = new Pen(Color.Black, 1))
                    {
                        g.DrawRectangle(pen, rect);
                    }

                    // Dibujar texto
                    using (SolidBrush brushTexto = new SolidBrush(lbl.ForeColor))
                    {
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        g.DrawString(
                            lbl.Text,
                            lbl.Font,
                            brushTexto,
                            rect,
                            sf);
                    }
                }
            }

            //-------------------------------------
            // GUARDAR IMAGEN
            //-------------------------------------

            string carpeta = Application.StartupPath + "\\Temp";
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string ruta = carpeta + "\\" + nombre + ".png";
            bmp.Save(ruta, System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();

            return ruta;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //-------------------------------------
            // GUARDAR OBJETIVOS
            //-------------------------------------

            ReporteDecisionesManager.GuardarObjetivos(objetivos);

            //-------------------------------------
            // CAPTURAR PANELES - USANDO LOS NUEVOS MÉTODOS
            //-------------------------------------

            // Usar el nuevo método para la matriz
            string rutaMatriz = GuardarPanelComoImagen(panelMatriz, "matriz");

            // Usar el nuevo método para los resultados
            string rutaResultados = GuardarPanelResultadosComoImagen(panelResultados, "resultados");

            //-------------------------------------
            // GUARDAR IMAGENES
            //-------------------------------------

            ReporteDecisionesManager.GuardarImagenesIR(rutaMatriz, rutaResultados);

            //-------------------------------------
            // GENERAR PDF
            //-------------------------------------

            ReporteDecisionesManager.GuardarReporte();
        }

        private void lstbObjetivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-------------------------------------
            // VALIDAR
            //-------------------------------------

            if (lstbObjetivos.SelectedIndex == -1)
                return;

            //-------------------------------------
            // OBTENER OBJETO
            //-------------------------------------

            objetivoEditando =
                objetivos[
                    lstbObjetivos.SelectedIndex];

            //-------------------------------------
            // LIMPIAR
            //-------------------------------------

            dgvValor.Rows.Clear();

            //-------------------------------------
            // DATOS BASICOS
            //-------------------------------------

            txtNombre.Text =
                objetivoEditando.Nombre;

            cmbPrioridad.SelectedItem =
                objetivoEditando.Prioridad;

            cmbTipo.SelectedItem =
                objetivoEditando.Tipo;

            cmbOptimo.SelectedItem =
                objetivoEditando.Optimizacion;

            //-------------------------------------
            // CUANTITATIVO
            //-------------------------------------

            if (objetivoEditando.Tipo ==
                TipoObjetivo.Cuantitativo)
            {
                txtValor.Enabled = true;

                dgvValor.Enabled = false;

                txtValor.Text =
                    objetivoEditando
                    .ValoresCualitativos[0]
                    .Codigo
                    .ToString();
            }

            //-------------------------------------
            // CUALITATIVO
            //-------------------------------------

            else
            {
                txtValor.Enabled = false;

                dgvValor.Enabled = true;

                txtValor.Clear();

                foreach (ValorCualitativo valor
                    in objetivoEditando
                    .ValoresCualitativos)
                {
                    dgvValor.Rows.Add(
                        valor.Codigo,
                        valor.Descripcion);
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //-------------------------------------
            // GUARDAR OBJETIVOS GLOBALMENTE
            //-------------------------------------

            ReporteDecisionesManager
                .GuardarObjetivos(
                    objetivos);

            //-------------------------------------
            // ABRIR FORMULARIO
            //-------------------------------------

            ingreso_Estrategias frm =
                new ingreso_Estrategias(
                    objetivos);

            frm.ShowDialog();

            this.Close();
        }
    }

}
