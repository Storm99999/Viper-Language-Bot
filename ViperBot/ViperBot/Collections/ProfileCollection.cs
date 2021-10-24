using System;
using System.Collections.Generic;
using System.IO;
using ViperBot.Models;
using ViperBot.Services.General;

namespace ViperBot.Collections
{
    class ProfileCollection
    {
        public static Profile Storm = new Profile(2333, "Computer\nAxe", "StormTag", "Storm.");
        public static Profile Encryp = new Profile(2212, "nothing\nair", "EncrypTag", "encryqed");
        public static Profile Shimo = new Profile(1, "Nothing", "ShimoTag", "shimo");
        public static Profile Google = new Profile(3000, "Computer\nAxe", "GoogleTag", "Google");
        public static bool WasCreated()
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Profiles\\true"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddAllProfiles()
        {
            if (WasCreated() == true)
            {
                ColorConsole.ColorWrite("A kid, just tried resetting profiles.");
            }
            else
            {
                List<Profile> profList = new List<Profile>
                {
                  Storm,
                  Encryp,
                  Shimo,
                  Google
                };
                foreach (var prof in profList)
                {
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{prof.Tag + "Cash"}", prof.Cash.ToString());
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{prof.Tag + "Items"}", prof.Items.ToString());
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{prof.Tag + "DiscTag"}", prof.DiscordTag.ToString());
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\true", string.Empty);
                }
            }
        }

        public static bool HasItem(string item)
        {
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Storm.DiscordTag)
            {
                if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\"+Storm.Tag+"Items").Contains(item))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Encryp.DiscordTag)
            {
                if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\" + Encryp.Tag + "Items").Contains(item))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
            {
                if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\" + Shimo.Tag + "Items").Contains(item))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
            {
                if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\" + Google.Tag + "Items").Contains(item))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static void RemoveItem(string item)
        {
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Storm.DiscordTag)
            {
                Storm.Items.Replace(item, "");
                File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\StormTagItems", File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\StormTagItems").Replace(item, ""));
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Encryp.DiscordTag)
            {
                Encryp.Items.Replace(item, "");
                File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\EncrypTagItems", File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\EncrypTagItems").Replace(item, ""));
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
            {
                Shimo.Items.Replace(item, "");
                File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\ShimoTagItems", File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\ShimoTagItems").Replace(item, ""));
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
            {
                Google.Items.Replace(item, "");
                File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\GoogleTagItems", File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\GoogleTagItems").Replace(item, ""));
            }
        }

        public static void AddItem(string item)
        {
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Storm.DiscordTag)
            {
                File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\StormTagItems", File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\StormTagItems") + "\n"+item);
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Encryp.DiscordTag)
            {
                File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\EncrypTagItems", File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\EncrypTagItems") + "\n" + item);
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
            {
                File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\ShimoTagItems", File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\ShimoTagItems") + "\n" + item);
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
            {
                File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\GoogleTagItems", File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\GoogleTagItems") + "\n" + item);
            }
        }

        public static string ListInventory()
        {
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Storm.DiscordTag)
            {
                return File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\StormTagItems");
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Encryp.DiscordTag)
            {
                return File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\EncrypTagItems");
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
            {
                return File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\ShimoTagItems");
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
            {
                return File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\GoogleTagItems");
            }
            return "N/A";
        }
    }
}
