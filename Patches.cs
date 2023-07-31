using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SlowModNS
{
    public class Patches
    {
        
        [HarmonyPrefix]
        [HarmonyPatch(typeof(WorldManager), nameof(WorldManager.MonthTime), MethodType.Getter)]
        public static bool Prefix(ref float __result)
        {
            if (WorldManager.instance.CurrentRunOptions.MoonLength == MoonLength.Short) __result = Settings.short_length.Value;
            else if (WorldManager.instance.CurrentRunOptions.MoonLength == MoonLength.Normal) __result = Settings.normal_length.Value;
            else if (WorldManager.instance.CurrentRunOptions.MoonLength == MoonLength.Long) __result = Settings.long_length.Value;
            else __result = 240f;
            return false;
        }
    }
}
