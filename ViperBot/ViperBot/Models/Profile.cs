using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ViperBot.Models
{
    class Profile
    {
        public int Cash { get; set; }
        public string Items { get; set; }
        public string Tag { get; set; }
        public string DiscordTag { get; set; }
        public Profile(int defCash, string currItems, string Tag, string DiscordTag)
        {
            Cash = defCash;
            Items = currItems;
            this.Tag = Tag;
            this.DiscordTag = DiscordTag;
        }
        public static void InitUsers(List<Profile> profs)
        {
            foreach (var profWritten in profs)
            {
                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{RandomString(5)}", profWritten.ToString());
            }
        }

        // Used for no confusion or errors
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomizeChoice()
        {
            const string chars = "TF";
            return new string(Enumerable.Repeat(chars, 1).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
