using Newtonsoft.Json;
using System;
using PeterHan.PLib.Options;

namespace ONI_SupplyingExclusions
{
    [JsonObject(MemberSerialization.OptIn)]
    [ModInfo("https://github.com/leehuk/oni-supplyingexclusions/")]
    public class SupplyingExclusionsConfig
    {

        [Option("DisableBuild", "Disable Building Supply Errands")]
        [JsonProperty]
        public bool DisableBuild { get; set; }

        [Option("DisableCook", "Disable Cook Supply Errands")]
        [JsonProperty]
        public bool DisableCook { get; set; }

        [Option("DisableDoctor", "Disable Doctor Supply Errands")]
        [JsonProperty]
        public bool DisableDoctor { get; set; }

        [Option("DisableFabricate", "Disable Fabricate Supply Errands")]
        [JsonProperty]
        public bool DisableFabricate { get; set; }

        [Option("DisableFarm", "Disable Farm Supply Errands")]
        [JsonProperty]
        public bool DisableFarm { get; set; }

        [Option("DisableMachine", "Disable Machine Supply Errands")]
        [JsonProperty]
        public bool DisableMachine { get; set; }

        [Option("DisableResearch", "Disable Research Supply Errands")]
        [JsonProperty]
        public bool DisableResearch { get; set; }

        public SupplyingExclusionsConfig()
        {
            DisableBuild = true;
            DisableCook = false;
            DisableDoctor = true;
            DisableFabricate = true;
            DisableFarm = true;
            DisableMachine = true;
            DisableResearch = true;
        }
    }
}
