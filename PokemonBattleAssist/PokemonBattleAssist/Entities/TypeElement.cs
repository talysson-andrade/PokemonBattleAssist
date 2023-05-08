using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class TypeElement
    {
        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("type")]
        public Species Type { get; set; }
    }
}
