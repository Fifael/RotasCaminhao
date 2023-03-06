using System.Collections;
using Model;

namespace Model
{
    public class Rota
    {
        public int Id { get; set; }
        public Cidade Origem { get; set; }
        public Cidade Destino { get; set; }
        public Caminhao Caminhao { get; set; }
        public string Data { get; set; }
        public static List<Rota> Rotas { get; set; } = new List<Rota>();
        public Rota(
            int id,
            Cidade origem,
            Cidade destino,
            Caminhao caminhao,
            string data

        )
        {
            this.Id = id;
            this.Origem = origem;
            this.Destino = destino;
            this.Caminhao = caminhao;
            this.Data = data;

        }

        public override string ToString()
        {
            return $"Id: {Id}, Origem: {Origem}, Destino: {Destino}, Caminhão: {Caminhao}, Data: {Data}";
        }
    }
}