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
            Console.WriteLine("Escreva o nome do Pokemon que você esta enfrentando:");
            Console.WriteLine();
            string request = Console.ReadLine();
            ClientAPI client = new ClientAPI();
            Pokemon pokemon = await client.SearchPokemon(request);

            Console.WriteLine();
            Console.WriteLine("Tipo: ");
            foreach (TypeElement type in pokemon.Types)
            {
                Console.WriteLine(char.ToUpper(type.Type.Name[0])+ type.Type.Name.Substring(1));
            }
            Console.WriteLine();

            Console.WriteLine("Fraco contra: ");
            foreach (string weak in pokemon.BattleStats())
            {
                Console.WriteLine(weak);
            }

            
        }

    }
}
