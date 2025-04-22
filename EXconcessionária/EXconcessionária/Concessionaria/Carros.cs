using System;
using System.Collections.Generic;
namespace EXconcessionária.Concessionaria
{
    class CarrosBasic : Veiculos
    {
        public int Portas { get; protected set; }
        public CarrosBasic() { }    
        public CarrosBasic(int portas, string marca, string modelo, int ano) : base (marca, modelo, ano)
        { Portas = portas; }


        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo} - Ano: {Ano}, Portas: {Portas}";
        }



    }
    class CarrosCompletos : Veiculos { 
    public int Portas { get; set; }
    public string Ar {  get; set; }
    public string DirecaoHidraulica { get; set; }
    
    
    public CarrosCompletos(int portas, string ar, string direcaoHidraulica, string marca, string modelo, int ano) : base(marca,modelo,ano) { 
            
     Portas = portas;  
     Ar = ar; 
     DirecaoHidraulica = direcaoHidraulica; 
        }
    
    
    }
}
