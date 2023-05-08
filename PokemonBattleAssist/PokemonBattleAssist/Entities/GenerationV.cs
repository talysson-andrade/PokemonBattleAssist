using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class GenerationV
    {
        [JsonProperty("black-white")]
        public Sprites BlackWhite { get; set; }
    }
}
