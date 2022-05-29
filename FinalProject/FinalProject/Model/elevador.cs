using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador_doc.Model
{
    class elevador
    {
        public int totalAndares = 5;
        public int andar = 0;
        public int capacidade = 0;
        public int capacidadeMax = 6;
        public bool continuar = true;

        public void Menu()
        {

            do
            {
                MostrarAndares();
                string AndarEscolhido = Console.ReadLine().ToUpper();
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
            Console.WriteLine(@"Digite E para entrar, A para subir até ao andar desejado e B para descer, S para sair e F para encerrar ");
        }

        public void andarAtual(string Andar)
        {
            switch (Andar)
            {
                case "E":
                    entrar();
                    break;
                case "A":
                    subir();
                    break;
                case "B":
                    descer();
                    break;
                case "S":
                    sair();
                    break;
                case "F":
                    Console.WriteLine(@"Saindo do elevador");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Esse andar Não existe.");
                    break;
            }
        }


        public void entrar()
        {
            if (capacidade < capacidadeMax)
            {
                Console.WriteLine(@"Uma pessoa entrou no elevador");
                capacidade++;
            }
            else
            {
                Console.WriteLine(@"Elevador está cheio. Não é possível entrar");
            }
        }

        public void subir()
        {
            if (andar < totalAndares)
            {
                Console.WriteLine("Você subiu um andar");
                andar++;
                if (andar == 1)
                {
                    Console.WriteLine("Você chegou ao Piso");
                }
                else if (andar == 2)
                {
                    Console.WriteLine("Você chegou as Lojas");
                }
                else if (andar == 3)
                {
                    Console.WriteLine("Você chegou aos Escritorios");
                }
                else if (andar == 4)
                {
                    Console.WriteLine("Você chegou a Cobertura");
                }
                else if (andar == 5)
                {
                    Console.WriteLine("Você chegou a Area de Servico");
                }
            }
            else
            {
                Console.WriteLine(@"Você chegou ao ultimo andar, não é possivel subir mais");
            }
        }

        public void descer()
        {
            if (andar > 0)
            {
                Console.WriteLine(@"Você desceu um andar");
                andar--;
                if (andar == 0)
                {
                    Console.WriteLine("Você chegou ao Estacionamento");
                }
                else if (andar == 1)
                {
                    Console.WriteLine("Você chegou ao Piso");
                }
                else if (andar == 2)
                {
                    Console.WriteLine("Você chegou as Lojas");
                }
                else if (andar == 3)
                {
                    Console.WriteLine("Você chegou aos Escritorios");
                }
                else if (andar == 4)
                {
                    Console.WriteLine("Você chegou a Cobertura");
                }
                else if (andar == 5)
                {
                    Console.WriteLine("Você chegou a Area de Servico");
                }
            }
            else
            {
                Console.WriteLine(@"Você já está no Estacionamento, não é possivel descer mais");
            }
        }

        public void sair()
        {
            if (capacidade > 0)
            {
                Console.WriteLine(@"Uma pessoa saiu do elevador");
                capacidade--;
            }
            else
            {
                Console.WriteLine(@"O elevador está vazio");
            }
        }
    }
}
