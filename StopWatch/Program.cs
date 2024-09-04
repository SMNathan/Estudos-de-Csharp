using System.Linq.Expressions;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string options  = Console.ReadLine().ToLower();

            char type = char.Parse(options.Substring(options.Length-1,1));
            int time = int.Parse(options.Substring(0,options.Length-1));

            if (time == 0)

                Environment.Exit('0');

            Start(time, type);            
        }

        static void Start(int time, char type)
        {          
            int currentTime = 0;

            if (type == 'm')
            {
                time *= 60;
            }

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}