using System;
using Controller;
using Model;

namespace View
{
    public class CaminhaoVer
    {
        public static void CadastrarCaminhao()
        {
            System.Console.WriteLine("Cadastrar caminhão");
            System.Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Placa:");
            string placa = Console.ReadLine();
            System.Console.WriteLine("Motorista:");
            string motorista = Console.ReadLine();
            Caminhao caminhao = new Caminhao(id, placa, motorista);
            CaminhaoCollection.Add(caminhao);
        }
        public static void Select()
        {
            foreach (Caminhao caminhao in CaminhaoCollection.caminhoes)
            {
                System.Console.WriteLine(caminhao);
            }
        }

        public static void AlterarCaminhao()
        {
            System.Console.WriteLine("Digite o id do caminhao:");
            int id = int.Parse(Console.ReadLine());
            Caminhao caminhao = CaminhaoCollection.GetById(id);
            if (caminhao != null)
            {
                System.Console.WriteLine($"O caminhao selecionado tem a placa {caminhao.placa} e o motorista {caminhao.motorista}.");
                System.Console.WriteLine("Digite a nova placa do caminhao:");
                string novaPlaca = Console.ReadLine();
                System.Console.WriteLine("Digite a nova motorista do caminhao:");
                string novoMotorista = Console.ReadLine();
                caminhao.placa = novaPlaca;
                caminhao.motorista = novoMotorista;
                CaminhaoCollection.UpdateCaminhao(caminhao);
                System.Console.WriteLine("Caminhao atualizado com sucesso!");
            }
            else
            {
                System.Console.WriteLine("Caminhao nao encontrado.");
            }
        }
        public static void RemoverCaminhao()
        {
            System.Console.WriteLine("\n Digite o id do caminhao qeu vai ser deletado:");
            int id = int.Parse(Console.ReadLine());
            Caminhao caminhao = CaminhaoCollection.GetById(id);
            if (caminhao != null){
                CaminhaoCollection.RemoveCaminhao(id);
                System.Console.WriteLine("Caminhão excluido com sucesso!");
            }
            else {
                System.Console.WriteLine("Caminhao nao foi encontrado");
            }
        }
    }
}


