using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pesquisa_pokemon
{
    internal class PokemonService
    {
        public static async Task<Pokemon> BuscarPokemon(string nome)
        {
            string url = $"https://pokeapi.co/api/v2/pokemon/{nome.ToLower()}"; //crio a url correta com o nome especificado pelo usuario

            using var client = new HttpClient(); //ainda não entendi muito bem essa parte

            try
            {
                var resposta = await client.GetStringAsync(url);// estou indo da URL do pokemon e pegando as informaçoes
                dynamic json = JsonConvert.DeserializeObject(resposta);//transformando em um json

                var tipos = new List<string>();
                foreach(var tipo in json.types)
                {
                    tipos.Add((string)tipo.type.name);
                }

                var golpes = new List<string>();

                for(int i = 0; i<3 && i < json.moves.Count; i++)//não entendi muito bem a logica desse for
                {
                    golpes.Add((string)json.moves[i].move.name);
                }
                string imagem = json.sprites.front_default;
                string nomep = (string)json.name;
                int altura = (int)json.height;
                int peso = (int)json.weight;
                int numero = (int)json.id;

                var pokemon = new Pokemon(nomep, altura, peso, tipos, golpes, imagem, numero);//decidi criar o construtor do pokemon para testar

                return pokemon;
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("Erro ao buscar o Pokémon.");
                return null;
            }
        }
    }
}
