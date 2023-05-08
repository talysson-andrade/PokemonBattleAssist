using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class Species
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
