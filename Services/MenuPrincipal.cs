using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_De_Estacionamento.Services
{
    public class MenuPrincipal
    {
        public static int ObterOpcao()
        {
            Console.WriteLine(string.Format("{0, -5}{1, -15}", "1 - ", "CADASTRAR VEÍCULO"));
            Console.WriteLine(string.Format("{0, -5}{1, -15}", "2 - ", "REMOVER VEÍCULO"));
            Console.WriteLine(string.Format("{0, -5}{1, -15}", "3 - ", "LISTAR VEÍCULOS"));
            Console.WriteLine(string.Format("{0, -5}{1, -15}", "0 - ", "ENCERRAR"));

            Console.WriteLine();
            Console.Write(string.Format("{0, -8}", "Opção: "));
            string input = Console.ReadLine();
            try
            {
                int opcaoDoUsuario = Convert.ToInt32(input);
                if (opcaoDoUsuario < 0)
                {
                    throw new Exception("Valor digitado é inválido.");
                }
                return opcaoDoUsuario;
            }
            catch (FormatException e)
            {
                throw new FormatException("Valor digitado é inválido.");
            }
            
            
        }
    }
}