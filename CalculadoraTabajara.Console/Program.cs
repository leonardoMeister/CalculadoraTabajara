﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.AppConsole
{
    class Program
    {
        public static string Option { get; private set; }

        static void Main(string[] args)
        {

            while (true)
            {
                string option = Menu();
                if (option == "s") break;

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
