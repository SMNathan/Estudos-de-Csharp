using System.ComponentModel;

namespace Algoritmo {

    public class Algoritmos{

        public static int BinarySearch(int[] lista, int item) {
            int baixo = 0;
            int alto = lista.Length -1;

            while (baixo <= alto) {
                int meio = baixo + (alto - baixo) / 2;
                int chute = lista[meio];

                if (chute == item){
                    return meio;
                } 
                else if (chute < item) {
                    baixo = meio +1;
                }
                else {
                    alto = meio -1;
                }
            }
            return -1;
        }

        public static int? BinarySearchRecursive(int[] array, int valor, int indiceInicial, int indiceFinal) {

            if (indiceFinal < indiceInicial) {
                return null;
            } 

            int meio = (indiceFinal + indiceInicial) / 2;

            if (array[meio] == valor)
            {
                return meio;
            }

            if (valor < array[meio]) {
            return BinarySearchRecursive(array, valor, indiceInicial, meio);
            }
            return BinarySearchRecursive(array, valor, meio + 1, indiceFinal);            
        }

        public static void RegressivaRecursiva(int i) {
            Console.WriteLine(i + "...");
            if (i <= 1) {
                Thread.Sleep(1000);
                Console.WriteLine("GO!!");
                return;
            }
            Thread.Sleep(1000);
            RegressivaRecursiva(i -1);
        }

        public static int FatorialRecursivo(int x) {            
            if (x == 1) {
                return 1;
            } else {
            return x * FatorialRecursivo(x - 1);
            }
        }

        public static int SomaArrayRecursivo(int[] array, int indice = 0) {
            
            if (indice >= array.Length) {
                return 0;
            } 
                return array[indice] + SomaArrayRecursivo(array, indice + 1);
        }

        public static int MaiorNoArrayRecursivo(int[] array, int indiceInicial, int indiceFinal) {
            if (indiceInicial == indiceFinal) {
                return array[indiceInicial];
            }

            int meio = (indiceInicial + indiceFinal) / 2;

            int maiorEsquerda = MaiorNoArrayRecursivo(array, indiceInicial, meio);
            int maiorDireita = MaiorNoArrayRecursivo(array, meio + 1, indiceFinal);

            return Math.Max(maiorEsquerda, maiorDireita);
        }
    }
}