using System;
using Controller;
using Model;

namespace View
{
    public class CidadeVer
    {
        public static void CadastrarCidade()
        {
            System.Console.WriteLine("Cadastrar cidade");
            System.Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Cidade cidade = new Cidade(id, nome);
            CidadeCollection.AddCidade(cidade);
        }

        public static void SelectCidade(){
            foreach (Cidade cidade in CidadeCollection.cidades){
                Console.WriteLine(cidade);
            }
        }

        public static void RemoveCidade(){
            System.Console.WriteLine("Qual id da cidade");
            int id = int.Parse(Console.ReadLine());
            Cidade cidade = CidadeCollection.GetById(id);
            if (cidade != null){
                CidadeCollection.RemoveCidade(id);
                System.Console.WriteLine("Cidade excluido com sucesso!");
            }
            else {
                System.Console.WriteLine("Cidade nao foi encontrado");
            }
        }

        public static void AlterarCidade(){
            System.Console.WriteLine("Qual id deseja alterar");
            int id = int.Parse(Console.ReadLine());
            Cidade cidade = CidadeCollection.GetById(id);
            if (cidade != null){
                System.Console.WriteLine($"A cidade selecionada é {cidade.Nome}");
                System.Console.WriteLine("Informe um novo nome");
                string NovaCidade = Console.ReadLine();
                cidade.Nome = NovaCidade;
            }
            else
            {
                System.Console.WriteLine("Cidade nao encontrado.");
            }
        }
    }
}      



