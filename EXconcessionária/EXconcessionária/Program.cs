using System;
using System.Numerics;

using EXconcessionária.Concessionaria;

namespace catalogo
{

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Veículos");

            // Pergunta quantos veículos serão cadastrados
            Console.Write("Quantos veículos deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            // Inicializa o array com o tamanho informado pelo usuário
            CarrosBasic[] vet = new CarrosBasic[n];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Cadastro do veículo {i + 1}: (Modelo, Ano, Portas, Marca)");

                // Lê os dados do veículo
                string[] values = Console.ReadLine().Split(' ');

                // Verifica se há elementos suficientes no input
                if (values.Length < 3)
                {
                    Console.WriteLine("Erro: Insira corretamente os valores (modelo, ano, portas).");
                    i--; // Permite repetir a entrada para esse índice
                    continue;
                }

                // Converte os valores e instancia um novo objeto CarrosBasic
                string modelo = values[0];
                int ano = int.Parse(values[1]);
                int portas = int.Parse(values[2]);
                string marca = values[3];

                vet[i] = new CarrosBasic(portas, marca, modelo, ano);
            }

            Console.WriteLine("\nVeículos cadastrados:");
            foreach (var carro in vet)
            {
                Console.WriteLine(carro);
            }
        }


    }
}
