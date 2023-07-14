using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace Pokedex_EX{

    class Program{                

        static Pokedex pokedex;

        static void Pokemons(){
            pokedex = new Pokedex();
        }

        static string GetUserInput(){
            return Console.ReadLine();
        }                
        
        static string name;     
        static string lenLen;    
        static string userInput = "0";    

        static void Main(){       

            string url = "https://pokeapi.co/api/v2/pokemon/";

            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.Get(request);             
        
            char e_Acute = '\u00e9';

            string chosenPokemon;

            Console.Clear();

            

            bool exit = false;
            Pokemons();

            chosenPokemon = Console.ReadLine();

            url += chosenPokemon.ToLower();          

            client = new RestClient(url);
            request = new RestRequest();
            response = client.Get(request);
  

            Console.WriteLine(response.Content);

            Console.Read();

            var result = response.Content;

            while(exit == false){
                try{                                        
                    Console.WriteLine("Welcome to your Pok"+e_Acute+"dex");
                    Console.Write("Choose your Pok"+e_Acute+"mon! > ");
                    string name = GetUserInput();                                 
                    string selectedPokemonNumber = Pokedex.GiveNumber(name);
                    string[] selectedPokemonAbilities = Pokedex.GiveAbilities(name);
                    string[] selectedPokemonTypes = Pokedex.GiveTypes(name);
                    int selectedPokemonHealth = Pokedex.GiveHealth(name);
                    int selectedPokemonAttack = Pokedex.GiveAttack(name);
                    int selectedPokemonDefense = Pokedex.GiveDefense(name);

                    lenLen = name;

                    bool pokemonExists = Pokedex.CheckName(name);

                        if(pokemonExists == true){
                            Console.Clear();
                            for(int i = 0; i <= lenLen.Length; i++){
                            Console.Write("-");
                            }
                            Console.WriteLine();
                            Console.WriteLine(name);        
                            for(int i = 0; i <= lenLen.Length; i++){
                            Console.Write("-");
                            }
                            Console.WriteLine();
                            Console.Write("Index Number: ");
                            Console.WriteLine(selectedPokemonNumber);        
                            Console.Write("Abilities: ");
                            Console.WriteLine(string.Join(", ", selectedPokemonAbilities));
                            Console.Write("Types: ");
                            Console.WriteLine(string.Join(", ", selectedPokemonTypes));
                            Console.Write("Health: ");
                            Console.WriteLine(selectedPokemonHealth);
                            Console.Write("Attack: ");
                            Console.WriteLine(selectedPokemonAttack);
                            Console.Write("Defense: ");
                            Console.WriteLine(selectedPokemonDefense);
                            Console.WriteLine();
                            
                            bool userInputSatisfied = false;                                                        
                            while(userInputSatisfied == false){
                                Console.WriteLine("1 = Yes | 0 = No");
                                Console.Write("Would you like to check the stats of another Pok"+e_Acute+"mon? > ");
                                userInput = GetUserInput();
                                if(userInput == "0"){
                                    Console.Clear();
                                    exit = true;
                                    userInputSatisfied = true;
                                }else if(userInput == "1"){
                                    Console.Clear();
                                    exit = false;
                                    userInputSatisfied = true;
                                }else{
                                    Console.Clear();
                                    Console.WriteLine("Please Choose either 0 or 1 only");
                                }
                            }
                            
                        }else{
                            Console.Clear();                                                     
                            Console.WriteLine("There is no Pok"+e_Acute+"mon such as: "+name+" that exists");
                            Console.WriteLine();                            
                        }                                                
                    }catch(System.ArgumentNullException){                    
                        continue;
                }   
            }            
        }        
    }
}