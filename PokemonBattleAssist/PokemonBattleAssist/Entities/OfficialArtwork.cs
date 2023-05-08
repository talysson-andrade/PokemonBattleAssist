using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public Uri FrontShiny { get; set; }
    }
}
