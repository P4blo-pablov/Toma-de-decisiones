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
    public partial class carga : Form
    {
        public carga()
        {
            InitializeComponent();
            this.ShowInTaskbar = true;

            // Cargar el icono
            string rutaIcono = Application.StartupPath + "\\img\\icono.png";
            if (File.Exists(rutaIcono))
            {
                this.Icon = new Icon(rutaIcono);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.Close();
        }
    }
}
