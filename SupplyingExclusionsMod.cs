using HarmonyLib;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Database;
using PeterHan.PLib.Options;
using System.Reflection;

namespace ONI_SupplyingExclusions
{
    public class SupplyingExclusionsMod : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);

            PUtil.InitLibrary(true);
            new PLocalization().Register(null);
            new POptions().RegisterOptions(this, typeof(SupplyingExclusionsConfig));

            Debug.Log("Supplying Exclusions: Loaded " + Assembly.GetExecutingAssembly().GetName().Version);
        }

    }
}
