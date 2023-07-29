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
            if (WorldManager.instance.CurrentRunOptions.MoonLength == MoonLength.Short) __result = 150f;
            else if (WorldManager.instance.CurrentRunOptions.MoonLength == MoonLength.Normal) __result = 240f;
            else if (WorldManager.instance.CurrentRunOptions.MoonLength == MoonLength.Long) __result = 450f;
            else __result = 240f;
            return false;
        }
    }
}
