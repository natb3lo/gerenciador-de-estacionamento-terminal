using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_De_Estacionamento.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }

        public Veiculo(string placa)
        {
            this.Placa = placa;
        }
        
        public override bool Equals(object obj)
        {
            if (obj is Veiculo veiculo)
            {
                return this.Placa.Equals(veiculo.Placa, StringComparison.OrdinalIgnoreCase);
            }

           return false;
        }
        
        public override int GetHashCode()
        {
            return this.Placa.ToLower().GetHashCode();
        }
        
    }
}