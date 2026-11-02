using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toma_de_decisiones
{
    public class Objetivo
    {
        //--------------------------------
        // IDENTIFICADOR
        //--------------------------------

        public int Id { get; set; }

        //--------------------------------
        // 1, 2, 3, 4 
        //--------------------------------

        public string Nombre { get; set; }

        //--------------------------------
        // NOMBRE
        //--------------------------------

        public TipoPrioridad Prioridad
        { get; set; }

        //--------------------------------
        // OBLIGATORIO / DESEADO
        //--------------------------------

        public TipoObjetivo Tipo
        { get; set; }

        //--------------------------------
        // CUANTITATIVO 
        // CUALITATIVO
        //--------------------------------

        public TipoOptimizacion Optimizacion
        { get; set; }

        //--------------------------------
        // MAYOR O MENOR
        //--------------------------------

        public double ValorObjetivo
        { get; set; }

        //--------------------------------
        // VALORES CUALITATIVOS
        //--------------------------------

        public List<ValorCualitativo>
            ValoresCualitativos
        { get; set; }

        //--------------------------------
        // CONSTRUCTOR
        //--------------------------------

        public Objetivo()
        {
            ValoresCualitativos =
                new List<ValorCualitativo>();
        }

        public int IR { get; set; }
    }
}
