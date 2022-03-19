using Newtonsoft.Json;
using System;
using PeterHan.PLib.Options;

namespace ONI_SupplyingExclusions
{
    [JsonObject(MemberSerialization.OptIn)]
    [ModInfo("https://github.com/leehuk/oni-supplyingexclusions/")]
    [RestartRequired()]
    public class SupplyingExclusionsConfig
    {

        [Option("ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_OPTION_DISABLE_BUILD", "ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_DETAIL_DISABLE_BUILD", null)]
        [JsonProperty]
        public bool DisableBuild { get; set; }

        [Option("ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_OPTION_DISABLE_COOK", "ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_DETAIL_DISABLE_COOK", null)]
        [JsonProperty]
        public bool DisableCook { get; set; }

        [Option("ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_OPTION_DISABLE_DOCTOR", "ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_DETAIL_DISABLE_DOCTOR", null)]
        [JsonProperty]
        public bool DisableDoctor { get; set; }

        [Option("ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_OPTION_DISABLE_FABRICATE", "ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_DETAIL_DISABLE_FABRICATE", null)]
        [JsonProperty]
        public bool DisableFabricate { get; set; }

        [Option("ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_OPTION_DISABLE_FARM", "ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_DETAIL_DISABLE_FARM", null)]
        [JsonProperty]
        public bool DisableFarm { get; set; }

        [Option("ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_OPTION_DISABLE_MACHINE", "ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_DETAIL_DISABLE_MACHINE", null)]
        [JsonProperty]
        public bool DisableMachine { get; set; }

        [Option("ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_OPTION_DISABLE_RESEARCH", "ONI_SupplyingExclusions.SupplyingExclusionsStrings.STRING_SUPEXL_DETAIL_DISABLE_RESEARCH", null)]
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
