using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);

        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Quantidade de horas que permaneceu no estacionamento: ");
                int quantidadeHoras;

                while (!int.TryParse(Console.ReadLine(), out quantidadeHoras) || quantidadeHoras < 0)
                {
                    Console.WriteLine("Por favor, digite um número válido de horas: ");
                }

                decimal valorAPagar = precoInicial + (quantidadeHoras * precoPorHora);
                Console.WriteLine($"O valor a ser pago é R${valorAPagar}");
            }
            else
            {
                Console.WriteLine("Veículo não cadastrado");
            }

        }
        public void ListarVeiculos()
        {
            foreach (string lista in veiculos)
            {
                Console.WriteLine(lista);
            }
        }
    }
}