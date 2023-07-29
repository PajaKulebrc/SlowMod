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
            this.Harmony.PatchAll(typeof(Patches));
        }
        
        public override void Ready()
        {
            
        }
    }	
}