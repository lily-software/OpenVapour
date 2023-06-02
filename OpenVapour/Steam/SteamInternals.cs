﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenVapour.Steam {
    internal class SteamInternals {
        internal enum SteamTag { Indie = 492, Action = 19, Adventure = 21, Casual = 597, RPG = 122, Simulation = 599, Strategy = 9, Singleplayer = 4182, EarlySpacebarAccess = 493, FreeSpacebartoSpacebarPlay = 113, TwoD = 3871, ThreeD = 4191, Atmospheric = 4166, Fantasy = 1684, StorySpacebarRich = 1742, Colorful = 4305, Multiplayer = 3859, Puzzle = 1664, MassivelySpacebarMultiplayer = 128, PixelSpacebarGraphics = 3964, Sports = 701, Exploration = 3834, Violent = 4667, Cute = 4726, FirstHyphenPerson = 3839, Combat = 3993, Racing = 699, Nudity = 6650, Anime = 4085, SexualSpacebarContent = 12095, Funny = 4136, Arcade = 1773, SciHyphenfi = 3942, ActionHyphenAdventure = 4106, Shooter = 1774, Gore = 4345, Relaxing = 1654, Horror = 1667, Retro = 4004, FamilySpacebarFriendly = 5350, ThirdSpacebarPerson = 1697, FemaleSpacebarProtagonist = 7208, OpenSpacebarWorld = 1695, Controller = 7481, Stylized = 4252, CoHyphenop = 1685, Platformer = 1625, Survival = 1662, PvP = 1775, ChoicesSpacebarMatter = 6426, TopHyphenDown = 4791, Comedy = 1719, Realistic = 4175, VisualSpacebarNovel = 3799, Dark = 4342, CharacterSpacebarCustomization = 4747, PvE = 6730, Physics = 3968, FPS = 1663, OldSpacebarSchool = 3916, Mystery = 5716, Cartoony = 4195, OnlineSpacebarCoHyphenOp = 3843, Difficult = 4026, TwoDSpacebarPlatformer = 5379, Linear = 7250, MultipleSpacebarEndings = 6971, VR = 21978, GreatSpacebarSoundtrack = 1756, PsychologicalSpacebarHorror = 1721, Sandbox = 3810, Magic = 4057, Medieval = 4172, Tactical = 1708, ActionSpacebarRPG = 4231, Minimalist = 4094, Futuristic = 4295, Space = 1755, Building = 1643, PointSpacebarAmpersandSpacebarClick = 1698, HandHyphendrawn = 6815, ShootSpacebarApostropheEmSpacebarUp = 4255, Crafting = 1702, Management = 12472, DesignSpacebarAmpersandSpacebarIllustration = 84, LocalSpacebarMultiplayer = 7368, Cartoon = 4562, Roguelike = 1716, Drama = 5984, SideSpacebarScroller = 3798, ProceduralSpacebarGeneration = 5125, ResourceSpacebarManagement = 8945, DarkSpacebarFantasy = 4604, Mature = 5611, Roguelite = 3959, Logic = 6129, SurvivalSpacebarHorror = 3978, Education = 1036, ThreeDSpacebarPlatformer = 5395, PuzzleSpacebarPlatformer = 5537, ChooseSpacebarYourSpacebarOwnSpacebarAdventure = 4486, OneNineEight0s = 7743, Utilities = 87, Romance = 4947, TurnHyphenBasedSpacebarCombat = 4325, HackSpacebarandSpacebarSlash = 1646, Emotional = 5608, War = 1678, TurnHyphenBasedSpacebarStrategy = 1741, InteractiveSpacebarFiction = 11014, Tabletop = 17389, TurnHyphenBasedSpacebarTactics = 14139, Zombies = 1659, PostHyphenapocalyptic = 3835, Hentai = 9130, ImmersiveSpacebarSim = 9204, BaseSpacebarBuilding = 7332, Nature = 30358, DatingSpacebarSim = 9551, JRPG = 4434, HiddenSpacebarObject = 1738, Surreal = 1710, LocalSpacebarCoHyphenOp = 3841, OneNineNine0Apostrophes = 6691, ActionSpacebarRoguelike = 42804, ReplaySpacebarValue = 4711, PartyHyphenBasedSpacebarRPG = 10695, Historical = 3987, BulletSpacebarHell = 4885, DungeonSpacebarCrawler = 1720, Stealth = 1687, Narration = 5094, TurnHyphenBased = 1677, WalkingSpacebarSimulator = 5900, ScoreSpacebarAttack = 5154, Military = 4168, ThirdHyphenPersonSpacebarShooter = 3814, Cinematic = 4145, NSFW = 24904, Conversation = 15172, TextHyphenBased = 31275, TopHyphenDownSpacebarShooter = 4637, WebSpacebarPublishing = 1038, TwoPeriodFiveD = 4975, LGBTQPlus = 44868, Memes = 10397, Aliens = 1673, Cyberpunk = 4115, Robots = 5752, Isometric = 5851, TeamHyphenBased = 5711, Investigation = 8369, DarkSpacebarHumor = 5923, Nonlinear = 6869, InventorySpacebarManagement = 6276, RTS = 1676, ArtificialSpacebarIntelligence = 7926, CardSpacebarGame = 1666, LoreHyphenRich = 3854, LifeSpacebarSim = 10235, Tutorial = 12057, Demons = 9541, FastHyphenPaced = 1734, StrategySpacebarRPG = 17305, Clicker = 379975, Abstract = 4400, Psychological = 5186, Economy = 4695, Thriller = 4064, Short = 4234, PermaSpacebarDeath = 1759, ArenaSpacebarShooter = 5547, Driving = 1644, AnimationSpacebarAmpersandSpacebarModeling = 872, RealSpacebarTimeSpacebarTactics = 3813, Detective = 5613, BoardSpacebarGame = 1770, Modern = 5673, Supernatural = 10808, Software = 8013, DystopianSpacebar = 5030, Classic = 1693, FourSpacebarPlayerSpacebarLocal = 4840, Psychedelic = 1714, TimeSpacebarManagement = 16689, PrecisionSpacebarPlatformer = 3877, Loot = 4236, TowerSpacebarDefense = 1645, Flight = 15045, TacticalSpacebarRPG = 21725, CitySpacebarBuilder = 4328, Music = 1621, SoulsHyphenlike = 29482, RPGMaker = 5577, Soundtrack = 7948, ComicSpacebarBook = 1751, Destruction = 5363, BeatSpacebarApostropheemSpacebarup = 4158, Movie = 4700, Wargame = 4684, Metroidvania = 1628, AlternateSpacebarHistory = 4598, Moddable = 1669, Fighting = 1743, Beautiful = 5411, Experimental = 13782, LevelSpacebarEditor = 8122, Mythology = 16094, Runner = 8666, Collectathon = 5652, GridHyphenBasedSpacebarMovement = 7569, VideoSpacebarProduction = 784, AudioSpacebarProduction = 1027, GameSpacebarDevelopment = 13906, Crime = 6378, TwoDSpacebarFighter = 4736, Parkour = 4036, Competitive = 3878, CRPG = 4474, MMORPG = 1754, Idler = 615955, DarkSpacebarComedy = 19995, ClassHyphenBased = 4155, Deckbuilding = 32322, Philosophical = 15277, GunSpacebarCustomization = 5765, WorldSpacebarWarSpacebarII = 4150, TwinSpacebarStickSpacebarShooter = 4758, AutomobileSpacebarSim = 1100687, CardSpacebarBattler = 791774, Science = 5794, CoHyphenopSpacebarCampaign = 4508, Cats = 17894, Swordplay = 4608, Rhythm = 1752, VehicularSpacebarCombat = 11104, SpaceSpacebarSim = 16598, Dragons = 4046, BattleSpacebarRoyale = 176981, GrandSpacebarStrategy = 4364, Lovecraftian = 7432, ThreeDSpacebarFighter = 6506, SixDOF = 4835, eSports = 5055, ThreeDSpacebarVision = 29363, America = 13190, Capitalism = 4845, SoftwareSpacebarTraining = 1445, Noir = 6052, Conspiracy = 5372, MatchSpacebarThree = 1665, Automation = 255534, CharacterSpacebarActionSpacebarGame = 3955, Blood = 5228, ParodySpacebar = 4878, SplitSpacebarScreen = 10816, ColonySpacebarSim = 220585, BulletSpacebarTime = 5796, CreatureSpacebarCollector = 916648, Satire = 1651, Trading = 4202, FarmingSpacebarSim = 87918, QuickHyphenTimeSpacebarEvents = 4559, MysterySpacebarDungeon = 198631, TimeSpacebarManipulation = 6625, HeroSpacebarShooter = 620519, OpenSpacebarWorldSpacebarSurvivalSpacebarCraft = 1100689, DynamicSpacebarNarration = 9592, Addictive = 4190, Gothic = 3952, Underground = 21006, Steampunk = 1777, Agriculture = 22602, LooterSpacebarShooter = 353880, WordSpacebarGame = 24003, Voxel = 1732, Political = 4853, Illuminati = 7478, Mining = 5981, Cooking = 3920, Mechs = 4821, MartialSpacebarArts = 6915, SpectacleSpacebarfighter = 4777, TimeSpacebarTravel = 10679, Hunting = 9564, CombatSpacebarRacing = 4102, Dog = 1638, Otome = 31579, MOBA = 1718, GodSpacebarGame = 5300, Pirates = 1681, Tanks = 13276, AsynchronousSpacebarMultiplayer = 17770, PhotoSpacebarEditing = 809, Hacking = 5502, MouseSpacebaronly = 11123, Ninja = 1688, Solitaire = 13070, HexSpacebarGrid = 1717, Fishing = 15564, Vampire = 4018, Remake = 5708, Politics = 4754, TradingSpacebarCardSpacebarGame = 9271, FMV = 18594, AutoSpacebarBattler = 1084988, RealHyphenTime = 4161, Immersive = 3934, CultSpacebarClassic = 7782, Episodic = 4242, Assassin = 4376, Epic = 3965, Narrative = 7702, FourX = 1670, ColdSpacebarWar = 5179, Underwater = 9157, Superhero = 1671, Faith = 180368, ActionSpacebarRTS = 1723, Programming = 5432, Sokoban = 1730, Dinosaurs = 5160, PoliticalSpacebarSim = 26921, Heist = 1680, Western = 1647, Naval = 6910, PartySpacebarGame = 7178, Trains = 1616, Transportation = 10383, Party = 7108, Archery = 13382, Minigames = 8093, Foreign = 51306, Diplomacy = 6310, RealHyphenTimeSpacebarwithSpacebarPause = 7107, Snow = 9803, NavalSpacebarCombat = 4994, Typing = 1674, Transhumanism = 4137, Kickstarter = 5153, Gambling = 16250, Sailing = 13577, DungeonsSpacebarAmpersandSpacebarDragons = 14153, VillainSpacebarProtagonist = 11333, Sequel = 5230, EscapeSpacebarRoom = 769306, Mod = 5348, Sniper = 7423, Cozy = 97376, MusicHyphenBasedSpacebarProceduralSpacebarGeneration = 8253, Nostalgia = 14720, OnHyphenRailsSpacebarShooter = 56690, Mars = 6702, RoguelikeSpacebarDeckbuilder = 1091588, TouchHyphenFriendly = 25085, Offroad = 7622, Experience = 9994, FootballSpacebarOpenBracketSoccerCloseBracket = 1254546, TimeSpacebarAttack = 5390, Wholesome = 552282, TraditionalSpacebarRoguelike = 454187, GameMaker = 1649, Werewolves = 17015, WorldSpacebarWarSpacebarI = 5382, ThreeSix0SpacebarVideo = 776177, Horses = 6041, Trivia = 10437, Farming = 4520, GamesSpacebarWorkshop = 5310, Boxing = 12190, Gaming = 150626, Documentary = 15339, Jet = 92092, Chess = 4184, Spaceships = 4291, OutbreakSpacebarSim = 1100686, SilentSpacebarProtagonist = 15954, Unforgiving = 1733, LEGO = 1736, MedicalSpacebarSim = 1100688, Motorbike = 198913, Spelling = 71389, Golf = 7038, AsymmetricSpacebarVR = 856791, Rome = 6948, Crowdfunded = 7113, Roguevania = 922563, Submarine = 19780, ElectronicSpacebarMusic = 61357, Bikes = 123332, Basketball = 1746, Pinball = 6621, FootballSpacebarOpenBracketAmericanCloseBracket = 1254552, Ambient = 29855, InstrumentalSpacebarMusic = 189941, SocialSpacebarDeduction = 745697, TrackIR = 8075, WarhammerSpacebarFour0K = 12286, MiniSpacebarGolf = 22955, Skateboarding = 1753, Wrestling = 47827, BasedSpacebarOnSpacebarASpacebarNovel = 3796, RockSpacebarMusic = 337964, Vikings = 11634, Pool = 17927, Baseball = 5727, JumpSpacebarScare = 42089, Cycling = 19568, Skating = 96359, IntentionallySpacebarAwkwardSpacebarControls = 14906, Tennis = 5914, Motocross = 15868, BossSpacebarRush = 11095, EightHyphenbitSpacebarMusic = 117648, Bowling = 7328, Lemmings = 17337, TileHyphenMatching = 176733, SteamSpacebarMachine = 348922, Benchmark = 5407, Hockey = 324176, Hardware = 603297, Snowboarding = 28444, WellHyphenWritten = 8461, JobSpacebarSimulator = 35079, BMX = 252854, ATV = 129761, Skiing = 7309, Electronic = 143739, Mahjong = 33572, VoiceSpacebarControl = 27758, FeatureSpacebarFilm = 233824, Musou = 323922, ShopSpacebarKeeper = 91114, Rugby = 49213, Volleyball = 847164, Fox = 30927, Reboot = 5941, Coding = 42329, Cricket = 158638, Birds = 6214, Snooker = 363767, HobbySpacebarSim = 1220528 }
        internal static string ProcessArray(SteamTag[] Tags) {
            string processed = "";
            if (Tags.Length > 0)
                processed += "tags=";
            string[] stringarray = new string[Tags.Length];
            int i = 0;
            foreach (SteamTag tag in Tags) {
                stringarray[i] = ((int)tag).ToString();
                i++; }
            processed += string.Join("%2C", stringarray);
            if (Tags.Length > 0)
                processed += "&";
            return processed; }
        internal static string ProcessTag(SteamTag Tag) => ProcessTag(Tag.ToString());
        internal static string ProcessTag(string Text) {
            return Text.Replace("Spacebar", " ").Replace("Ampersand", "&").Replace("Hyphen", "-").Replace("Period", ".")
                    .Replace("Apostrophe", "'").Replace("One", "1").Replace("Two", "2").Replace("Three", "3")
                    .Replace("Four", "4").Replace("Five", "5").Replace("Six", "6").Replace("Seven", "7")
                    .Replace("Eight", "8").Replace("Nine", "9").Replace("TEN", "10").Replace("Plus", "+")
                    .Replace("OpenBracket", "(").Replace("CloseBracket", ")"); }}}
