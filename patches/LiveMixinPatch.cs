using HarmonyLib;

namespace HighTide.Modding.SN.SlightlyNerfedCreatures.Patches
{
    [HarmonyPatch(typeof(LiveMixin))]
    internal class LiveMixinPatch
    {
        [HarmonyPatch(nameof(LiveMixin.Start))]
        [HarmonyPostfix]
        private static void Start_Postfix(LiveMixin __instance)
        {
            if (!__instance.player && !__instance.invincible) {
                __instance.data.maxHealth = 1;
                __instance.health = 1;
            }
        }
    }
}
