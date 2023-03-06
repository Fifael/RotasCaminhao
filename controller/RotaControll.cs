using System.Collections;
using Model;

namespace Controller
{
    public class RotaCollection : IEnumerable<Rota>
    {
        public static List<Rota> rotas = new List<Rota>();

        public IEnumerator<Rota> GetEnumerator()
        {
            return rotas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static void Add(Rota rota)
        {
            rotas.Add(rota);
        }

        public static Rota GetByID(int id)
        {
            foreach (Rota rota in rotas)
            {
                if (rota.Id == id)
                {
                    return rota;
                }
            }
            return null;
        }

        public static void RemoveRota(int id)
        {
            Rota rota = GetByID(id);
            rotas.Remove(rota);
        }

        public static void UpdateRota(Rota rota)
        {
            Rota rotaAntiga = GetByID(rota.Id);
            if (rotaAntiga == null)
            {
                throw new Exception("Pessoa não encontrada.");
            }
            rotaAntiga.Caminhao = rota.Caminhao;
            rotaAntiga.Data = rota.Data;
            rotaAntiga.Destino = rota.Destino;
            rotaAntiga.Origem = rota.Origem;
        }
    }
}

