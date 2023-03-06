using System;
using View;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 13)
            {
                Console.WriteLine("1 - Cadastra Caminhao");
                Console.WriteLine("2 - Alterar Caminhão");
                Console.WriteLine("3 - Mostar Caminhao");
                Console.WriteLine("4 - Remover Caminhao");
                Console.WriteLine("5 - Cadastra Cidade");
                Console.WriteLine("6 - Alterar Cidade");
                Console.WriteLine("7 - Mostar Cidade");
                Console.WriteLine("8 - Remover Cidade");
                Console.WriteLine("9 - Cadastra Rota");
                Console.WriteLine("10 - Alterar Rota");
                Console.WriteLine("11 - Mostar Rota");
                Console.WriteLine("12 - Remover Rota");
                Console.WriteLine("13 - Sair");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CaminhaoVer.CadastrarCaminhao();
                        break;
                    case 2:
                        CaminhaoVer.AlterarCaminhao();
                        break;
                    case 3:
                        CaminhaoVer.Select();
                        break;
                    case 4:
                        CaminhaoVer.RemoverCaminhao();
                        break;
                    case 5:
                        CidadeVer.CadastrarCidade();
                        break;
                    case 6:
                        CidadeVer.AlterarCidade();
                        break;
                    case 7:
                        CidadeVer.SelectCidade();
                        break;
                    case 8:
                        CidadeVer.RemoveCidade();
                        break;
                    case 9:
                        RotaVer.AlterarRota();
                        break;
                    case 10:
                        RotaVer.AlterarRota();
                        break;
                    case 11:
                        RotaVer.AlterarRota();
                        break;
                    case 12:
                        RotaVer.AlterarRota();
                        break;
                    case 13:
                        Sair();
                    break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
        public static void Sair()
        {
            Console.WriteLine("Saindo...");
            Environment.Exit(0);
        }
    }
}