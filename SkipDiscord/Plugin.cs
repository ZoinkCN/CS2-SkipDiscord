using BepInEx;
using HarmonyLib;

#if BEPINEX_V6
    using BepInEx.Unity.Mono;
#endif


namespace SkipDiscord
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            var harmony = new Harmony(MyPluginInfo.PLUGIN_NAME);
            harmony.PatchAll();
            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_NAME} is loaded!");
        }
    }
}
