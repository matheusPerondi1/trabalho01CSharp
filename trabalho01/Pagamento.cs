using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho01
{
    public abstract class Pagamento : IDetalhavel
    {
        public decimal Valor { get; set; }

        public Pagamento(decimal valor)
        {
            Valor = valor;
        }

        public abstract void exibirDetalhes();
    }
}
