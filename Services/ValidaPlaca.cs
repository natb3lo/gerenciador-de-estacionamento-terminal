using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MercosulPlateValidator;

namespace Sistema_De_Estacionamento.Services
{
    public class ValidaPlaca
    {
        public static bool isPlacaValida(string placa)
        {

            var resultado = MercosulPlate.ValidateBrazilianPlate(placa);
            if (resultado.IsValid)
            {
                Console.WriteLine($"Formato de Placa válida do Brasil, formato {(resultado.PlateType.Equals("New") ? "novo" : "antigo") }.");
                return true;
            }

            Console.WriteLine($"Formato de Placa Inválida do Brasil.");
            Console.WriteLine("");
            Console.WriteLine($"{"Padrão Antigo (cinza)",-22} : {"LLL-####",-10} Exemplo: ABC-1234");
            Console.WriteLine($"{"Padrão Mercosul (novo)",-22} : {"LLL#L##",-10} Exemplo: BRA2E19");
            return false;

        }
    }
}