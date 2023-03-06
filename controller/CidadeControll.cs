using System.Collections;
using Model;

namespace Controller
{
    public class CidadeCollection : IEnumerable<Cidade> /*IEnumerable possui um método para retornar o próximo item na coleção,
                                                        com isso ele não precisa que toda coleção esteja em memória e
                                                        também não sabe quantos itens estão nela. Quando utilizado em um loop como o foreach, 
                                                        ele apenas vai retornando o próximo item até que termine a coleção.*/
    {
        public static List<Cidade> cidades = new List<Cidade>();
        public static Cidade GetById(int id)
        {
            foreach (Cidade cidade in cidades)
            {
                if (cidade.Id == id)
                {
                    return cidade;
                }
            }
            return null;
        }

        public static void RemoveCidade(int id)
        {
            Cidade cidade = GetById(id);
            cidades.Remove(cidade);
        }

        public static void AddCidade(Cidade cidade)
        {
            cidades.Add(cidade);
        }

        public void UpdateCidade(Cidade cidade)
        {
            Cidade cidadeAntiga = GetById(cidade.Id);
            if (cidadeAntiga == null)
            {
                throw new Exception("Pessoa não encontrada.");
            }
            cidade.Nome = cidadeAntiga.Nome;

        }

        public IEnumerator<Cidade> GetEnumerator()
        {
            return cidades.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
