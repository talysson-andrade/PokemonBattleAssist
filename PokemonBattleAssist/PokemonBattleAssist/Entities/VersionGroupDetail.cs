using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public long LevelLearnedAt { get; set; }

        [JsonProperty("move_learn_method")]
        public Species MoveLearnMethod { get; set; }

        [JsonProperty("version_group")]
        public Species VersionGroup { get; set; }
    }
}
