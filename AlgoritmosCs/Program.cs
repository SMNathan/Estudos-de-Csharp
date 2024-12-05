using System.ComponentModel.DataAnnotations;

namespace Algoritmo{
    public class Program(){
        public static void Main() {
            int [] lista = {1, 7, 9, 11};
            Console.WriteLine(Algoritmos.BinarySearchRecursive(lista, 11, 0, lista.Length - 1));
        }
    }
}
