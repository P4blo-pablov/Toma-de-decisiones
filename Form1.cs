using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toma_de_decisiones
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

            //---------------------------------
            // LIMPIAR DATOS ANTERIORES
            //---------------------------------

            ReporteDecisionesManager
                .LimpiarReporte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                dgvIntegrantes.Rows.Add(txtNombre.Text);
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Campo vacío",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar ruta del archivo (solo la primera vez)
                if (!ReporteDecisionesManager.HayContenidoEnReporte())
                {
                    if (!ReporteDecisionesManager.SeleccionarRutaArchivo())
                    {
                        return;
                    }
                }

                // Guardar los integrantes del DataGridView
                List<string> integrantes = new List<string>();
                foreach (DataGridViewRow row in dgvIntegrantes.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value != null)
                    {
                        string nombre = row.Cells[0].Value.ToString();
                        if (!string.IsNullOrWhiteSpace(nombre))
                        {
                            integrantes.Add(nombre);
                        }
                    }
                }

                //---------------------------------
                // GUARDAR INTEGRANTES
                //---------------------------------

                ReporteDecisionesManager.GuardarIntegrantes(integrantes);

                //---------------------------------
                // GUARDAR PROPOSITO
                //---------------------------------

                ReporteDecisionesManager.GuardarProposito(txtProposito.Text.Trim());

                MessageBox.Show("Integrantes y Propósito guardados correctamente",
                              "REALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el siguiente formulario
                Def_objetivos frmObjetivos = new Def_objetivos();
                frmObjetivos.ShowDialog();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "REALIZADO",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
