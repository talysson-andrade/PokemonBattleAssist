using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class HeldItem
    {
        [JsonProperty("item")]
        public Species Item { get; set; }

        [JsonProperty("version_details")]
        public List<VersionDetail> VersionDetails { get; set; }
    }
}
