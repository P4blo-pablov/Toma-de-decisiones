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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.Load += Principal_Load;

            this.ShowInTaskbar = true;

            // Cargar el icono
            string rutaIcono = Application.StartupPath + "\\img\\icono_alpaca.png";
            if (File.Exists(rutaIcono))
            {
                this.Icon = new Icon(rutaIcono);
            }
        }

        private void Principal_Load(
            object sender,
            EventArgs e)
        {
            //---------------------------------
            // OCULTAR FORM PRINCIPAL
            //---------------------------------

            this.Hide();

            //---------------------------------
            // ABRIR PRIMER FORMULARIO
            //---------------------------------

            Registro frm =
                new Registro();

            frm.ShowDialog();

            //---------------------------------
            // CERRAR APP AL TERMINAR
            //---------------------------------

            Application.Exit();
        }
    }
}
