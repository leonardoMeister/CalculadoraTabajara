using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraTabajara.Dominio;

namespace CalculadoraTabajara.AppConsole
{
    class Program
    {
        public static string Option { get; private set; }
        Calculadora  calculadora = new Calculadora();

        static void Main(string[] args)
        {

            while (true)
            {
                string option = Menu();
                if (option == "s") break;

                switch (option)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":
                        Divisao();
                        break;
                    case "4":
                        Multiplicacao();
                        break;
                    default:
                        break;
                        //
                        //mais um teste
                        //teste de atualizacao de issue
                        //novo teste
                        //att de issue com #2
                }
            }

        }
        private static void PegarDoisValores(out double primeiro, out double segundo)
        {
            while (true)
            {
                Console.WriteLine("Informe o Primeiro valor");
                primeiro = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o segundo valor");
                segundo = Convert.ToDouble(Console.ReadLine());
                return;
            }
        }

        private static void Multiplicacao()
        {
            double primeiro, segundo;
            PegarDoisValores(out primeiro, out segundo);
            


        }

        private static void Divisao()
        {
            double primeiro, segundo;
            while (true)
            {
                PegarDoisValores(out primeiro, out segundo);

                if (segundo != 0) break;

                Console.Clear();
                Console.WriteLine("O segundo valor não pode ser 0.");
            }


        }

        public static string Menu()
        {
            Console.WriteLine("--------MENU CALCULADORA TABAJARA-------");
            Console.WriteLine("| 1 - Fazer calculo com Adição         |");
            Console.WriteLine("| 2 - Fazer calculo com Subtração      |");
            Console.WriteLine("| 3 - Fazer calculo com Divisão        |");
            Console.WriteLine("| 4 - Fazer calculo com Multiplicação  |");
            Console.WriteLine("| 5 - Fazer vizualizar Histórico       |");

            return Console.ReadLine();
        }

    }
}
