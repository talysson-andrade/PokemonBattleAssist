using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class GenerationVii
    {
        [JsonProperty("icons")]
        public DreamWorld Icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        public Home UltraSunUltraMoon { get; set; }
    }
}
