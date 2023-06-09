﻿using System;
using System.Drawing;
using System.IO;
using static OpenVapour.OpenVapourAPI.Compression;
using static OpenVapour.Steam.SteamCore;
using static OpenVapour.OpenVapourAPI.Utilities;
using static OpenVapour.Torrent.Torrent;
using static OpenVapour.OpenVapourAPI.DirectoryUtilities;
using System.Threading.Tasks;

namespace OpenVapour.OpenVapourAPI {
    internal class Cache {
        internal static readonly TimeSpan CacheTimeout = TimeSpan.FromDays(.8f);

        internal static void CacheSteamBitmap(int AppId, string Asset, Bitmap Image) => CacheBitmap($"{AppId}{Asset}", Image, false);
        internal static bool IsSteamBitmapCached(int AppId, string Asset) => File.Exists($"{DedicatedCache}\\Images\\{AppId}{Asset}.jpg");
        internal static Bitmap GetCachedSteamBitmap(int AppId, string Asset) => GetCachedBitmap($"{AppId}{Asset}", false);
        internal static void CheckCache() {
            CreateDirectory($"{DedicatedStorage}\\Blacklist");
            CreateDirectory($"{DedicatedStorage}\\Games");
            CreateDirectory($"{DedicatedCache}\\Games");
            CreateDirectory($"{DedicatedCache}\\Torrents");
            CreateDirectory($"{DedicatedCache}\\Images"); }
        internal static void CacheBitmap(string Name, Bitmap Image, bool Filter = true) {
            try {
                Image.Save($"{DedicatedCache}\\Images\\{(Filter?FilterAlphanumeric(Name):Name)}.jpg");
            } catch (Exception ex) { HandleException($"Cache.CacheBitmap({Name}, Image)", ex); }}
        internal static bool IsBitmapCached(string Name) => File.Exists($"{DedicatedCache}\\Images\\{FilterAlphanumeric(Name)}.jpg");
        internal static Bitmap GetCachedBitmap(string Name, bool Filter = true) {
            try {
                return (Bitmap)Image.FromFile($"{DedicatedCache}\\Images\\{(Filter?FilterAlphanumeric(Name):Name)}.jpg");
            } catch (Exception ex) { HandleException($"Cache.GetCachedBitmap({Name})", ex); return new Bitmap(1, 1); }}
        
        internal static void CacheSteamGame(SteamGame game) { 
            try {
                File.WriteAllText($"{DedicatedCache}\\Games\\{game.AppId}", CompressString(SerializeSteamGame(game)));
            } catch (Exception ex) { HandleException($"Cache.CacheSteamGame({game?.AppId})", ex); }}
        internal static bool IsSteamGameCached(string AppId) => File.Exists($"{DedicatedCache}\\Games\\{AppId}");
        internal static async Task<SteamGame> LoadCachedSteamGame(string AppId) { 
            try {
                SteamGame cached = DeserializeSteamGame(LoadCompressedAsset($"{DedicatedCache}\\Games\\{AppId}"));
                if (cached == null || cached.AppId.Length == 0) return await GetGame(ToIntSafe(AppId));
                else return cached;
            } catch (Exception ex) { 
                HandleException($"Cache.LoadCachedSteamGame({AppId})", ex);
                int appidsafe = ToIntSafe(AppId);
                if (appidsafe != -1) return await GetGame(appidsafe);
                else return null; }}
        
        internal static void CacheTorrent(ResultTorrent torrent) {
            try {
                File.WriteAllText($"{DedicatedCache}\\Torrents\\{FilterAlphanumeric(torrent.Url)}", CompressString(SerializeTorrent(torrent)));
            } catch (Exception ex) { HandleException($"Cache.CacheTorrent({torrent?.Url})", ex); }}
        internal static bool IsTorrentCached(string Url) => File.Exists($"{DedicatedCache}\\Torrents\\{FilterAlphanumeric(Url)}");
        internal static ResultTorrent LoadCachedTorrent(string Url) {
            try {
                ResultTorrent cached = DeserializeTorrent(LoadCompressedAsset($"{DedicatedCache}\\Torrents\\{FilterAlphanumeric(Url)}"));
                if (cached == null || cached.Url.Length == 0 || cached.Image.Length == 0) return null;
                else return cached;
            } catch (Exception ex) { HandleException($"Cache.LoadCachedTorrent({Url})", ex); return null; }}

        internal static bool IsBlacklisted(string AppId) => File.Exists($"{DedicatedStorage}\\Blacklist\\{AppId}");
        internal static bool IsHomepaged(string AppId) => File.Exists($"{DedicatedStorage}\\Games\\{AppId}");
        internal static void RemoveHomepage(string AppId) {
            try {
                if (IsHomepaged(AppId)) File.Delete($"{DedicatedStorage}\\Games\\{AppId}");
            } catch (Exception ex) { HandleException($"Cache.RemoveHomepage({AppId})", ex); }}
        internal static void HomepageGame(SteamGame game) {
            CheckCache(); 
            try {
                if (game == null || game.AppId.Length == 0) return;
                CacheSteamGame(game);
                File.WriteAllText($"{DedicatedStorage}\\Games\\{game.AppId}", ""); 
            } catch (Exception ex) { HandleException($"Cache.HomepageGame({game?.AppId})", ex); }}
        internal static void BlacklistID(string AppId, string Reason = "") {
            CheckCache(); 
            try {
                if (AppId.Length > 0) 
                    File.WriteAllText($"{DedicatedStorage}\\Blacklist\\{AppId}", string.IsNullOrWhiteSpace(Reason)?"Blacklist reason not provided.":$"Blacklisted for: {Reason}");
            } catch (Exception ex) { HandleException($"Cache.BlacklistID({AppId}, {Reason})", ex); }}
        internal static void WhitelistID(string AppId) {
            if (File.Exists($"{DedicatedStorage}\\Blacklist\\{AppId}"))
                try { File.Delete($"{DedicatedStorage}\\Blacklist\\{AppId}"); }
                catch (Exception ex) { HandleException($"Cache.WhitelistID({AppId})", ex); }}
        internal static string LoadCompressedAsset(string file) {
            CheckCache();
            try {
                if (File.Exists(file)) {
                    if (DateTime.Now - File.GetLastWriteTime(file) > CacheTimeout) File.Delete(file);
                    else return DecompressString(File.ReadAllText(file)); }
            } catch (Exception ex) { 
                HandleException($"Cache.LoadCompressedAsset({file}", ex); 
                try { File.Delete(file); } 
                catch (Exception uhoh) { HandleException($"Cache.LoadCompressedAsset({file}) [Deletion]", uhoh); }} 
            return null; }}}
