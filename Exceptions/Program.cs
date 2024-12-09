namespace Arrays{
    
    class Program {

        static void Main() {

            var teste = new int[3];

            try {
                for (int index = 0; index < 10; index++) {

                    Console.WriteLine(teste[index]);
                }
            }
            catch (Exception ex) {

                Console.WriteLine(ex.ToString());
                Console.WriteLine("Algo deu errado!");
            }
            finally {
                Console.WriteLine("");
            }
        }
    }
}