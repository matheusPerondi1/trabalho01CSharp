using System;

namespace trabalho01
{
    public class ViagemInternacional : Viagem
    {
        public string Pais { get; set; }
        public bool PrecisaVisto { get; set; }

        public ViagemInternacional(int id, string destino, string pais, bool precisaVisto, decimal preco, DateTime dataPartida)
            : base(id, destino, preco, dataPartida)
        {
            Pais = pais;
            PrecisaVisto = precisaVisto;
        }

        public override void exibirDetalhes()
        {
            Console.WriteLine($"Viagem Internacional: Destino - {Destino}, País - {Pais}, Precisa de Visto - {PrecisaVisto}, Preço - {Preco:C}, Data de Partida - {DataPartida.ToShortDateString()}");
        }
    }
}

