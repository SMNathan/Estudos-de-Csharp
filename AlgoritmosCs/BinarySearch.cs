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
    }
}