using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auctionHouse.clases
{
    class Operaciones
    {

        /// <summary>
        /// Genera los items defectivos de la aplicacion
        /// <para>      Genera 4 items por cada rama final del arbol</para>
        /// </summary>
        /// <returns>Item[]: Array de items defectivos</returns>
        private static Item[] altaDefectivaItems()
        {

            return new Item[]{
                //Weapon>H1>Dagger
                new Item(drawableItems.ayanad_life_dagger, "Ayanad Life Dagger", 270000, true, 100, "WeaponH1Dagger", Item.MYTHIC),
                new Item(drawableItems.crystal_icicle, "Crystal Icicle", 350500, true, 30, "WeaponH1Dagger", Item.DIVINE),
                new Item(drawableItems.delphinad_mountain_dagger, "Delphinad Mountain Dagger", 300000, true, 150, "WeaponH1Dagger", Item.BASIC),
                new Item(drawableItems.sacrificial_desire, "Sacrificial Desire", 75000, true, 400, "WeaponH1Dagger", Item.RARE),
                //Weapon>H1>Sword
                new Item(drawableItems.ayanad_life_sword, "Ayanad Life Sword", 300500, true, 290, "WeaponH1Sword", Item.ARCANE),
                new Item(drawableItems.deep_blue_sea, "Deep Blue Sea", 60500, true, 300, "WeaponH1Sword", Item.CRUDE),
                new Item(drawableItems.glowing_sealed_magnificent_sword, "Glowing Sealed Magnificent Sword", 400000, true, 20, "WeaponH1Sword", Item.HEROIC),
                new Item(drawableItems.hellkissed_sword, "Hellkissed Sword", 90000, true, 250, "WeaponH1Sword", Item.LEGENDARY),
                //Weapon>H1>Katana
                new Item(drawableItems.ayanad_gale_katana, "Ayanad Gale Katana", 375000, true, 70, "WeaponH1Katana", Item.EPIC),
                new Item(drawableItems.dirgebringer, "Dirgebringer", 50000, true, 200, "WeaponH1Katana", Item.RARE),
                new Item(drawableItems.fallen_moon, "Fallen Moon", 400000, true, 10, "WeaponH1Katana", Item.GRAND),
                new Item(drawableItems.survivor_butcher, "Survivor Butcher", 15500, true, 350, "WeaponH1Katana", Item.BASIC),
                //Weapon>H1>Shortspear
                new Item(drawableItems.crused_obsidian_shortspear, "Crused Obsidian Shortspear", 250000, true, 175, "WeaponH1Shortspear", Item.ARCANE),
                new Item(drawableItems.epherium_wave_shortspear, "Epherium Wave Shortspear", 300000, true, 200, "WeaponH1Shortspear", Item.BASIC),
                new Item(drawableItems.fangbane, "Fangbane", 75000, true, 400, "WeaponH1Shortspear", Item.DIVINE),
                new Item(drawableItems.hungry_snake_s_fang, "Hungry Snake's Fang", 20000, true, 200, "WeaponH1Shortspear", Item.HEROIC),
                //Weapon>H1>Axe
                new Item(drawableItems.ayanad_gale_axe, "Ayanad Gale Axe", 300000, true, 30, "WeaponH1Axe", Item.GRAND),
                new Item(drawableItems.crused_obsidian_axe, "Crused Obsidian Axe", 250000, true, 75, "WeaponH1Axe", Item.RARE),
                new Item(drawableItems.lost_garden_faded_axe, "Lost Garden Faded Axe", 30000, true, 400, "WeaponH1Axe", Item.CELESTIAL),
                new Item(drawableItems.sealed_ayanad_axe, "Sealed Ayanad Axe", 375000, true, 250, "WeaponH1Axe", Item.MYTHIC),
                //Weapon>H1>Club
                new Item(drawableItems.buffalo_bone_mace, "Buffalo Bone Mace", 60000, true, 350, "WeaponH1Club", Item.BASIC),
                new Item(drawableItems.delphinad_life_club, "Delphinad Life Club", 175000, true, 100, "WeaponH1Club", Item.CELESTIAL),
                new Item(drawableItems.merciful_sunset, "Merciful Sunset", 30500, true, 350, "WeaponH1Club", Item.GRAND),
                new Item(drawableItems.scrap_dealer_s_truncheon, "Scrap Dealer's Truncheon", 190500, true, 150, "WeaponH1Club", Item.ARCANE),
                //Weapon>H1>Scepter
                new Item(drawableItems.apprentice_s_meadow_scepter, "Apprentice's Meadow Scepter", 10000, true, 250, "WeaponH1Scepter", Item.CRUDE),
                new Item(drawableItems.blind_fate, "Blind Fate", 50000, true, 200, "WeaponH1Scepter", Item.CELESTIAL),
                new Item(drawableItems.diviner_s_dream, "Diviner's Dream", 100500, true, 350, "WeaponH1Scepter", Item.EPIC),
                new Item(drawableItems.honor_s_mighty_vivacious_scepter, "Honor's Mighty Vivacious Scepter", 150000, true, 300, "WeaponH1Scepter", Item.DIVINE),
                //Weapon>H2>Greatsword
                new Item(drawableItems.archerfish_greatsword, "Archerfish Greatsword", 30000, true, 350, "WeaponH2Greatsword", Item.DIVINE),
                new Item(drawableItems.fir_queen_s_tears, "Fir Queen's Tears", 200000, true, 200, "WeaponH2Greatsword", Item.HEROIC),
                new Item(drawableItems.hellkissed_greatsword, "Hellkissed Greatsword", 85000, true, 390, "WeaponH2Greatsword", Item.RARE),
                new Item(drawableItems.kingsbane, "Kingsbane", 150000, true, 240, "WeaponH2Greatsword", Item.UNIQUE),
                //Weapon>H2>Nodachi
                new Item(drawableItems.dragonroar_nodachi, "Dragonroar Nodachi", 400000, true, 10, "WeaponH2Nodachi", Item.GRAND),
                new Item(drawableItems.epherium_sky_nodachi, "Epherium Sky Nodachi", 250000, true, 200, "WeaponH2Nodachi", Item.LEGENDARY),
                new Item(drawableItems.hellkissed_nodachi, "Hellkissed Nodachi", 30000, true, 400, "WeaponH2Nodachi", Item.CRUDE),
                new Item(drawableItems.honor_s_mighty_frenzied_nodachi, "Honor's Mighty Frenzied Nodachi", 68000, true, 380, "WeaponH2Nodachi", Item.ARCANE),
                //Weapon>H2>Longspear
                new Item(drawableItems.artificer_s_squall_longspear, "Artificer's Squall Longspear", 85500, true, 350, "WeaponH2Longspear", Item.GRAND),
                new Item(drawableItems.glowing_sealed_epherium_longspear, "Glowing Sealed Epherium Longspear", 350000, true, 75, "WeaponH2Longspear", Item.HEROIC),
                new Item(drawableItems.rekas_s_longspear, "Rekas's Longspear", 25000, true, 300, "WeaponH2Longspear", Item.MYTHIC),
                new Item(drawableItems.sea_god_s_wrath, "Sea God's Wrath", 400000, true, 10, "WeaponH2Longspear", Item.CRUDE),
                //Weapon>H2>Greataxe
                new Item(drawableItems.bone_carved_pain, "Bone-Carved Pain", 40000, true, 250, "WeaponH2Greataxe", Item.RARE),
                new Item(drawableItems.festering_amputator, "Festering Amputator", 9000, true, 400, "WeaponH2Greataxe", Item.ARCANE),
                new Item(drawableItems.honor_s_mighty_silent_greataxe, "Honor's Mighty Silent Greataxe", 75000, true, 300, "WeaponH2Greataxe", Item.LEGENDARY),
                new Item(drawableItems.shock_and_awe, "Shock and Awe", 25500, true, 400, "WeaponH2Greataxe", Item.CRUDE),
                //Weapon>H2>Greatclub
                new Item(drawableItems.crused_obsidian_greatclub, "Crused Obsidian Greatclub", 125000, true, 250, "WeaponH2Greatclub", Item.BASIC),
                new Item(drawableItems.embalmer_s_weeping, "Embalmer's Weeping", 40000, true, 400, "WeaponH2Greatclub", Item.CELESTIAL),
                new Item(drawableItems.matronfist_greatclub, "Matronfist Greatclub", 250000, true, 100, "WeaponH2Greatclub", Item.EPIC),
                new Item(drawableItems.nui_s_devotion, "Nui's Devotion", 375500, true, 20, "WeaponH2Greatclub", Item.GRAND),
                //Weapon>H2>Staff
                new Item(drawableItems.berserk_red_dragon_roar, "Berserk Red Dragon Roar", 75000, true, 350, "WeaponH2Staff", Item.CRUDE),
                new Item(drawableItems.eternal_prophet, "Eternal Prophet", 90000, true, 340, "WeaponH2Staff", Item.MYTHIC),
                new Item(drawableItems.lidless_rage, "Lidless Rage", 250000, true, 200, "WeaponH2Staff", Item.RARE),
                new Item(drawableItems.maliceforged_staff, "Maliceforged Staff", 375000, true, 150, "WeaponH2Staff", Item.ARCANE),
                //Weapon>Ranged>Bow
                new Item(drawableItems.delphinad_tidal_bow, "Delphinad Tidal Bow", 350500, true, 100, "WeaponRangedBow", Item.RARE),
                new Item(drawableItems.fugitive, "Fugitive", 375000, true, 50, "WeaponRangedBow", Item.GRAND),
                new Item(drawableItems.hellkissed_bow, "Hellkissed Bow", 60000, true, 400, "WeaponRangedBow", Item.MYTHIC),
                new Item(drawableItems.ruler_s_bow, "Ruler's Bow", 400000, true, 50, "WeaponRangedBow", Item.ARCANE),
                //Weapon>Shield
                new Item(drawableItems.anticipation, "Anticipation", 345500, true, 150, "WeaponShield", Item.ARCANE),
                new Item(drawableItems.homecoming_shield, "Homecoming Shield", 400000, true, 50, "WeaponShield", Item.DIVINE),
                new Item(drawableItems.jola_s_eternal_grudge, "Jola's Eternal Grudge", 385000, true, 100, "WeaponShield", Item.EPIC),
                new Item(drawableItems.maliceforged_shield, "Maliceforged Shield", 270500, true, 125, "WeaponShield", Item.CRUDE),
                //Armor>Cloth>Head
                new Item(drawableItems.corrupted_kyrios_hood, "Corrupted Kyrios Hood", 150000, true, 50, "ArmorClothHead", Item.DIVINE),
                new Item(drawableItems.maliceforged_hood, "Maliceforged Hood", 75000, true, 400, "ArmorClothHead", Item.BASIC),
                new Item(drawableItems.morpheus_mask, "Morpheus Mask", 1000, true, 300, "ArmorClothHead", Item.ARCANE),
                new Item(drawableItems.skybright_hood, "Skybright Hood", 15000, true, 75, "ArmorClothHead", Item.RARE),
                //Armor>Cloth>Chest
                new Item(drawableItems.corrupted_kyrios_shirt, "Corrupted Kyrios Shirt", 250000, true, 10, "ArmorClothChest", Item.GRAND),
                new Item(drawableItems.glenn_s_admiral_jacket, "Glenn's Admiral Jacket", 20000, true, 20, "ArmorClothChest", Item.HEROIC),
                new Item(drawableItems.maliceforged_shirt, "Maliceforged Shirt", 50000, true, 400, "ArmorClothChest", Item.MYTHIC),
                new Item(drawableItems.skybright_shirt, "Skybright Shirt", 90000, true, 125, "ArmorClothChest", Item.UNIQUE),
                //Armor>Cloth>Waist
                new Item(drawableItems.corrupted_kyrios_sash, "Corrupted Kyrios Sash", 75000, true, 200, "ArmorClothWaist", Item.EPIC),
                new Item(drawableItems.glenn_s_sash, "Glenn's Sash", 50000, true, 150, "ArmorClothWaist", Item.GRAND),
                new Item(drawableItems.jester_king_s_sash, "Jester King's Sash", 30000, true, 300, "ArmorClothWaist", Item.CRUDE),
                new Item(drawableItems.skybright_sash, "Skybright Sash", 5000, true, 200, "ArmorClothWaist", Item.ARCANE),
                //Armor>Cloth>Wirst
                new Item(drawableItems.corrupted_kyrios_sleeves, "Corrupted Kyrios Sleeves", 50000, true, 150, "ArmorClothWirst", Item.CELESTIAL),
                new Item(drawableItems.glenn_s_sleeves, "Glenn's Sleeves", 40000, true, 100, "ArmorClothWirst", Item.UNIQUE),
                new Item(drawableItems.jester_king_s_sleeves, "Jester King's Sleeves", 20000, true, 400, "ArmorClothWirst", Item.RARE),
                new Item(drawableItems.skybright_sleeves, "Skybright Sleeves", 20000, true, 100, "ArmorClothWirst", Item.ARCANE),
                //Armor>Cloth>Hands
                new Item(drawableItems.corrupted_kyrios_gloves, "Corrupted Kyrios Gloves", 175000, true, 10, "ArmorClothHands", Item.BASIC),
                new Item(drawableItems.epherium_ocean_gloves, "Epherium Ocean Gloves", 400000, true, 30, "ArmorClothHands", Item.LEGENDARY),
                new Item(drawableItems.glenn_s_gloves, "Glenn's Gloves", 27500, true, 10, "ArmorClothHands", Item.GRAND),
                new Item(drawableItems.skybringht_gloves, "Skybringht Gloves", 60000, true, 50, "ArmorClothHands", Item.DIVINE),
                //Armor>Cloth>Legs
                new Item(drawableItems.corrupted_kyrios_pants, "corrupted kyrios pants", 200000, true, 75, "ArmorClothLegs", Item.CRUDE),
                new Item(drawableItems.epherium_ocean_pants, "epherium ocean pants", 250000, true, 40, "ArmorClothLegs", Item.ARCANE),
                new Item(drawableItems.glenn_s_pants, "glenn's pants", 40000, true, 250, "ArmorClothLegs", Item.UNIQUE),
                new Item(drawableItems.skybright_pants, "skybright pants", 60000, true, 100, "ArmorClothLegs", Item.GRAND),
                //Armor>Cloth>Feet
                new Item(drawableItems.corrupted_kyrios_shoes, "Corrupted Kyrios Shoes", 200000, true, 10, "ArmorClothFeet", Item.HEROIC),
                new Item(drawableItems.epherium_ocean_shoes, "Epherium Ocean Shoes", 50500, true, 75, "ArmorClothFeet", Item.EPIC),
                new Item(drawableItems.glenn_s_boots, "Glenn's Boots", 40000, true, 75, "ArmorClothFeet", Item.MYTHIC),
                new Item(drawableItems.skybright_shoes, "Skybright Shoes", 100000, true, 100, "ArmorClothFeet", Item.RARE),
                //Armor>Leather>Head
                new Item(drawableItems.auroria_beldame_cap, "Auroria Beldame Cap", 90000, true, 200, "ArmorLeatherHead", Item.GRAND),
                new Item(drawableItems.cursed_obsidian_cap, "Cursed Obsidian Cap", 150000, true, 50, "ArmorLeatherHead", Item.MYTHIC),
                new Item(drawableItems.dawnsdrop_cap, "Dawnsdrop Cap", 12000, true, 400, "ArmorLeatherHead", Item.ARCANE),
                new Item(drawableItems.jaya_s_cap, "Jaya's Cap", 60000, true, 300, "ArmorLeatherHead", Item.HEROIC),
                //Armor>Leather>Chest
                new Item(drawableItems.auroira_beldame_jerkin, "Auroira Beldame Jerkin", 50000, true, 200, "ArmorLeatherChest", Item.UNIQUE),
                new Item(drawableItems.cursed_obsidian_jerkin, "Cursed Obsidian Jerkin", 125000, true, 100, "ArmorLeatherChest", Item.LEGENDARY),
                new Item(drawableItems.dawnsdrop_jerkin, "Dawnsdrop Jerkin", 12000, true, 400, "ArmorLeatherChest", Item.GRAND),
                new Item(drawableItems.jaya_s_jerkin, "Jaya's Jerkin", 30000, true, 200, "ArmorLeatherChest", Item.CRUDE),
                //Armor>Leather>Waist
                new Item(drawableItems.auroria_beldame_belt, "Auroria Beldame Belt", 80000, true, 250, "ArmorLeatherWaist", Item.ARCANE),
                new Item(drawableItems.dawnsdrop_belt, "Dawnsdrop Belt", 12000, true, 400, "ArmorLeatherWaist", Item.BASIC),
                new Item(drawableItems.high_inquisitor_s_belt, "High Inquisitor's Belt", 40000, true, 300, "ArmorLeatherWaist", Item.CELESTIAL),
                new Item(drawableItems.jaya_s_belt, "Jaya's Belt", 35000, true, 300, "ArmorLeatherWaist", Item.DIVINE),
                //Armor>Leather>Wirst
                new Item(drawableItems.auroria_beldame_guards, "Auroria Beldame Guards", 60000, true, 250, "ArmorLeatherWirst", Item.HEROIC),
                new Item(drawableItems.dawnsdrop_guards, "Dawnsdrop Guards", 12000, true, 400, "ArmorLeatherWirst", Item.RARE),
                new Item(drawableItems.jaya_s_guards, "Jaya's Guards", 40000, true, 300, "ArmorLeatherWirst", Item.GRAND),
                new Item(drawableItems.magnificent_squall_guards, "Magnificent Squall Guards", 100000, true, 100, "ArmorLeatherWirst", Item.BASIC),
                //Armor>Leather>Hands
                new Item(drawableItems.auroria_beldame_fists, "Auroria Beldame Fists", 80000, true, 150, "ArmorLeatherHands", Item.DIVINE),
                new Item(drawableItems.cursed_obsidian_fists, "Cursed Obsidian Fists", 175000, true, 100, "ArmorLeatherHands", Item.CELESTIAL),
                new Item(drawableItems.dawnsdrop_fists, "Dawnsdrop Fists", 12000, true, 400, "ArmorLeatherHands", Item.EPIC),
                new Item(drawableItems.jaya_s_fists, "Jaya's Fists", 40000, true, 250, "ArmorLeatherHands", Item.ARCANE),
                //Armor>Leather>Legs
                new Item(drawableItems.auroria_beldame_breeches, "Auroria Beldame Breeches", 85000, true, 250, "ArmorLeatherLegs", Item.MYTHIC),
                new Item(drawableItems.cursed_obsidian_breeches, "Cursed Obsidian Breeches", 100000, true, 75, "ArmorLeatherLegs", Item.GRAND),
                new Item(drawableItems.dawnsdrop_breeches, "Dawnsdrop Breeches", 12000, true, 400, "ArmorLeatherLegs", Item.RARE),
                new Item(drawableItems.jaya_s_breeches, "Jaya's Breeches", 40000, true, 350, "ArmorLeatherLegs", Item.UNIQUE),
                //Armor>Leather>Feet
                new Item(drawableItems.auroria_beldame_boots, "Auroria Beldame Boots", 75000, true, 150, "ArmorLeatherFeet", Item.HEROIC),
                new Item(drawableItems.cursed_obsidian_boots, "Cursed Obsidian Boots", 200000, true, 100, "ArmorLeatherFeet", Item.CRUDE),
                new Item(drawableItems.dawnsdrop_boots, "Dawnsdrop Boots", 12000, true, 400, "ArmorLeatherFeet", Item.GRAND),
                new Item(drawableItems.jaya_s_boots, "Jaya's Boots", 40000, true, 250, "ArmorLeatherFeet", Item.BASIC),
                //Armor>Plate>Head
                new Item(drawableItems.annihilator_s_helm, "Annihilator's Helm", 55000, true, 350, "ArmorPlateHead",Item.CRUDE),
                new Item(drawableItems.ardent_oath_helm, "Ardent Oath Helm", 27000, true, 160, "ArmorPlateHead", Item.DIVINE),
                new Item(drawableItems.delphinad_desert_helm, "Delphinad Desert Helm", 127500, true, 90, "ArmorPlateHead", Item.EPIC),
                new Item(drawableItems.hexbane_helm, "Hexbane Helm", 90500, true, 275, "ArmorPlateHead", Item.MYTHIC),
                //Armor>Plate>Chest
                new Item(drawableItems.annihilator_s_cuirass, "Annihilator's Cuirass", 50000, true, 300, "ArmorPlateChest", Item.RARE),
                new Item(drawableItems.ardent_oath_cuirass, "Ardent Oath Cuirass", 200000, true, 200, "ArmorPlateChest", Item.UNIQUE),
                new Item(drawableItems.delphinad_desert_cuirass, "Delphinad Desert Cuirass", 150000, true, 90, "ArmorPlateChest", Item.GRAND),
                new Item(drawableItems.hexbane_cuirass, "Hexbane Cuirass", 40000, true, 275, "ArmorPlateChest", Item.EPIC),
                //Armor>Plate>Waist
                new Item(drawableItems.ardent_oath_tassets, "Ardent Oath Tassets", 95500, true, 375, "ArmorPlateWaist", Item.DIVINE),
                new Item(drawableItems.delphinad_desert_tassets, "Delphinad Desert Tassets", 75000, true, 150, "ArmorPlateWaist", Item.HEROIC),
                new Item(drawableItems.hexbane_tassets, "Hexbane Tassets", 85000, true, 350, "ArmorPlateWaist", Item.RARE),
                new Item(drawableItems.yaksa_general_s_tassets, "Yaksa General's Tassets", 30000, true, 245, "ArmorPlateWaist", Item.CELESTIAL),
                //Armor>Plate>Wirst
                new Item(drawableItems.ardent_oath_vambraces, "Ardent Oath Vambraces", 105500, true, 385, "ArmorPlateWirst", Item.ARCANE),
                new Item(drawableItems.yaksa_general_s_vambraces, "Yaksa General's Vambraces", 25000, true, 260, "ArmorPlateWirst", Item.BASIC),
                new Item(drawableItems.delphinad_desert_vambraces, "Delphinad Desert Vambraces", 375000, true, 50, "ArmorPlateWirst", Item.UNIQUE),
                new Item(drawableItems.hexbane_vambraces, "Hexbane Vambraces", 40000, true, 240, "ArmorPlateWirst", Item.HEROIC),
                //Armor>Plate>Hands
                new Item(drawableItems.annihilator_s_gauntlets, "Annihilator's Gauntlets", 35000, true, 300, "ArmorPlateHands", Item.LEGENDARY),
                new Item(drawableItems.ardent_oath_gauntlets, "Ardent Oath Gauntlets", 160000, true, 140, "ArmorPlateHands", Item.RARE),
                new Item(drawableItems.delphinad_desert_gauntlets, "Delphinad Desert Gauntlets", 120000, true, 80, "ArmorPlateHands", Item.BASIC),
                new Item(drawableItems.hexbane_gauntlets, "Hexbane Gauntlets", 85000, true, 300, "ArmorPlateHands", Item.CRUDE),
                //Armor>Plate>Legs
                new Item(drawableItems.annihilator_s_greaves, "Annihilator's Greaves", 85500, true, 400, "ArmorPlateLegs", Item.MYTHIC),
                new Item(drawableItems.ardent_oath_greaves, "Ardent Oath Greaves", 37500, true, 175, "ArmorPlateLegs", Item.CELESTIAL),
                new Item(drawableItems.delphinad_desert_greaves, "Delphinad Desert Greaves", 145000, true, 45, "ArmorPlateLegs", Item.DIVINE),
                new Item(drawableItems.hexbane_greaves, "Hexbane Greaves", 85500, true, 250, "ArmorPlateLegs", Item.ARCANE),
                //Armor>Plate>Feet
                new Item(drawableItems.annihilator_s_sabatons, "Annihilator's Sabatons", 60000, true, 250, "ArmorPlateFeet", Item.CELESTIAL),
                new Item(drawableItems.ardent_oath_sabatons, "Ardent Oath Sabatons", 190000, true, 150, "ArmorPlateFeet", Item.BASIC),
                new Item(drawableItems.delphinad_desert_sabatons, "Delphinad Desert Sabatons", 140000, true, 80, "ArmorPlateFeet", Item.DIVINE),
                new Item(drawableItems.hexbane_sabatons, "Hexbane Sabatons", 50000, true, 250, "ArmorPlateFeet", Item.GRAND),
                //Armor>Cloak
                new Item(drawableItems.bird_of_prey_cloak, "Bird of Prey Cloak", 10000, true, 600, "ArmorCloak", Item.RARE),
                new Item(drawableItems.cloak_of_unbinding, "Cloak of Unbinding", 20000, true, 400, "ArmorCloak", Item.GRAND),
                new Item(drawableItems.dream_hunter_s_cloak, "Dream Hunter's Cloak", 20000, true, 400, "ArmorCloak", Item.HEROIC),
                new Item(drawableItems.sage_s_cloak, "Sage's Cloak", 20000, true, 400, "ArmorCloak", Item.DIVINE),
                //Accessories>Earrings
                new Item(drawableItems.forgotten_rhythm, "Forgotten Rhythm", 30000, true, 50, "AccessoriesEarrings", Item.RARE),
                new Item(drawableItems.illustrious_earth_earring, "Illustrious Earth Earring", 50000, true, 20, "AccessoriesEarrings", Item.UNIQUE),
                new Item(drawableItems.illustrious_flame_earring, "Illustrious Flame Earring", 50000, true, 20, "AccessoriesEarrings", Item.CRUDE),
                new Item(drawableItems.shroudmaster_earring, "Shroudmaster Earring", 10000, true, 40, "AccessoriesEarrings", Item.BASIC),
                //Accessories>Necklace
                new Item(drawableItems.apprentice_s_flame_necklace, "Apprentice's Flame Necklace", 15000, true, 40, "AccessoriesNecklace", Item.DIVINE),
                new Item(drawableItems.conqueror_s_wave_necklace, "Conqueror's Wave Necklace", 40000, true, 100, "AccessoriesNecklace", Item.LEGENDARY),
                new Item(drawableItems.craftsman_s_life_necklace, "Craftsman's Life Necklace", 10000, true, 100, "AccessoriesNecklace", Item.MYTHIC),
                new Item(drawableItems.glowing_sealed_illustrious_necklace, "Glowing Sealed Illustrious Necklace", 75000, true, 10, "AccessoriesNecklace", Item.GRAND),
                //Accessories>Ring
                new Item(drawableItems.craftsman_s_wave_ring, "Craftsman's Wave Ring", 10000, true, 100, "AccessoriesRing", Item.ARCANE),
                new Item(drawableItems.harbinger_s_ring, "Harbinger's Ring", 90000, true, 30, "AccessoriesRing", Item.MYTHIC),
                new Item(drawableItems.illustrious_earth_ring, "Illustrious Earth Ring", 60000, true, 75, "AccessoriesRing", Item.HEROIC),
                new Item(drawableItems.magnificent_gale_ring, "Magnificent Gale Ring", 75000, true, 60, "AccessoriesRing", Item.GRAND),
                //Instrument>Flute
                new Item(drawableItems.fantasia_of_sorcery, "Fantasia of Sorcery", 200000, true, 400, "InstrumentFlute", Item.MYTHIC),
                new Item(drawableItems.frozen_snowflower_pipe, "Frozen Snowflower Pipe", 3000000, true, 200, "InstrumentFlute", Item.UNIQUE),
                new Item(drawableItems.lost_garden_faded_flute, "Lost Garden Faded Flute", 17500, true, 150, "InstrumentFlute", Item.GRAND),
                new Item(drawableItems.wayfaring_jester, "Wayfaring Jester", 25000, true, 140, "InstrumentFlute", Item.DIVINE),
                //Instrument>Lute
                new Item(drawableItems.aria_of_archery, "Aria of Archery", 175000, true, 300, "InstrumentLute", Item.DIVINE),
                new Item(drawableItems.enchanting_scroll, "Enchanting Scroll", 200000, true, 50, "InstrumentLute", Item.GRAND),
                new Item(drawableItems.epherium_tidal_lute, "Epherium Tidal Lute", 300000, true, 25, "InstrumentLute", Item.ARCANE),
                new Item(drawableItems.tempting_illusion_lute, "Tempting Illusion Lute", 375000, true, 10, "InstrumentLute", Item.EPIC),
            };
        }

        /// <summary>
        /// Carga en memoria los items defectivos y les establece un codigo autoincremental
        /// </summary>
        /// <returns>Item[] items: Array de items defectivos</returns>
        public static Item[] cargarItems()
        {
            Item[] items = altaDefectivaItems();
            for (int i = 0; i < items.Length; i++)
            {

                items[i].codigo = i;
            }

            return items;
        }
    }
}
