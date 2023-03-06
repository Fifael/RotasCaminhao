using System;
using Controller;
using Model;

namespace View
{
    public class RotaVer
    {
        public static void CadastrarRota()
        {
            System.Console.WriteLine("Cadastrar Rota");
            System.Console.WriteLine("Id da Rota:");
            int id = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual o id da cidade de Origem:");
            int origem = int.Parse(Console.ReadLine());
            while (CidadeCollection.GetById(origem) == null)
            {
                System.Console.WriteLine("Cidade não encontrada, digite novamente: ");
                origem = int.Parse(Console.ReadLine());
            }
            Cidade IdOrigem = CidadeCollection.GetById(origem);
            System.Console.WriteLine("Qual o id da cidade de Destino:");
            int destino = int.Parse(Console.ReadLine());
            while (CidadeCollection.GetById(destino) == null)
            {
                System.Console.WriteLine("Cidade não encontrada, digite novamente: ");
                destino = int.Parse(Console.ReadLine());
            }
            Cidade IdDestino = CidadeCollection.GetById(destino);
            System.Console.WriteLine("Qual id do caminhao para Rota");
            int caminhao = int.Parse(Console.ReadLine());
            while (CaminhaoCollection.GetById(caminhao) == null)
            {
                System.Console.WriteLine("Camihao não encontrada, digite novamente: ");
                caminhao = int.Parse(Console.ReadLine());
            }
            Caminhao IdCaminhao = CaminhaoCollection.GetById(caminhao);
            System.Console.WriteLine("Qual data da Rota");
            string data = Console.ReadLine();
            Rota rota = new Rota(id, IdOrigem, IdDestino, IdCaminhao, data);
            RotaCollection.Add(rota);
        }

        public static void Select()
        {
            foreach (Rota rota in RotaCollection.rotas)
            {
                System.Console.WriteLine(rota);
            }
        }

        public static void RemoveRota()
        {
            System.Console.WriteLine("\n Digite o id da rota que vai ser deletado:");
            int id = int.Parse(Console.ReadLine());
            Rota rota = RotaCollection.GetByID(id);
            if (rota != null)
            {
                RotaCollection.RemoveRota(id);
                System.Console.WriteLine("Rota excluido com sucesso!");
            }
            else
            {
                System.Console.WriteLine("Rota nao foi encontrado");
            }
        }

        public static void AlterarRota()
        {
            System.Console.WriteLine("Qual id deseja alterar");
            int id = int.Parse(Console.ReadLine());
            Rota rota = RotaCollection.GetByID(id);
            if (rota != null)
            {
                System.Console.WriteLine($"A origem Rota selecionada é {rota.Origem}, o destino é {rota.Destino}, o caminhao {rota.Caminhao}, a data é {rota.Data}");
                System.Console.WriteLine("Informe uma nova origem");
                string origem = Console.ReadLine();
                System.Console.WriteLine("Informe um novo destino");
                string destino = Console.ReadLine();
                System.Console.WriteLine("Informe um novo caminhao");
                string caminhao = Console.ReadLine();
                System.Console.WriteLine("Informe uma nova data");
                string data = Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("Rota nao encontrado.");
            }
        }

    }
}


