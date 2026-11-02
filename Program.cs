using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Toma_de_decisiones
{
    public enum TipoPrioridad
    {
        Obligatorio,
        Deseado
    }
        public enum TipoObjetivo
        {
            Cuantitativo,
            Cualitativo
        }
  
        public enum TipoOptimizacion
        {
            Mayor,
            Menor
        }
    
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            carga splash = new carga();
            splash.Show();
            Application.DoEvents();

            Thread.Sleep(4000); 

            splash.Close();
            Application.Run(new Principal());
        }
    }
}
