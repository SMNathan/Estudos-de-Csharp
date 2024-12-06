using System.Globalization;

namespace Datas {   

    class Program {
        static void Main() {
            
            Console.Clear();
            
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);
            
            var timeSpanNano = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanNano);


        }
    }
}