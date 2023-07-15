using System;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pokedex_EX2
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            string apiURL = "https://pokeapi.co/api/v2/pokemon/";
            string finalURL = apiURL;

            var client = new RestClient(apiURL);
            var request = new RestRequest();
            var response = client.Get(request);

            string chosenPokemon = Console.ReadLine();

            finalURL = apiURL + chosenPokemon.ToLower();

            client = new RestClient(finalURL);
            request = new RestRequest();
            response = client.Get(request);

            var stat = response.Content;

            var poke = JsonConvert.DeserializeObject<Pokemon>(stat);
            Console.Clear();
            for (int loop = 1; loop <= chosenPokemon.Length; loop++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine(char.ToUpper(chosenPokemon[0]) + chosenPokemon.Substring(1));
            for (int loop = 1; loop <= chosenPokemon.Length; loop++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine("Order: " + poke.order);
            Console.WriteLine("Weight: " + poke.weight);
            Console.WriteLine("Types: ");      
            foreach (var pokemonTypes in poke.types){
                Console.WriteLine("  " + pokemonTypes.type.name);                
            }
            Console.WriteLine();
            Console.WriteLine("Stats: ");      
            foreach (var pokemonStats in poke.stats){
                Console.Write("  " + pokemonStats.stat.name + ": ");
                Console.WriteLine(pokemonStats.base_stat);                
            }            
        }
    }
}
