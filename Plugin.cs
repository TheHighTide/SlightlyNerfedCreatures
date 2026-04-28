using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace HighTide.Modding.SN.SlightlyNerfedCreatures
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string ModGuid = "com.hightide.modding.sn.slightlynerfedcreatures";
        private const string ModName = "Slightly Nerfed Creatures";
        private const string ModVersion = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(ModGuid);

        public static ManualLogSource Log;

        private void Awake()
        {
            Harmony.PatchAll();
            Logger.LogInfo($"{ModName} {ModVersion} has been loaded!");
            Log = Logger;
        }

        public static void SendLog(string message, LogLevel type = LogLevel.Info)
        {
            switch (type)
            {
                case LogLevel.Info:
                    Log.LogInfo(message);
                    break;
                case LogLevel.Warning:
                    Log.LogWarning(message);
                    break;
                case LogLevel.Error:
                    Log.LogError(message);
                    break;
                case LogLevel.Debug:
                    Log.LogDebug(message);
                    break;
            }
        }
    }
}
