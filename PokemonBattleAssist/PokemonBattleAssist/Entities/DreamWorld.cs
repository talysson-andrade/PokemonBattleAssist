using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class DreamWorld
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }
    }
}
