﻿using System.Linq;

namespace PKHeX.Core
{
    public static partial class Legal
    {
        internal const int MaxSpeciesIndex_5_BW = 667;
        internal const int MaxSpeciesIndex_5_B2W2 = 708;
        internal const int MaxSpeciesID_5 = 649;
        internal const int MaxMoveID_5 = 559;
        internal const int MaxItemID_5_BW = 632;
        internal const int MaxItemID_5_B2W2 = 638;
        internal const int MaxAbilityID_5 = 164;
        internal const int MaxBallID_5 = 0x19;
        internal const int MaxGameID_5 = 23; // B2

        internal static readonly int[] Met_BW2c = { 0, 60002, 30003 };

        internal static readonly int[] Met_BW2_0 =
        {
            1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47,
            48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
            75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101,
            102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123,
            124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 143, 144, 145, 146,
            147, 148, 149, 150, 151, 152, 153,
        };

        internal static readonly int[] Met_BW2_3 =
        {
            30001, 30002, 30004, 30005, 30006, 30007, 30008, 30010, 30011, 30012,
            30013, 30014, 30015,
        };

        internal static readonly int[] Met_BW2_4 =
        {
            40001, 40002, 40003, 40004, 40005, 40006, 40007, 40008, 40009, 40010,
            40011, 40012, 40013, 40014, 40015, 40016, 40017, 40018, 40019, 40020, 40021, 40022, 40023, 40024, 40025,
            40026, 40027, 40028, 40029, 40030, 40031, 40032, 40033, 40034, 40035, 40036, 40037, 40038, 40039, 40040,
            40041, 40042, 40043, 40044, 40045, 40046, 40047, 40048, 40049, 40050, 40051, 40052, 40053, 40054, 40055,
            40056, 40057, 40058, 40059, 40060, 40061, 40062, 40063, 40064, 40065, 40066, 40067, 40068, 40069, 40070,
            40071, 40072, 40073, 40074, 40075, 40076, 40077, 40078, 40079, 40080, 40081, 40082, 40083, 40084, 40085,
            40086, 40087, 40088, 40089, 40090, 40091, 40092, 40093, 40094, 40095, 40096, 40097, 40098, 40099, 40100,
            40101, 40102, 40103, 40104, 40105, 40106, 40107, 40108, 40109,
        };

        internal static readonly int[] Met_BW2_6 = { 60001, 60003 };

        internal static readonly ushort[] Pouch_Items_BW = {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 116, 117, 118, 119, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290, 291, 292, 293, 294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 492, 493, 494, 495, 496, 497, 498, 499, 500, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 571, 572, 573, 575, 576, 577, 580, 581, 582, 583, 584, 585, 586, 587, 588, 589, 590,
        };
        internal static readonly ushort[] Pouch_Key_BW = {
            437, 442, 447, 450, 465, 466, 471, 504, 533, 574, 578, 579, 616, 617, 621, 623, 624, 625, 626,
        };
        internal static readonly ushort[] Pouch_TMHM_BW = {
            328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 618, 619, 620, 420, 421, 422, 423, 424, 425
        };
        internal static readonly ushort[] Pouch_Medicine_BW = {
            17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 134, 504, 565, 566, 567, 568, 569, 570, 591
        };
        internal static readonly ushort[] Pouch_Berries_BW = {
            149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212
        };
        internal static readonly ushort[] HeldItems_BW = new ushort[1].Concat(Pouch_Items_BW).Concat(Pouch_Medicine_BW).Concat(Pouch_Berries_BW).ToArray();
        
        internal static readonly ushort[] Pouch_Key_B2W2 = {
            437, 442, 447, 450, 453, 458, 465, 466, 471, 504, 578, 616, 617, 621, 626, 627, 628, 630, 631, 632, 633, 634, 635, 636, 637, 638,
        };
        internal static readonly int[] TMHM_BW =
        {
            468, 337, 473, 347, 046, 092, 258, 339, 474, 237,
            241, 269, 058, 059, 063, 113, 182, 240, 477, 219,
            218, 076, 479, 085, 087, 089, 216, 091, 094, 247,
            280, 104, 115, 482, 053, 188, 201, 126, 317, 332,
            259, 263, 488, 156, 213, 168, 490, 496, 497, 315,
            502, 411, 412, 206, 503, 374, 451, 507, 510, 511,
            261, 512, 373, 153, 421, 371, 514, 416, 397, 148,
            444, 521, 086, 360, 014, 522, 244, 523, 524, 157,
            404, 525, 526, 398, 138, 447, 207, 365, 369, 164,
            430, 433, 528, 249, 555,

            015, 019, 057, 070, 127, 291
        };

        internal static readonly int[] MovePP_BW =
        {
            00,
            35, 25, 10, 15, 20, 20, 15, 15, 15, 35, 30, 05, 10, 30, 30, 35, 35, 20, 15, 20, 20, 15, 20, 30, 05, 25, 15, 15, 15, 25, 20, 05, 35, 15, 20, 20, 10, 15, 30, 35, 20, 20, 30, 25, 40, 20, 15, 20, 20, 20,
            30, 25, 15, 30, 25, 05, 15, 10, 05, 20, 20, 20, 05, 35, 20, 25, 20, 20, 20, 15, 25, 15, 10, 40, 25, 10, 35, 30, 15, 10, 40, 10, 15, 30, 15, 20, 10, 15, 10, 05, 10, 10, 25, 10, 20, 40, 30, 30, 20, 20,
            15, 10, 40, 15, 10, 30, 20, 20, 10, 40, 40, 30, 30, 30, 20, 30, 10, 10, 20, 05, 10, 30, 20, 20, 20, 05, 15, 15, 20, 15, 15, 35, 20, 15, 10, 10, 30, 15, 40, 20, 15, 10, 05, 10, 30, 10, 15, 20, 15, 40,
            40, 10, 05, 15, 10, 10, 10, 15, 30, 30, 10, 10, 20, 10, 01, 01, 10, 10, 10, 05, 15, 25, 15, 10, 15, 30, 05, 40, 15, 10, 25, 10, 30, 10, 20, 10, 10, 10, 10, 10, 20, 05, 40, 05, 05, 15, 05, 10, 05, 10,
            10, 10, 10, 20, 20, 40, 15, 10, 20, 20, 25, 05, 15, 10, 05, 20, 15, 20, 25, 20, 05, 30, 05, 10, 20, 40, 05, 20, 40, 20, 15, 35, 10, 05, 05, 05, 15, 05, 20, 05, 05, 15, 20, 10, 05, 05, 15, 10, 15, 15,
            10, 10, 10, 20, 10, 10, 10, 10, 15, 15, 15, 10, 20, 20, 10, 20, 20, 20, 20, 20, 10, 10, 10, 20, 20, 05, 15, 10, 10, 15, 10, 20, 05, 05, 10, 10, 20, 05, 10, 20, 10, 20, 20, 20, 05, 05, 15, 20, 10, 15,
            20, 15, 10, 10, 15, 10, 05, 05, 10, 15, 10, 05, 20, 25, 05, 40, 10, 05, 40, 15, 20, 20, 05, 15, 20, 30, 15, 15, 05, 10, 30, 20, 30, 15, 05, 40, 15, 05, 20, 05, 15, 25, 40, 15, 20, 15, 20, 15, 20, 10,
            20, 20, 05, 05, 10, 05, 40, 10, 10, 05, 10, 10, 15, 10, 20, 30, 30, 10, 20, 05, 10, 10, 15, 10, 10, 05, 15, 05, 10, 10, 30, 20, 20, 10, 10, 05, 05, 10, 05, 20, 10, 20, 10, 15, 10, 20, 20, 20, 15, 15,
            10, 15, 20, 15, 10, 10, 10, 20, 10, 30, 05, 10, 15, 10, 10, 05, 20, 30, 10, 30, 15, 15, 15, 15, 30, 10, 20, 15, 10, 10, 20, 15, 05, 05, 15, 15, 05, 10, 05, 20, 05, 15, 20, 05, 20, 20, 20, 20, 10, 20,
            10, 15, 20, 15, 10, 10, 05, 10, 05, 05, 10, 05, 05, 10, 05, 05, 05, 15, 10, 10, 10, 10, 10, 10, 15, 20, 15, 10, 15, 10, 15, 10, 20, 10, 15, 10, 20, 20, 20, 20, 20, 15, 15, 15, 15, 15, 15, 20, 15, 10,
            15, 15, 15, 15, 10, 10, 10, 10, 10, 15, 15, 15, 15, 05, 05, 15, 05, 10, 10, 10, 20, 20, 20, 10, 10, 30, 15, 15, 10, 15, 25, 10, 20, 10, 10, 10, 20, 10, 10, 10, 10, 10, 15, 15, 05, 05, 10, 10, 10, 05,
            05, 10, 05, 05, 15, 10, 05, 05, 05,
        };
        internal static readonly int[] WildPokeBalls5 =
        {
            1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            // Cherish ball not usable
            // HGSS balls not usable
            // Dream ball not usable in wild
        };

        internal static readonly int[] FutureEvolutionsGen5 =
        {
            700
        };
        internal static readonly int[] UnreleasedItems_5 =
        {
            // todo
        };
        internal static readonly bool[] ReleasedHeldItems_5 = Enumerable.Range(0, MaxItemID_5_B2W2+1).Select(i => HeldItems_BW.Contains((ushort)i) && !UnreleasedItems_5.Contains(i)).ToArray();
        internal static readonly int[][] Tutors_B2W2 =
        {
            new[] { 343, 450, 529, 340, 324, 442, 162, 253, 402, 530, 067, 441, 007, 009, 008 }, // Driftveil City
            new[] { 387, 334, 393, 277, 335, 304, 527, 196, 231, 401, 414, 428, 492, 276, 356, 406, 399 }, // Lentimas Town
            new[] { 020, 173, 215, 282, 235, 355, 143, 272, 257, 202, 409, 220, 366 }, // Humilau City
            new[] { 388, 380, 270, 495, 478, 472, 180, 278, 271, 446, 200, 283, 214, 285, 289, } // Nacrene City
        };

        internal static readonly EncounterStatic[] Encounter_BW =
        {
            //todo
        };
        internal static readonly EncounterStatic[] Encounter_B2W2 =
        {
            //todo
        };
        internal static readonly EncounterTrade[] TradeGift_BW =
        {
            new EncounterTrade { Species = 548, Level = 15, Ability = 1, TID = 39922, SID = 00000, OTGender = 1, Gender = 1, IVs = new[] {20,20,20,31,20,20}, Nature = Nature.Modest, Version = GameVersion.B, }, // Petilil
            new EncounterTrade { Species = 546, Level = 15, Ability = 1, TID = 39922, SID = 00000, OTGender = 1, Gender = 1, IVs = new[] {20,20,20,31,20,20}, Nature = Nature.Modest, Version = GameVersion.W, }, // Cottonee
            new EncounterTrade { Species = 550, Form = 0, Level = 25, Ability = 1, TID = 27646, SID = 00000, OTGender = 0, Gender = 0, IVs = new[] {20,31,20,20,20,20}, Nature = Nature.Adamant, Version = GameVersion.B, }, // Basculin-Red
            new EncounterTrade { Species = 550, Form = 1, Level = 25, Ability = 1, TID = 27646, SID = 00000, OTGender = 0, Gender = 0, IVs = new[] {20,31,20,20,20,20},  Nature = Nature.Adamant, Version = GameVersion.W, }, // Basculin-Blue
            new EncounterTrade { Species = 587, Level = 30, Ability = 1, TID = 11195, SID = 00000, OTGender = 0, Gender = 0, IVs = new[] {20,20,31,20,20,20}, Nature = Nature.Lax, }, // Emolga
            new EncounterTrade { Species = 479, Level = 60, Ability = 1, TID = 54673, SID = 00000, OTGender = 1, Gender = 2, IVs = new[] {20,20,20,20,31,20}, Nature = Nature.Gentle, }, // Rotom
            new EncounterTrade { Species = 446, Level = 65, Ability = 2, TID = 40217, SID = 00000, OTGender = 0, Gender = 0, IVs = new[] {31,20,20,20,20,20}, Nature = Nature.Serious, }, // Munchlax
        };
        internal static readonly EncounterTrade[] TradeGift_B2W2 =
        {
            new EncounterTrade { Species = 548, Level = 20, Ability = 2, TID = 65217, SID = 00000, OTGender = 1, Gender = 1, IVs = new[] {20,20,20,31,20,20}, Nature = Nature.Timid, Version = GameVersion.B2, }, // Petilil
            new EncounterTrade { Species = 546, Level = 20, Ability = 1, TID = 05720, SID = 00000, OTGender = 0, Gender = 0, IVs = new[] {20,20,20,31,20,20}, Nature = Nature.Modest, Version = GameVersion.W2, }, // Cottonee
            new EncounterTrade { Species = 526, Level = 35, Ability = 1, TID = 11195, SID = 00000, OTGender = 0, Gender = 0, IVs = new[] {20,31,20,20,20,20}, Nature = Nature.Adamant, }, // Gigalith
            new EncounterTrade { Species = 465, Level = 35, Ability = 1, TID = 27658, SID = 00000, OTGender = 0, Gender = 0, IVs = new[] {31,20,20,20,20,20}, Nature = Nature.Adamant, }, // Tangrowth
            new EncounterTrade { Species = 479, Level = 60, Ability = 1, TID = 54673, SID = 00000, OTGender = 1, Gender = 2, IVs = new[] {20,20,20,20,31,20}, Nature = Nature.Calm, }, // Rotom
            new EncounterTrade { Species = 424, Level = 40, Ability = 2, TID = 17074, SID = 00000, OTGender = 1, Gender = 0, IVs = new[] {20,20,20,20,20,31}, Nature = Nature.Jolly, }, // Ambipom
            new EncounterTrade { Species = 526, Level = 40, Ability = 1, TID = 17074, SID = 00000, OTGender = 1, Gender = 0, IVs = new[] {20,20,20,20,20,31}, Nature = Nature.Timid, }, // Alakazam
            // player is male
            new EncounterTrade { Species = 052, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 202, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 280, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 410, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 111, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 422, Form = 0, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,}, //Shellos-Red
            new EncounterTrade { Species = 303, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 442, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 143, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 216, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 327, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            new EncounterTrade { Species = 175, Level = 50, Ability = 4, TID = 10303, SID = 00000, OTGender = 1,},
            //// player is female
            new EncounterTrade { Species = 056, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 202, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 280, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 408, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 111, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 422, Form = 1, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,}, //Shellos-Blue
            new EncounterTrade { Species = 302, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 442, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 143, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 231, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 327, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
            new EncounterTrade { Species = 175, Level = 50, Ability = 4, TID = 54118, SID = 00000, OTGender = 0,},
        };
    }
}
