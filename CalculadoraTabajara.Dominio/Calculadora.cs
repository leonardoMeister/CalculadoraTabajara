using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.Dominio
{
    public class Calculadora
    {
        List<string> listaLog;

        public Calculadora()
        {
            listaLog = new List<string>();
        }

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
            double resultado = primeiro * segundo;
            SalvarLog($"{primeiro} x {segundo} = {resultado}");
            return resultado;
        }
        public double Dividir(double primeiro, double segundo)
        {
            double resultado = primeiro / segundo;
            SalvarLog($"{primeiro} / {segundo} = {resultado}");
            return resultado;
        }

        public void SalvarLog(string log)
        {

        }

    }
}
