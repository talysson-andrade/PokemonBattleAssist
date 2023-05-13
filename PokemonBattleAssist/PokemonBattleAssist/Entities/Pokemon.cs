using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PokemonBattleAssist.Entities
{

    public partial class Pokemon
    {
        
        [JsonProperty("abilities")]
        public List<Ability>? Abilities { get; set; }

        [JsonProperty("base_experience")]
        public long BaseExperience { get; set; }

        [JsonProperty("forms")]
        public List<Species>? Forms { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndex>? GameIndices { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("held_items")]
        public List<HeldItem>? HeldItems { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("location_area_encounters")]
        public Uri? LocationAreaEncounters { get; set; }

        [JsonProperty("moves")]
        public List<Move>? Moves { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("past_types")]
        public List<object>? PastTypes { get; set; }

        [JsonProperty("species")]
        public Species? Species { get; set; }

        [JsonProperty("sprites")]
        public Sprites? Sprites { get; set; }

        [JsonProperty("stats")]
        public List<Stat>? Stats { get; set; }

        [JsonProperty("types")]
        public List<TypeElement> Types { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        public Pokemon()
        {

        }

        public List<string> BattleStats()
        {
            List<string> weakness =StrongTo(WeakTo());
            return weakness;

        }
        public List<string> StrongTo(List<string> weakness)
        {
            List<string> pokemonTypes = new List<string>();

            foreach (TypeElement type in Types)
            {
                pokemonTypes.Add(type.Type.Name);
            }
            for (int i = 0; i < pokemonTypes.Count; i++)
            {
                if (pokemonTypes[i] == "normal")
                {
                    weakness.Remove("Ghost");
                }
                if (pokemonTypes[i] == "grass")
                {
                    weakness.Remove("Electric");
                    weakness.Remove("Grass");
                    weakness.Remove("Water");
                    weakness.Remove("Ground");
                }
                if (pokemonTypes[i] == "fire")
                {
                    weakness.Remove("Bug");
                    weakness.Remove("Steel");
                    weakness.Remove("Fire");
                    weakness.Remove("Grass");
                    weakness.Remove("Ice");
                    weakness.Remove("Fairy");

                }
                if (pokemonTypes[i] == "water")
                {
                    weakness.Remove("Steel");
                    weakness.Remove("Fire");
                    weakness.Remove("Water");
                    weakness.Remove("Ice");
                }
                if (pokemonTypes[i] == "electric")
                {
                    weakness.Remove("Flying");
                    weakness.Remove("Steel");
                    weakness.Remove("Electric");

                }
                if (pokemonTypes[i] == "flying")
                {
                    weakness.Remove("Fighting");
                    weakness.Remove("Bug");
                    weakness.Remove("Grass");
                }
                if (pokemonTypes[i] == "ice")
                {
                    weakness.Remove("Ice");
                }
                if (pokemonTypes[i] == "rock")
                {
                    weakness.Remove("Normal");
                    weakness.Remove("Flying");
                    weakness.Remove("Poison");
                    weakness.Remove("Fire");
                    
                }
                if (pokemonTypes[i] == "ground")
                {
                    weakness.Remove("Poison");
                    weakness.Remove("Rock");
                    weakness.Remove("Electric");
                }
                if (pokemonTypes[i] == "steel")
                {
                    weakness.Remove("Fairy");
                    weakness.Remove("Normal");
                    weakness.Remove("Flying");
                    weakness.Remove("Poison");
                    weakness.Remove("Rock");
                    weakness.Remove("Bug");
                    weakness.Remove("Steel");
                    weakness.Remove("Grass");
                    weakness.Remove("Psychic");
                    weakness.Remove("Ice");
                    weakness.Remove("Dragon");
                }
                if (pokemonTypes[i] == "fighting")
                {
                    weakness.Remove("Rock");
                    weakness.Remove("Bug");
                    weakness.Remove("Dark");
                }
                if (pokemonTypes[i] == "dark")
                {
                    weakness.Remove("Ghost");
                    weakness.Remove("Psychic");
                    weakness.Remove("Dark");
                }
                if (pokemonTypes[i] == "psychic")
                {
                    weakness.Remove("Fighting");
                    weakness.Remove("Psychic");
                }
                if (pokemonTypes[i] == "poison")
                {
                    weakness.Remove("Fairy");
                    weakness.Remove("Fighting");
                    weakness.Remove("Poison");
                    weakness.Remove("Bug");
                    weakness.Remove("Grass");
                }
                if (pokemonTypes[i] == "bug")
                {
                    weakness.Remove("Fighting");
                    weakness.Remove("Ground");
                    weakness.Remove("Grass");
                }
                if (pokemonTypes[i] == "fairy")
                {
                    weakness.Remove("Bug");
                    weakness.Remove("Fighting");
                    weakness.Remove("Dragon");
                    weakness.Remove("Dark");
                }
                if (pokemonTypes[i] == "ghost")
                {
                    weakness.Remove("Normal");
                    weakness.Remove("Fighting");
                    weakness.Remove("Poison");
                    weakness.Remove("Bug");

                }
                if (pokemonTypes[i] == "dragon")
                {
                    weakness.Remove("Fire");
                    weakness.Remove("Water");
                    weakness.Remove("Grass");
                    weakness.Remove("Electric");
                }
            }
            return weakness;
        }
        public List<string> WeakTo()
        {
            List<string> pokemonTypes = new List<string>();
            List<string> weakness = new List<string>();
            
            foreach(TypeElement type in Types)
            {
                pokemonTypes.Add(type.Type.Name);
            }
            for (int i = 0; i < pokemonTypes.Count; i++)
            {
                if (pokemonTypes[i] == "normal")
                {
                    weakness.Add("Fighting");
                }
                if (pokemonTypes[i] == "grass")
                {
                    weakness.Add("Bug");
                    weakness.Add("Fire");
                    weakness.Add("Flying");
                    weakness.Add("Ice");
                    weakness.Add("Poison");
                }
                if (pokemonTypes[i] == "fire")
                {
                    weakness.Add("Rock");
                    weakness.Add("Ground");
                    weakness.Add("Water");

                }
                if (pokemonTypes[i] == "water")
                {
                    weakness.Add("Eletric");
                    weakness.Add("Grass");
                }
                if (pokemonTypes[i] == "electric")
                {
                    weakness.Add("Ground");
                }
                if (pokemonTypes[i] == "flying")
                {
                    weakness.Add("Eletric");
                    weakness.Add("Rock");
                    weakness.Add("Ice");
                }
                if (pokemonTypes[i] == "ice")
                {
                    weakness.Add("Fighting");
                    weakness.Add("Fire");
                    weakness.Add("Rock");
                    weakness.Add("Steel");
                }
                if (pokemonTypes[i] == "rock")
                {
                    weakness.Add("Fighting");
                    weakness.Add("Grass");
                    weakness.Add("Ground");
                    weakness.Add("Steel");
                    weakness.Add("Water");
                }
                if (pokemonTypes[i] == "ground")
                {
                    weakness.Add("Ice");
                    weakness.Add("Grass");
                    weakness.Add("Water");
                }
                if (pokemonTypes[i] == "steel")
                {
                    weakness.Add("Fighting");
                    weakness.Add("Fire");
                    weakness.Add("Ground");
                }
                if (pokemonTypes[i] == "fighting")
                {
                    weakness.Add("Fairy");
                    weakness.Add("Flying");
                    weakness.Add("Psychic");
                }
                if (pokemonTypes[i] == "dark")
                {
                    weakness.Add("Bug");
                    weakness.Add("Fairy");
                    weakness.Add("Fighting");
                }
                if (pokemonTypes[i] == "psychic")
                {
                    weakness.Add("Bug");
                    weakness.Add("Dark");
                    weakness.Add("Ghost");
                }
                if (pokemonTypes[i] == "poison")
                {
                    weakness.Add("Ground");
                    weakness.Add("Psychic");
                }
                if (pokemonTypes[i] == "bug")
                {
                    weakness.Add("Fire");
                    weakness.Add("Flying");
                    weakness.Add("Rock");
                }
                if (pokemonTypes[i] == "fairy")
                {
                    weakness.Add("Poison");
                    weakness.Add("Steel");
                }
                if (pokemonTypes[i] == "ghost")
                {
                    weakness.Add("Dark");
                    weakness.Add("Ghost");
                }
                if (pokemonTypes[i] == "dragon")
                {
                    weakness.Add("Dragon");
                    weakness.Add("Fairy");
                    weakness.Add("Ice");
                }
            }

            return weakness;
        }
        
    }
}
