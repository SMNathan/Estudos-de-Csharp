namespace EditorHtml {
    public static class Menu{
        public static void Show() {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
            
        }
        
        public static void DrawScreen() {

            TopDown();
            BackGround();
            TopDown();
        }

        public static void TopDown() {
            Console.Write("+");
            for (int i = 0; i <= 30; i++){

                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void BackGround() {
            for (int lines = 0; lines <=10; lines++) {

                Console.Write("|");

                for (int i = 0; i <= 30; i++){
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions() {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma Opção Abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir Arquivo");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option) {
            
            Console.SetCursorPosition(14,11);

            switch(option) {

                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: 
                {
                    Console.Clear();
                    Environment.Exit(0); break;
                }
                default: Show(); break;
            }
        }
    }
}