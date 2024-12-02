// namespace Heranca {
    
//     public class Carro {
//         protected readonly int VelocidadeMaxima;
//         private int VelocidadeAtual;

//         public Carro(int velocidadeMaxima) {
//             VelocidadeMaxima = velocidadeMaxima;
//         }

//         protected int AlterarVelocidade(int delta) {
//             int novaVelocidade = VelocidadeAtual + delta;

//             if (novaVelocidade < 0) {
//                 VelocidadeAtual = 0;
//             } else if (novaVelocidade > VelocidadeMaxima) {
//                 VelocidadeAtual = VelocidadeMaxima;
//             } else {
//                 VelocidadeAtual = novaVelocidade;
//             }

//             return VelocidadeAtual;
//         }

//         public virtual int Acelerar() {
//             return AlterarVelocidade(5);
//         }

//         public int Frear() {
//             return AlterarVelocidade(-5);
//         }

//     }   

//     public class Uno : Carro {
//         public Uno() : base(160) {}
//     }

//     public class Ferrari : Carro {
//         public Ferrari() : base(320) {}

//         public override int Acelerar() {
//             return AlterarVelocidade(15);
//         }

//         public new int Frear() {
//             return AlterarVelocidade(-15);
//         }
//     }

//     class Heranca {
//         public static void Main() {
//             Console.WriteLine("Uno...");
//             Uno carro1 = new Uno();
//             Console.WriteLine(carro1.Acelerar());
//             Console.WriteLine(carro1.Acelerar());
//             Console.WriteLine(carro1.Acelerar());
//             Console.WriteLine(carro1.Frear());
//             Console.WriteLine(carro1.Frear());
//             Console.WriteLine(carro1.Frear());

//             Console.WriteLine("Ferrari...");
//             Ferrari carro2 = new Ferrari();
//             Console.WriteLine(carro2.Acelerar());
//             Console.WriteLine(carro2.Acelerar());
//             Console.WriteLine(carro2.Acelerar());
//             Console.WriteLine(carro2.Frear());
//             Console.WriteLine(carro2.Frear());
//             Console.WriteLine(carro2.Frear());
//         }
//     }
// }

namespace ClasseThis {

    public class Animal {

        protected string Nome = "";

        public Animal(string nome) {
            Nome = nome;
        }

        public override string ToString() {
            return $"Nome do Animal é {Nome}";
        }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }

            public override string ToString()
            {
                return $"{Nome} tem {Altura}cm de altura!";
            }

        }
    public static void Main() {

        Animal Max = new Cachorro("Max");
        Cachorro Rex = new Cachorro("Rex", 40);

        Console.WriteLine(Max);
        Console.WriteLine(Rex);
    }

    }
}