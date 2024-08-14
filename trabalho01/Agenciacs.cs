using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho01
{
    public class Agencia
    {
        private List<Viagem> viagens;
        private List<Cliente> clientes;
        private List<Reserva> reservas;

        public Agencia()
        {
            viagens = new List<Viagem>();
            clientes = new List<Cliente>();
            reservas = new List<Reserva>();
        }

        public void AdicionarViagem(Viagem viagem)
        {
            viagens.Add(viagem);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void ListarViagens()
        {
            foreach (var viagem in viagens)
            {
                Console.WriteLine(viagem);
            }
        }

        public void ListarClientes()
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
        }

        // Outros métodos como RealizarReserva, CancelarReserva, etc.
    }
}
