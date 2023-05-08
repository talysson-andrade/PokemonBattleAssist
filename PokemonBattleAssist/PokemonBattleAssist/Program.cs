using System;
using System.Data;
using PokemonBattleAssist.Entities;
using PokemonBattleAssist.Services;
using System.Threading.Tasks;

namespace PokemonBattleAssist
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ClientAPI client = new ClientAPI();
            string request = Console.ReadLine();

            Pokemon pokemon = await client.SearchPokemon(request);
            
            foreach(TypeElement type in pokemon.Types)
            {
                Console.WriteLine(type.Type.Name.ToUpperInvariant());
            }
            
        }

    }
}
