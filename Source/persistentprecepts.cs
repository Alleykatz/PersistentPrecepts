using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace PersistentPrecepts
{
    [StaticConstructorOnStartup]
    public static class PersistentPrecepts
    {
        static PersistentPrecepts() //our constructor
        {
            Log.Message("PersistentPrecepts Loaded"); //Outputs to the dev console.

            // apply Harmony patch
            Harmony harmony = new Harmony("rimworld.mod.alleykat.persistentprecepts");
            harmony.PatchAll();
        }
    }

    public class PersistentPreceptsConfig : Mod //setup the mod
    {
        public PersistentPreceptsConfig(ModContentPack content) : base(content)
        {
            // register your mod settings here if needed
            GetSettings<PersistentPreceptsSettings>();

            Log.Message("Persistent Precepts Mod class loaded");

        }
        public override void DoSettingsWindowContents(Rect inRect) //Add the toggle to mod settings menu too
        {
            Listing_Standard listing = new Listing_Standard();
            listing.Begin(inRect);

            listing.CheckboxLabeled("Persistent Precepts", ref PersistentPreceptsSettings.PersistentPreceptsCheckboxValue);

            listing.End();

            base.DoSettingsWindowContents(inRect);
        }
        public override string SettingsCategory() => "Persistent Precepts";
    }
    public class PersistentPreceptsSettings : ModSettings //setup the mod settings
    {
        public static bool PersistentPreceptsCheckboxValue = false;
    }

    [HarmonyPatch(typeof(IdeoUIUtility), "DoIdeoListAndDetails")]
    public static class Patch_DoIdeoListAndDetails //edits the ideoligion edit screen
    {
        public static void Postfix(ref Vector2 scrollPosition_list, ref float scrollViewHeight_list, ref Vector2 scrollPosition_details, ref float scrollViewHeight_details)
        {

            Listing_Standard listing = new Listing_Standard();
            listing.Begin(new Rect(500f, 0f, 150f, 24f));   // create the checkbox 500 pixels to the right on ideoligion edit screen

            bool newCheckboxValue = PersistentPreceptsSettings.PersistentPreceptsCheckboxValue;
            listing.CheckboxLabeled("Persistent Precepts", ref PersistentPreceptsSettings.PersistentPreceptsCheckboxValue);

            listing.End();
        }
    }

    [HarmonyPatch(typeof(IdeoFoundation), "RandomizePrecepts")] //This is the actual harmony patch to the RandomizePrecepts method in Ideology. Only blocks the method when toggle is on.
    public static class Patch_RandomizePrecepts
    {
        public static bool Prefix(IdeoFoundation __instance)
        {
            if (PersistentPreceptsSettings.PersistentPreceptsCheckboxValue)
            {
                Log.Message("RandomizePrecepts blocked!");
                return false;
            }
            return true;
        }
    }
}