using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_De_Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;

        private List<Veiculo> veiculos = new List<Veiculo>();

        public decimal PrecoInicial
        {
            get { return precoInicial; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Digite um valor maior do que 0.");
                }
                precoInicial = value;
            }
        }

        public decimal PrecoPorHora
        {
            get { return precoPorHora; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Digite um valor maior do que 0.");
                }
                precoPorHora = value;
            }
        }

        public List<Veiculo> Veiculos
        {
            get { return veiculos; }
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo(Veiculo veiculo)
        {
            veiculos.Remove(veiculo);
        }

        public void ListarVeiculos()
        {
            int i = 1;
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Veículo {i}: {veiculo.Placa}");
                i++;
            }
        }
    }
}