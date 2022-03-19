using HarmonyLib;
using PeterHan.PLib.Options;
using System.Collections.Generic;

namespace ONI_SupplyingExclusions
{
    [HarmonyPatch(typeof(Database.ChoreTypes))]
    [HarmonyPatch("Add")]
    public static class ChoreTypes_Add
    {
        public static void Prefix(string id, ref string[] chore_groups, string urge, string[] interrupt_exclusion, string name, string status_message, string tooltip, bool skip_implicit_priority_change, int explicit_priority, string report_name)
        {
            SupplyingExclusionsConfig config = (POptions.ReadSettings<SupplyingExclusionsConfig>() ?? new SupplyingExclusionsConfig());

            if (id == "BuildFetch" && config.DisableBuild == true || id == "CookFetch" && config.DisableCook || id == "DoctorFetch" && config.DisableDoctor == true || id == "FabricateFetch" && config.DisableFabricate == true || id == "FarmFetch" && config.DisableFarm == true || id == "MachineFetch" && config.DisableMachine == true || id == "ResearchFetch" && config.DisableResearch == true)
            {
                Debug.Log("Supplying Exclusions: Found Chore: " + id);

                string[] new_chore_groups = ChoreHaulFilter(chore_groups).ToArray();
                if(chore_groups.Length != new_chore_groups.Length)
                {
                    Debug.Log("Supplying Exclusions: Filtered Hauling From Chore: " + id);
                    chore_groups = new_chore_groups;
                }
            }
        }

        private static List<string> ChoreHaulFilter(string[] chore_groups)
        {
            List<string> new_chore_groups = new List<string>();
            for (int i = 0; i < chore_groups.Length; i++)
            {
                if (chore_groups[i] == "Hauling")
                {
                    continue;
                }
                new_chore_groups.Add(chore_groups[i]);
            }

            return new_chore_groups;
        }
    }
}
