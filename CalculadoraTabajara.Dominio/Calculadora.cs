using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.Dominio
{
    public class Calculadora
    {
        public double Somar(double primeiro, double segundo )
        {
            return primeiro + segundo;
        }
        public double Subrair(double primeiro, double segundo)
        {
            return primeiro - segundo;
        }
        public double Multiplicar(double primeiro, double segundo)
        {
            return primeiro * segundo;
        }
        public double Dividir(double primeiro, double segundo)
        {
            return primeiro / segundo;
        }
    }
}
