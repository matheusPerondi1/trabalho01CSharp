using System;

namespace trabalho01
{
    public class ViagemNacional : Viagem
    {
        public string Estado { get; set; }

        public ViagemNacional(int id, string destino, string estado, decimal preco, DateTime dataPartida)
            : base(id, destino, preco, dataPartida)
        {
            Estado = estado;
        }

        public override void exibirDetalhes()
        {
            Console.WriteLine($"Viagem Nacional: Destino - {Destino}, Estado - {Estado}, Preço - {Preco:C}, Data de Partida - {DataPartida.ToShortDateString()}");
        }
    }
}

