using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho01
{
    public class Cliente : IReservavel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Cliente: Nome - {Nome}, Email - {Email}");
        }
    }

}
