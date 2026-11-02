using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toma_de_decisiones
{
    public class MatrizComparacion
    {
        public Objetivo Objetivo { get; set; }

        public List<Estrategia> Estrategias
            = new List<Estrategia>();

        public List<ResultadoER> Resultados
            = new List<ResultadoER>();
    }
}
