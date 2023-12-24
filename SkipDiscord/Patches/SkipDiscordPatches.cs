using BepInEx.Logging;
using Colossal.PSI.Discord;
using HarmonyLib;

namespace SkipDiscord.Patches
{
    [HarmonyPatch]
    public class SkipDiscordPatches
    {
        private static ManualLogSource logger = Logger.CreateLogSource(MyPluginInfo.PLUGIN_NAME);
        [HarmonyPatch(typeof(DiscordRichPresence), "Initialize")]
        [HarmonyPrefix]
        public static bool PreFix(ref bool ___m_IsInitialized)
        {
            ___m_IsInitialized = true;
            return true;
        }
    }
}
