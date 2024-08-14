using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho01
{
    public class PagamentoCartao : Pagamento
    {
        public string NumeroCartao { get; set; }

        public PagamentoCartao(decimal valor, string numeroCartao)
            : base(valor)
        {
            NumeroCartao = numeroCartao;
        }

        public override void exibirDetalhes()
        {
            Console.WriteLine($"Pagamento com Cartão: Valor - {Valor:C}, Número do Cartão - {NumeroCartao}");
        }
    }
}
