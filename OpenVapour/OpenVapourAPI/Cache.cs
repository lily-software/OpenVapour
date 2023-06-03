﻿using System;
using System.Drawing;
using System.IO;
using static OpenVapour.OpenVapourAPI.Compression;
using static OpenVapour.Steam.SteamCore;
using static OpenVapour.OpenVapourAPI.Utilities;

namespace OpenVapour.OpenVapourAPI {
    internal class Cache {
        internal static readonly string DedicatedAppdata = $"{RoamingAppData}\\lily.software\\OpenVapour";
        internal static readonly string DedicatedStorage = $"{RoamingAppData}\\lily.software\\OpenVapour\\Storage";
        internal static readonly string DedicatedCache = $"{RoamingAppData}\\lily.software\\OpenVapour\\Cache";
        internal static readonly TimeSpan CacheTimeout = TimeSpan.FromDays(.8f);
        internal static void CheckCache() {
            if (!Directory.Exists($"{DedicatedStorage}\\Blacklist")) Directory.CreateDirectory($"{DedicatedStorage}\\Blacklist");
            if (!Directory.Exists($"{DedicatedStorage}\\Games")) Directory.CreateDirectory($"{DedicatedStorage}\\Games");
            if (!Directory.Exists($"{DedicatedCache}\\Games")) Directory.CreateDirectory($"{DedicatedCache}\\Games");
            if (!Directory.Exists($"{DedicatedCache}\\Images")) Directory.CreateDirectory($"{DedicatedCache}\\Images"); }

        internal static void CacheSteamBitmap(int AppId, string Asset, Bitmap Image) => Image.Save($"{DedicatedCache}\\Images\\{AppId}{Asset}.jpg");
        internal static bool IsSteamBitmapCached(int AppId, string Asset) => File.Exists($"{DedicatedCache}\\Images\\{AppId}{Asset}.jpg");
        internal static Bitmap GetCachedSteamBitmap(int AppId, string Asset) => (Bitmap)Image.FromFile($"{DedicatedCache}\\Images\\{AppId}{Asset}.jpg");
        internal static void CacheBitmap(string Name, Bitmap Image) => Image.Save($"{DedicatedCache}\\Images\\{FilterAlphanumeric(Name)}.jpg");
        internal static bool IsBitmapCached(string Name) => File.Exists($"{DedicatedCache}\\Images\\{FilterAlphanumeric(Name)}.jpg");
        internal static Bitmap GetCachedBitmap(string Name) => (Bitmap)Image.FromFile($"{DedicatedCache}\\Images\\{FilterAlphanumeric(Name)}.jpg");
        internal static bool IsSteamGameCached(int AppId) => File.Exists($"{DedicatedCache}\\Games\\{AppId}");
        internal static void CacheSteamGame(SteamGame game) => File.WriteAllText($"{DedicatedCache}\\Games\\{game.AppId}", CompressString(SerializeSteamGame(game)));
        internal static bool IsBlacklisted(string AppId) => File.Exists($"{DedicatedStorage}\\Blacklist\\{AppId}");
        internal static bool IsHomepaged(string AppId) => File.Exists($"{DedicatedStorage}\\Games\\{AppId}");
        internal static void RemoveHomepage(string AppId) {
            if (IsHomepaged(AppId)) File.Delete($"{DedicatedStorage}\\Games\\{AppId}"); }
        internal static void HomepageGame(SteamGame game) {
            CheckCache(); 
            if (game == null || game.AppId.Length == 0) return;
            CacheSteamGame(game);
            File.WriteAllText($"{DedicatedStorage}\\Games\\{game.AppId}", ""); }
        internal static void BlacklistID(string AppId, string Reason = "") {
            CheckCache(); if (AppId.Length > 0) File.WriteAllText($"{DedicatedStorage}\\Blacklist\\{AppId}", Reason == ""?"Blacklist reason not provided.":$"Blacklisted for: {Reason}"); }
        internal static void WhitelistID(string AppId) {
            if (File.Exists($"{DedicatedStorage}\\Blacklist\\{AppId}")) File.Delete($"{DedicatedStorage}\\Blacklist\\{AppId}"); }
        internal static SteamGame LoadCachedSteamGame(int AppId) {
            CheckCache();
            try {
                if (File.Exists($"{DedicatedCache}\\Games\\{AppId}")) {
                    if (DateTime.Now - File.GetLastWriteTime($"{DedicatedCache}\\Games\\{AppId}") > CacheTimeout)
                        File.Delete($"{DedicatedCache}\\Games\\{AppId}");
                    else {
                        string cached = DecompressString(File.ReadAllText($"{DedicatedCache}\\Games\\{AppId}"));
                        SteamGame game = DeserializeSteamGame(cached);
                        return game; }}
            } catch (Exception ex) { 
                HandleException($"LoadCachedSteamGame({AppId}", ex); 
                File.Delete($"{DedicatedCache}\\Games\\{AppId}"); } 
            return null; }}}
