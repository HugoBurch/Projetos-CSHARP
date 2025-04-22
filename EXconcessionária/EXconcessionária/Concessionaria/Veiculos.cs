using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXconcessionária.Concessionaria
{
    class Veiculos 
    {

        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public int Ano { get; protected set; }

        public Veiculos() { }
        public Veiculos(string marca, string modelo, int ano )
        {

            Marca = marca;
            Modelo = modelo;
            Ano = ano;


        }
    }
}
