using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class GenerationI
    {
        [JsonProperty("red-blue")]
        public RedBlue RedBlue { get; set; }

        [JsonProperty("yellow")]
        public RedBlue Yellow { get; set; }
    }
}
