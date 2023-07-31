using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace SlowModNS
{
    

    public class SlowMod : Mod
    {
        public void Awake() 
        {
            Settings.short_length = Config.GetEntry<float>("short_length", 90f);
            Settings.normal_length = Config.GetEntry<float>("normal_length", 120f);
            Settings.long_length = Config.GetEntry<float>("long_length", 200f);
            Settings.short_length.UI.Name = "Short Moon Length";
            Settings.normal_length.UI.Name = "Normal Moon Length";
            Settings.long_length.UI.Name = "Long Moon Length";
            Settings.short_length.UI.Tooltip = "seconds";
            Settings.normal_length.UI.Tooltip = "seconds";
            Settings.long_length.UI.Tooltip = "seconds";
            this.Harmony.PatchAll(typeof(Patches));
        }
        
        public override void Ready()
        {
            
        }
    }	
}