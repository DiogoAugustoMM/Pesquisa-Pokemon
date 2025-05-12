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
        public int Numero { get; set; }
        public  int Altura { get; set; }
        public int Peso { get; set; }
        public List<string> Tipos { get; set; } = new();
        public List<string> Golpes { get; set; } = new();
        public string Imagem { get; set; }

        public Pokemon(string nome, int altura, int peso, List<string> tipos, List<string> golpes, string imagem, int numero) 
        {
            this.Nome = nome;
            this.Altura = altura;
            this.Peso = peso;
            this.Tipos = tipos;
            this.Golpes = golpes;
            this.Imagem = imagem;
            this.Numero = numero;
        }

        public void ExibirPokemon()
        {
            Console.WriteLine("Nome:{0}\n" +
                "Numero: {1}\n" +
                "Altura: {2} metros\n" +
                "Peso: {3} quilos", Nome, Numero, Altura,Peso);
            Console.WriteLine("Tipos: " + string.Join(", ", Tipos));
            Console.WriteLine("Golpes: " + string.Join(", ", Golpes));
            Console.WriteLine("Imagem do pokemon: "+Imagem);
        }
    }
}
