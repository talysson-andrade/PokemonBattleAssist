using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using PokemonBattleAssist.Entities;

namespace PokemonBattleAssist.Services
{
    internal class ClientAPI
    {
        public async Task<Pokemon> SearchPokemon(string request)
        {
            Pokemon pokemon = new Pokemon();
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/") };
            HttpResponseMessage response = await client.GetAsync(request.ToLower());
           
            string content = await response.Content.ReadAsStringAsync();

            pokemon = JsonConvert.DeserializeObject<Pokemon>(content);
            
            return pokemon;
        }
    } 
}
