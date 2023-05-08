using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class VersionDetail
    {
        [JsonProperty("rarity")]
        public long Rarity { get; set; }

        [JsonProperty("version")]
        public Species Version { get; set; }
    }
}
