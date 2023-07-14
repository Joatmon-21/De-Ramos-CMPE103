using System;
using System.Collections.Generic;

namespace Pokedex_EX{

    public class Pokedex{        

        public Pokemon pokemon;            
        
        public static List<Pokemon> pokemons;            

        public Pokedex(){                    
                                    
            pokemons = new List<Pokemon>();

            Pokemon Bulbasaur = new Pokemon{
            name = "Bulbasaur",
            number = "0001",
            abilities = new string[] {"Overgrow"},
            types = new string[] {"Grass", "Poison"},
            health = 45,
            attack = 49,
            defense = 49
            };

            Pokemon Ivysaur = new Pokemon{
            name = "Ivysaur",
            number = "0002",
            abilities = new string[] {"Overgrow"},
            types = new string[] {"Grass", "Poison"},
            health = 60,
            attack = 62,
            defense = 63
            };

            Pokemon Venusaur = new Pokemon{
            name = "Venusaur",
            number = "0003",
            abilities = new string[] {"Overgrow"},
            types = new string[] {"Grass", "Poison"},
            health = 80,
            attack = 82,
            defense = 83
            };

            Pokemon Charmander = new Pokemon{
            name = "Charmander",
            number = "0004",
            abilities = new string[] {"Blaze"},
            types = new string[] {"Fire"},
            health = 39,
            attack = 52,
            defense = 43
            };

            Pokemon Charmeleon = new Pokemon{
            name = "Charmeleon",
            number = "0005",
            abilities = new string[] {"Blaze"},
            types = new string[] {"Fire"},
            health = 58,
            attack = 64,
            defense = 58
            };

            Pokemon Charizard = new Pokemon{
            name = "Charizard",
            number = "0006",
            abilities = new string[] {"Blaze"},
            types = new string[] {"Fire", "Flying"},
            health = 78,
            attack = 84,
            defense = 78
            };

            Pokemon Squirtle = new Pokemon{
            name = "Squirtle",
            number = "0007",
            abilities = new string[] {"Torrent"},
            types = new string[] {"Water"},
            health = 44,
            attack = 48,
            defense = 65
            };

            Pokemon Wartortle = new Pokemon{
            name = "Wartortle",
            number = "0008",
            abilities = new string[] {"Torrent"},
            types = new string[] {"Water"},
            health = 59,
            attack = 63,
            defense = 80
            };

            Pokemon Blastoise = new Pokemon{
            name = "Blastoise",
            number = "0009",
            abilities = new string[] {"Torrent"},
            types = new string[] {"Water"},
            health = 79,
            attack = 83,
            defense = 100
            };

            pokemons.Add(Bulbasaur);
            pokemons.Add(Ivysaur);            
            pokemons.Add(Venusaur); 
            pokemons.Add(Charmander);
            pokemons.Add(Charmeleon);            
            pokemons.Add(Charizard);
            pokemons.Add(Squirtle);
            pokemons.Add(Wartortle);            
            pokemons.Add(Blastoise);  
        }

        public static bool CheckName(string name){
            foreach (var pokemon in pokemons){
                if(name == pokemon.name){                
                    return true;                    
                }
            }
            return false;            
        }                

        public static string GiveNumber(string name){
            foreach (var pokemon in pokemons){
                if(name == pokemon.name){                
                    return pokemon.number;                    
                }
            }
            return null;            
        }        

        public static string[] GiveAbilities(string name){
            foreach (var pokemon in pokemons){
                if(name == pokemon.name){                
                    return pokemon.abilities;                    
                }
            }
            return null;            
        }        

        public static string[] GiveTypes(string name){
            foreach (var pokemon in pokemons){
                if(name == pokemon.name){                
                    return pokemon.types;                    
                }
            }
            return null;            
        }

        public static int GiveHealth(string name){
            foreach (var pokemon in pokemons){
                if(name == pokemon.name){                
                    return pokemon.health;                    
                }
            }
            return 0;         
        }

        public static int GiveAttack(string name){
            foreach (var pokemon in pokemons){
                if(name == pokemon.name){                
                    return pokemon.attack;                    
                }
            }
            return 0;         
        }        

        public static int GiveDefense(string name){
            foreach (var pokemon in pokemons){
                if(name == pokemon.name){                
                    return pokemon.defense;                    
                }
            }
            return 0;         
        }
    }
}