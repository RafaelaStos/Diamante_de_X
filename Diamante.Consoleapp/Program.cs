using System;

namespace Diamante.Consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, espaco, asterisco = 1;

            Console.WriteLine("Digite um numero impar: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 != 0)
            {
                espaco = (num - 1) / 2;
                //parte de cima
                for (int i = espaco; i > 0; i--)
                {
             
                    for (int j = 1; j <= i; j++)
                    {

                        Console.Write(" ");

                    }
                    for (int h = 1; h <= asterisco; h++)
                    {
                        
                        Console.Write("X");
                    }

                    asterisco += 2;
                    Console.WriteLine("");
                }
                //PARTE DO MEIO

                for (int h = 0; h <asterisco; h++)
                {

                    Console.Write("X");
                    
                }


                //parte de baixo
                Console.WriteLine();
                asterisco = num - 2;
                for (int i = espaco; i > 0; i--)
                {
                    
                    for (int j = i; j <= espaco; j++)
                    {

                        Console.Write(" ");

                    }
                    for (int h = 1; h <= asterisco; h++)
                    {

                        Console.Write("X");
                    }
                    asterisco-=2;
                    Console.WriteLine("");
                }

            }
            Console.ReadLine();

        
        }

    }

}


