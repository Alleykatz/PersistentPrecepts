# Persistent Precepts
Persistent Precepts is a mod for Rimworld that adds a simple toggle to the Ideology edit screen that prevents the re-randomization of Ideology precepts, rituals, buildings etc. when you change structure or memes.

With this mod, you can ensure that your carefully crafted Ideology remains intact, even if you go back and change structure/memes. This also means your saved ideoligions can better act as templates when you load them in.

When the toggle is on, ideology re-randomization for the player is blocked for:
- Precepts
- Roles
-	Rituals
- Buildings
- Relics
-	Weapons
-	Venerated Animals
-	Preferred Xenotypes
-	Preferred Apparel
-	Appearance (Hair, Beards, Tattoos)

**Please note:** The confirmation warning of re-randomizing precepts still comes up, please ignore it for now while I work out how to change the confirmation dialogue. 

If you start a new game and forget to turn the toggle off, your faction's ideology will be generated without any precepts/rituals etc. This is easily fixed by flicking the toggle back off and selecting "Randomize Precepts" button. Other factions generated at world creation and as part of events are not impacted.

### Compatibility
The mod uses harmony to patch a few methods related to player actions on the ideology edit screen and precept randomization. It touches nothing else besides adding the checkbox so should be highly compatible with other mods.

### Thanks
- Mute for reviewing my code and being generally awesome with guidance, especially with how to approach limiting the toggle to only affect player actions.
- Mile for giving me advice and a friendly space to get help and feedback.
- Rimworld modding community, this is my first ever mod and I couldn't have done it without supportive people in discord.

### Credits
Thumbnail dice icon - by Delapouite (games-icons.net)

Thumbnail font - [Marnador's fan made font](https://ludeon.com/forums/index.php?topic=11022.0)
  
 ### Done:
-Toggle that blocks precept randomization (added to both ideoligion edit screen and mod settings option)
-Toggle only blocks precept randomization on player initiated action. This prevents the toggle from blocking precept generation when the game generates faction ideologies.

### To do:
-Update Dialogue window warning about Precept Randomization when changing memes.
