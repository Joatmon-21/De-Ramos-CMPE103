using System;
using RestSharp;
using System.Media;
using System.Globalization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pokedex_EX2
{
    class Program
    {
        static void Main()
        {
            
            string apiURL = "https://pokeapi.co/api/v2/pokemon/";
            string finalURL = apiURL;

            var client = new RestClient(apiURL);
            var request = new RestRequest();
            var response = client.Get(request);

            bool exit = false;
            bool userInputVerified = false;

            string userInput;
            string chosenPokemon = "a";

            char e_Acute = '\u00e9';
            char quotation_Marks = '\u201c';

            TextInfo textModifier = CultureInfo.CurrentCulture.TextInfo;

            while(exit == false){                

                try{                  
                    userInputVerified = false;                      
                    Console.Clear();                    
                    Console.WriteLine("Welcome to the Pok" + e_Acute + "dex");
                    Console.Write("Choose your Pok" + e_Acute +"mon! > ");
                    chosenPokemon = Console.ReadLine();

                    finalURL = apiURL + chosenPokemon.ToLower();

                    client = new RestClient(finalURL);
                    request = new RestRequest();
                    response = client.Get(request);

                    var result = response.Content;

                    var poke = JsonConvert.DeserializeObject<Pokemon>(result);
                    Console.Clear();

                    if(chosenPokemon.ToLower() == "clefairy"){
                        SoundPlayer play = new SoundPlayer(@"sounds\easterEgg.wav");
                        play.Play();
                    }
                    // Name
                    for (int loop = 1; loop <= chosenPokemon.Length; loop++){
                        Console.Write("-");
                    }
                    Console.WriteLine();
                    Console.WriteLine(textModifier.ToTitleCase(chosenPokemon));
                    for (int loop = 1; loop <= chosenPokemon.Length; loop++){
                        Console.Write("-");
                    }
                    // Order
                    Console.WriteLine();
                    Console.WriteLine("Order: " + poke.order);
                    

                    // Stats
                    Console.WriteLine();
                    Console.WriteLine("Stats: ");      
                    foreach (var pokemonStats in poke.stats){
                        if(pokemonStats.stat.name == "hp"){
                            Console.Write("  HP: ");
                        }else{
                            Console.Write("  " + textModifier.ToTitleCase(pokemonStats.stat.name) + ": ");
                        }                    
                        Console.WriteLine(pokemonStats.base_stat);                
                    }              

                    // Height
                    Console.WriteLine();
                    Console.WriteLine("Height: " + poke.height);
                    // Weight                
                    Console.WriteLine("Weight: " + poke.weight);                            

                    // Types
                    Console.WriteLine();
                    Console.WriteLine("Types: ");      
                    foreach (var pokemonTypes in poke.types){
                        Console.WriteLine("  " + textModifier.ToTitleCase(pokemonTypes.type.name));                
                    }

                    // Abilities
                    Console.WriteLine();
                    Console.WriteLine("Abilities: ");
                    foreach (var pokemonAbilities in poke.abilities){
                        Console.WriteLine("  " + textModifier.ToTitleCase(pokemonAbilities.ability.name));
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadKey();
                    
                    while(userInputVerified == false){                        
                        Console.Clear();
                        for(int loop = 1; loop < 18; loop++){
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        Console.WriteLine("0 = No || 1 = Yes");   
                        for(int loop = 1; loop < 18; loop++){
                            Console.Write("-");
                        }                 
                        Console.WriteLine();
                        Console.Write("Would you like to check the stats of another Pok"+ e_Acute +"mon? > ");                
                        userInput = Console.ReadLine();

                        if(userInput == "1"){
                            exit = false;
                            userInputVerified = true;
                            finalURL = apiURL;
                        }else if(userInput == "0"){
                            exit = true;
                            userInputVerified = true;
                        }else{
                            Console.WriteLine("You Have Entered an Invalid Input");
                            Console.WriteLine("Please Choose Either 0 or 1 Only");
                        }           
                    }                       
                }catch(System.NullReferenceException){
                    Console.Clear();                    
                    Console.Beep();
                    Console.WriteLine("There is no Poke" + e_Acute + "mon such as: " + chosenPokemon + " that exists");
                    Console.WriteLine("Please Press Enter to Continue");
                    Console.ReadKey();
                }catch(Newtonsoft.Json.JsonReaderException){
                    Console.Clear();                    
                    Console.Beep();
                    Console.WriteLine("There is no Pok" + e_Acute + "mon such as " + quotation_Marks + chosenPokemon + quotation_Marks + " that exists");
                    Console.WriteLine("Press Enter to Continue");                    
                    Console.ReadKey();
                }                     
            }
        }
    }
}
