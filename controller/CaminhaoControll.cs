using Model;
using System.Collections;

namespace Controller
{
    public class CaminhaoCollection : IEnumerable<Caminhao>
    {
        public static List<Caminhao> caminhoes = new List<Caminhao>();

        public static void Add(Caminhao caminhao)
        {
            caminhoes.Add(caminhao);
        }

        public static Caminhao GetById(int id)
        {
            foreach (Caminhao caminhao in caminhoes)
            {
                if (caminhao.id == id)
                {
                    return caminhao;
                }
            }
            return null;
        }
        public static void RemoveCaminhao(int id)
        {
            Caminhao caminhao = GetById(id);
            if(caminhao != null){
                caminhoes.Remove(caminhao);
            }
        }

        public static void UpdateCaminhao(Caminhao caminhao)
        {
            Caminhao caminhaoAntigo = GetById(caminhao.id);
            if (caminhaoAntigo == null)
            {
                throw new Exception("Pessoa não encontrada.");
            }
            caminhaoAntigo.motorista = caminhao.motorista;
            caminhaoAntigo.placa = caminhao.placa;
        }

        public IEnumerator<Caminhao> GetEnumerator()
        {
            return caminhoes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
