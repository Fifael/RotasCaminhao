using System;
using System.Collections;

namespace Model
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cidade(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}";
        }
    }
}
