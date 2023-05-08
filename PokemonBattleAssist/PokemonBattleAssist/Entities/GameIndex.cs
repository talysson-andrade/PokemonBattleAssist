using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class GameIndex
    {
        [JsonProperty("game_index")]
        public long GameIndexGameIndex { get; set; }

        [JsonProperty("version")]
        public Species Version { get; set; }
    }
}
