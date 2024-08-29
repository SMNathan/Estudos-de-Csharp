namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o número de segundos que deseja cronometrar:");
            int time = int.Parse(Console.ReadLine());
            Start(time);
        }

        static void Menu()
        {

        }

        static void Start(int time)
        {          
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
        }
    }
}