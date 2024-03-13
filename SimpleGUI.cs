using MelonLoader;
using System;
using UnityEngine;

namespace SimpleGUI
{
    public class SimpleGUI : MelonMod
    {
        public override void OnGUI()
        {
            try
            {
                GUI.Label(new Rect(3f, 0f, 160f, 90f), $"<color=red>Day: </color><color=cyan>{DateTime.Now.DayOfWeek}\n</color>");
                GUI.Label(new Rect(3f, 12f, 160f, 90f), $"<color=red>Date: </color><color=cyan>{DateTime.Now.ToString("MM/dd/yyyy")}\n</color>");
                GUI.Label(new Rect(3f, 24f, 160f, 90f), $"<color=red>Time: </color><color=cyan>{DateTime.Now.ToString("h:mm:s tt")}\n</color>");
                GUI.Label(new Rect(3f, 36f, 160f, 90f), $"<color=red>FPS: </color><color=cyan>{(int)(1f / Time.unscaledDeltaTime)}\n</color>");
            }
            catch { MelonLogger.Msg("Failed To Create One Or More Of The GUI Labels - Likely An Issue Due To The Game or Another Mod Interfering"); }
        }
    }
}
