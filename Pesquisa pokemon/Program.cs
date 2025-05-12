using System;
using System.Threading.Tasks;

namespace Pesquisa_pokemon
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao PokéApp!");
            int opcao=1;

            do
            {
                Console.Write("\nDigite o nome ou numero do Pokémon: ");
                string nomePoke = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nomePoke))
                {
                    Console.WriteLine("Nome inválido. Tente novamente.");
                    continue;
                }

                var pokemon = await PokemonService.BuscarPokemon(nomePoke);

                if (pokemon != null)
                {
                    Console.WriteLine("\n--- Dados do Pokémon ---");
                    pokemon.ExibirPokemon();
                }
                else
                {
                    Console.WriteLine("Pokémon não encontrado ou erro na requisição.");
                }

                bool entradaValida;
                do
                {
                    Console.Write("\nDeseja pesquisar novamente?\nTecle 1 para sim ou 2 para encerrar: ");
                    string entrada = Console.ReadLine();

                    try
                    {
                        opcao = int.Parse(entrada);

                        if (opcao != 1 && opcao != 2)
                        {
                            Console.WriteLine("Opção inválida. Digite apenas 1 ou 2.");
                            entradaValida = false;
                        }
                        else
                        {
                            entradaValida = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Entrada inválida! Digite um número.");
                        entradaValida = false;
                        opcao = 0;
                    }

                } while (!entradaValida);

            } while (opcao == 1);

            Console.WriteLine("Fechando pesquisa");
        }
    }
}
