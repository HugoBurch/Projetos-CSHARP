using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVetor
{
    internal class Dados
    {
        public string Nome {  get; set; }
        public string Email { get; set; }


        public Dados(string nome, string email) // Metodo construtor
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString() { 
            return Nome + ", " + Email;
        }
    }
}
