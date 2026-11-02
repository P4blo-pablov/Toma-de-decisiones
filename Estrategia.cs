using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toma_de_decisiones
{
    public class Estrategia
    {
        public string Nombre { get; set; }

        //-----------------------------------
        // VALORES POR OBJETIVO
        // key = id objetivo
        // value = valor
        //-----------------------------------

        public Dictionary<int, int> Valores =
            new Dictionary<int, int>();

        //-----------------------------------
        // SI CUMPLE O NO
        //-----------------------------------

        public bool EsValida = true;
    }
}
