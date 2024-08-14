using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho01
{
    public class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto { get; set; }

        public PagamentoBoleto(decimal valor, string numeroBoleto)
            : base(valor)
        {
            NumeroBoleto = numeroBoleto;
        }

        public override void exibirDetalhes()
        {
            Console.WriteLine($"Pagamento com Boleto: Valor - {Valor:C}, Número do Boleto - {NumeroBoleto}");
        }
    }
}
