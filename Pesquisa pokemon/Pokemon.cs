using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa_pokemon
{
    internal class Pokemon
    {
        public string  Nome { get; set; }
        public  int Altura { get; set; }
        public int Peso { get; set; }
        public List<string> Tipos { get; set; } = new();
        public List<string> Golpes { get; set; } = new();


        public void ExibirPokemon()
        {
            Console.WriteLine("Nome:{0}\n" +
                "Altura: {1}\n" +
                "Peso: {2}", Nome, Altura,Peso);
            Console.WriteLine("Tipos: " + string.Join(", ", Tipos));
            Console.WriteLine("Golpes: " + string.Join(", ", Golpes));
        }
    }
}
