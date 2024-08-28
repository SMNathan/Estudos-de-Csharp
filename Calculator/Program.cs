using System;
using System.Diagnostics;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite a operação desejada:");
            Console.WriteLine("");
            Console.WriteLine("(+) Soma     (-) Subtração    (*) Multiplicação    (/) Divisão");
            Console.WriteLine("");
            Console.WriteLine("                     (p) Parar o Programa");
            Console.WriteLine("");

            char operacao = char.Parse(Console.ReadLine());

            switch (operacao)
            {
                case '+': Soma(); break;

                case '-': Subtracao(); break;

                case '*': Multiplicacao(); break;

                case '/': Divisao(); break;

                case 'p': System.Environment.Exit(0); break;

                default: Menu(); break;
            }

        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O Resultado da soma é:{v1 + v2}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O Resultado da subtração é:{v1 - v2}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O Resultado da multiplicação é:{v1 * v2}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O Resultado da divisão é:{v1 / v2}");
            Console.ReadKey();
            Menu();
        }
    }
}
