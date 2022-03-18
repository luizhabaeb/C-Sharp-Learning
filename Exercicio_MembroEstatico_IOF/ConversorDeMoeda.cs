using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_MembroEstatico_IOF
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double DolarReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * (IOF / 100);
        }



    }
}
