using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class GenerationViii
    {
        [JsonProperty("icons")]
        public DreamWorld Icons { get; set; }
    }
}
