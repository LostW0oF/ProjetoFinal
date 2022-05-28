using System;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            elevador elevador = new elevador();
            elevador.MostrarAndares();
        }
    }

   class elevador
    {
        public int totalAndares = 5;
        public int andar = 0;
        public bool continuar = true;

        public void Menu()
        {

            do
            {
                MostrarAndares();
                int AndarEscolhido = int.Parse(Console.ReadLine());
                Console.Clear();
                andarAtual(AndarEscolhido);
            }
            while (continuar); 
        }

        public void MostrarAndares()
        {
            Console.WriteLine(@"Escolha o Andar de Destino:
                    0 - Estacionamento
                    1 - Piso
                    2 - Lojas
                    3 - Escritorios
                    4 - Cobertura
                    5 - Area de serviço
                    6 - Sair");
        }

        public void andarAtual(int Andar)
        {
            switch (Andar)
            {
                case 0:
                    Estacionamento();
                    break;
                case 1:
                    Piso();
                    break;
                case 2:
                    Lojas();
                    break;
                case 3:
                    Escritorio();
                    break;
                case 4:
                    Cobertura();
                    break;
                case 5:
                    servico();
                    break;
                case 6:
                    sair();
                    break;
                case 7:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Esse andar Não existe.");
                    break;
            }
        }

        public void Estacionamento()
        {
            if (andar < totalAndares )
            {
                Console.WriteLine($"Você subiu para o andar {andar}");
                andar++;
            }
            else if (andar > 0)
            {
                Console.WriteLine($"Você desceu para o andar {andar}");
            }
            else
            {
                Console.WriteLine("Andar Atingido");
            }
        }

        public void Piso()
        {
            Console.WriteLine($"Andar Atingido");
        }

        public void Lojas()
        {
            Console.WriteLine($"Andar Atingido");
        }

        public void Escritorio()
        {
            Console.WriteLine("Andar Atingido");
        }

        public void Cobertura()
        {
            Console.WriteLine("Andar Atingido");
        }

        public void servico()
        {
            Console.WriteLine("Andar Atingido");
        }

        public void sair()
        {
            Console.WriteLine("Saindo do Elevador");
        }
    }
}
