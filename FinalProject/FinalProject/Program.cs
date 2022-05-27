using System;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            elevador.MostrarAndares();
        }
    }

    public class elevador
    {

        public static void MostrarAndares()
        {

            int AndarAtual = 0;


            Console.WriteLine(@"Qual andar deseja ir?
            1 - Piso
            2 - Lojas
            3 - Lanchonetes
            4 - Livrarias");

            int AndarEscolhido = int.Parse(Console.ReadLine());
            Console.Clear();


            if (AndarEscolhido <= 0 || AndarEscolhido >= 5)
            {
                Console.WriteLine("Numeros Invalidos");
                MostrarAndares();
            }
            else
            {
                if(AndarEscolhido > AndarAtual)
                {
                    for(int i = AndarAtual; i < AndarEscolhido; i++)
                    {
                        Console.WriteLine($"Você está no andar {i}");
                    }
                }
                MostrarAndares();
            }
        }
    }
}
