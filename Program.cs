
using Sistema_De_Estacionamento.Services;
using Sistema_De_Estacionamento.Models;
using MercosulPlateValidator;


Estacionamento estacionamento = new Estacionamento();
string input;

bool isPrecoNaoValido = true;
do
{
    Console.Clear();
    Console.WriteLine("Bem-Vindo ao Sistema de Estacionamento!");
    Console.WriteLine("");
    Console.Write(string.Format("{0, -15}{1, -2}{2, -3}", "Preço Inicial ", ":", "R$"));
    input = Console.ReadLine().Trim();
    try
    {
        estacionamento.PrecoInicial = Convert.ToDecimal(input);
        Console.Write(string.Format("{0, -15}{1, -2}{2, -3}", "Preço por Hora ", ":", "R$"));
        input = Console.ReadLine();
        estacionamento.PrecoPorHora = Convert.ToDecimal(input);

        isPrecoNaoValido = false;

    }
    catch (Exception e)
    {
        Console.Clear();

        if (e is FormatException)
        {
            Console.WriteLine("Somente valores numéricos são válidos.");
        }
        else
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadLine();
    }
    
    
} while (isPrecoNaoValido);

bool isLoopAtivo = true;
do
{
    Console.Clear();

    try
    {
        int opcaoDoUsuario = MenuPrincipal.ObterOpcao();
        switch (opcaoDoUsuario)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($"{"Padrão Antigo (cinza)",-22} : {"LLL-####",-10} Exemplo: ABC-1234");
                Console.WriteLine($"{"Padrão Mercosul (novo)",-22} : {"LLL#L##",-10} Exemplo: BRA2E19");
                Console.WriteLine("");
                Console.Write(string.Format("{0, -30}", "Digite a Placa do Veículo para Estacionar: "));
                input = Console.ReadLine();
                string placa = input.Trim().ToUpper();
                Console.Clear();

                Veiculo veiculoTemporario = new Veiculo(placa);
                bool isPlacaValida = ValidaPlaca.isPlacaValida(veiculoTemporario.Placa);

                if (isPlacaValida && !estacionamento.Veiculos.Contains(veiculoTemporario))
                {
                    estacionamento.AdicionarVeiculo(veiculoTemporario);
                    Console.WriteLine($"Veículo {veiculoTemporario.Placa} Adicionado.");
                }
                else if (isPlacaValida && estacionamento.Veiculos.Contains(veiculoTemporario))
                {

                    Console.WriteLine($"Veículo {veiculoTemporario.Placa} já cadastrado.");
                    Console.Clear();
                }

                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                break;

            case 2:
                Console.Clear();
                Console.Write(string.Format("{0, -30}", "Digite a Placa do Veículo a ser Removido: "));
                input = Console.ReadLine();
                placa = input.Trim().ToUpper();

                veiculoTemporario = new Veiculo(placa);
                if (estacionamento.Veiculos.Contains(veiculoTemporario))
                {
                    Console.WriteLine("");
                    Console.Write(string.Format("{0, -40}", "Digite a Quantidade de Horas que o Veículo ficou Estacionado: "));
                    input = Console.ReadLine().Trim();
                    try
                    {
                        int horasEstacionado = Convert.ToInt32(input);
                        if (horasEstacionado > 0)
                        {
                            Console.Clear();
                            estacionamento.RemoverVeiculo(veiculoTemporario);
                            Console.WriteLine($"Veículo {veiculoTemporario.Placa} removido.");
                            Console.WriteLine($"Preço Total: R${estacionamento.PrecoInicial + (horasEstacionado * estacionamento.PrecoPorHora)}");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Digite um valor maior do que 0.");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.Clear();
                        Console.WriteLine("Somente valores numéricos são válidos.");


                    }


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Veículo não Cadastrado.");
                }
                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                break;

            case 3:
                Console.Clear();
                estacionamento.ListarVeiculos();
                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                break;

            case 0:
                Console.Clear();
                Console.WriteLine("Programa Encerrado.");
                Console.WriteLine("");
                isLoopAtivo = false;
                break;
        }
    }
    catch (Exception e)
    {
        Console.Clear();
        Console.WriteLine(e.Message);
        Console.WriteLine("");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadLine();
    }

} while (isLoopAtivo);

