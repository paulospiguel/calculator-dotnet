using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Escola um opção para fazer: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("---------------------------");

            Console.WriteLine("Selecione uma opção: ");
            short option = short.Parse(Console.ReadLine());

            switch (option){
                case 1: Sum(); Menu(); break;
                case 2: Subtraction(); Menu(); break;
                case 3: Multiplication(); Menu(); break;
                case 4: Division(); Menu(); break;
                case 0: ExitSystem(); break;
                default: Menu(); break;
            }
        }
   
        static void Sum(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: "); 
            float v2 = float.Parse(Console.ReadLine());  

            float result = v1 + v2;    
            Console.WriteLine($"O resultado da soma é: {result}");
            // Console.WriteLine("O resultado da soma é: " + result);
            // Console.WriteLine("O resultado da soma é: " + (v1 + v2));
            // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            Console.ReadKey();
        }

        static void Subtraction(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {result}");
            Console.ReadKey();
        }
    
        static void Division(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;
            Console.WriteLine($"O resultado da divisão é : {result}");
            Console.ReadKey();
        }
   
        static void Multiplication(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {result}");
            Console.ReadKey();
        }
    
        static void ExitSystem(){
            Console.WriteLine("Obrigado por utilizar o sistema!");
            System.Environment.Exit(0);
        }
    
    }
}
