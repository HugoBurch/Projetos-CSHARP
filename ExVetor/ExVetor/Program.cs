using System;
using ExVetor;

namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos iram alugar ?");
            int n = int.Parse(Console.ReadLine());
            Dados[] Vect = new Dados[10];
            for (int i = 1; i <= n; i++) {// laço de repetição para coletar os dados conforme o tanto de quartos iram alugar 
                Console.WriteLine("digite o "+ i+" nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine()); //qual quarto iram alugar = posição do vetor 
                Vect[quarto] = new Dados(nome, email); //atribuir os dados ao vetor na posição que o usuario digitou "Quarto"
            }

            for (int i = 0; i < Vect.Length; i++) { // laço de repetição para ler o vetor/array
                if (Vect[i] != null) {
                    Console.WriteLine(i + ": " + Vect[i]);
                }
            }
        }
    }
}