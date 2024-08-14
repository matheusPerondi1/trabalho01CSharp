using System;
using trabalho01;

namespace trabalho01 {

    public abstract class Viagem : IDetalhavel
    {
        public int Id { get; set; }
        public string Destino { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataPartida { get; set; }

        public Viagem(int id, string destino, decimal preco, DateTime dataPartida)
        {
            Id = id;
            Destino = destino;
            Preco = preco;
            DataPartida = dataPartida;
        }

        public abstract void exibirDetalhes();
    }

}






