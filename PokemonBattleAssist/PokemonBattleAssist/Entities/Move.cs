using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class Move
    {
        [JsonProperty("move")]
        public Species MoveMove { get; set; }

        [JsonProperty("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }
}
