using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class GenerationIii
    {
        [JsonProperty("emerald")]
        public OfficialArtwork Emerald { get; set; }

        [JsonProperty("firered-leafgreen")]
        public Gold FireredLeafgreen { get; set; }

        [JsonProperty("ruby-sapphire")]
        public Gold RubySapphire { get; set; }
    }
}
