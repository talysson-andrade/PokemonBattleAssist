﻿using Newtonsoft.Json;

namespace PokemonBattleAssist.Entities
{
    public partial class Versions
    {
        [JsonProperty("generation-i")]
        public GenerationI GenerationI { get; set; }

        [JsonProperty("generation-ii")]
        public GenerationIi GenerationIi { get; set; }

        [JsonProperty("generation-iii")]
        public GenerationIii GenerationIii { get; set; }

        [JsonProperty("generation-iv")]
        public GenerationIv GenerationIv { get; set; }

        [JsonProperty("generation-v")]
        public GenerationV GenerationV { get; set; }

        [JsonProperty("generation-vi")]
        public Dictionary<string, Home> GenerationVi { get; set; }

        [JsonProperty("generation-vii")]
        public GenerationVii GenerationVii { get; set; }

        [JsonProperty("generation-viii")]
        public GenerationViii GenerationViii { get; set; }
    }
}
