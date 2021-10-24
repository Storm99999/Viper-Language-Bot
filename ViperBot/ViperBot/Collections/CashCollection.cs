using System;
using System.IO;
using ViperBot.Models;

namespace ViperBot.Collections
{
    class CashCollection
    {
        // Removes Cash
        public static void RemoveCash(int val)
        {
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Storm.DiscordTag)
            {
                if (ProfileCollection.Storm.Cash > val)
                {
                    int remVal = val;
                    int v = ProfileCollection.Storm.Cash - remVal;
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Storm.Tag + "Cash"}", v.ToString());
                }
                else
                {
                    return;
                }
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Encryp.DiscordTag)
            {
                if (ProfileCollection.Encryp.Cash > val)
                {
                    int remVal = val;
                    int v = ProfileCollection.Encryp.Cash - remVal;
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Encryp.Tag + "Cash"}", v.ToString());
                }
                else
                {
                    return;
                }
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
            {
                if (ProfileCollection.Shimo.Cash > val)
                {
                    int remVal = val;
                    int v = ProfileCollection.Shimo.Cash - remVal;
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Shimo.Tag + "Cash"}", v.ToString());
                }
                else
                {
                    return;
                }
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
            {
                if (ProfileCollection.Google.Cash > val)
                {
                    int remVal = val;
                    int v = ProfileCollection.Google.Cash - remVal;
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Google.Tag + "Cash"}", v.ToString());
                }
            }
        }
        // Adds Cash
        public static void AddCash(int val)
        {
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Storm.DiscordTag)
            {
                int remVal = val;
                int v = ProfileCollection.Storm.Cash + remVal;
                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Storm.Tag + "Cash"}", v.ToString());
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Encryp.DiscordTag)
            {
                int remVal = val;
                int v = ProfileCollection.Encryp.Cash + remVal;
                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Encryp.Tag + "Cash"}", v.ToString());
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
            {
                int remVal = val;
                int v = ProfileCollection.Shimo.Cash + remVal;
                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Shimo.Tag + "Cash"}", v.ToString());
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
            {
                int remVal = val;
                int v = ProfileCollection.Google.Cash + remVal;
                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Google.Tag + "Cash"}", v.ToString());
            }
        }

        // Grabs The Cash Of A User
        public static int CountCash()
        {
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Storm.DiscordTag)
            {
                int count = Convert.ToInt32(File.ReadAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Storm.Tag + "Cash"}"));
                return count;
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Encryp.DiscordTag)
            {
                int count = Convert.ToInt32(File.ReadAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Encryp.Tag + "Cash"}"));
                return count;
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
            {
                int count = Convert.ToInt32(File.ReadAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Shimo.Tag + "Cash"}"));
                return count;
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
            {
                int count = Convert.ToInt32(File.ReadAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Google.Tag + "Cash"}"));
                return count;
            }

            return 0;
        }
        public static string Rob()
        {
            int stolenMoney;
            Random random = new Random();
            stolenMoney = random.Next(1533, 4000);
            int remVal = stolenMoney;
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\currUserTransaction") == ProfileCollection.Storm.DiscordTag)
            {
                if (ProfileCollection.Storm.Cash > 1533)
                {


                    if (Profile.RandomizeChoice() == "T")
                    {
                        if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
                        {
                            if (ProfileCollection.Shimo.Cash > 1533)
                            {
                                int v = ProfileCollection.Storm.Cash + remVal;
                                RemoveCash(stolenMoney);
                                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Storm.Tag + "Cash"}", v.ToString());
                                return "You Just Stole " + stolenMoney;
                            }
                            else
                            {
                                return "Man, It's not worth it planning a whole damn air strike super force attack just for " + ProfileCollection.Shimo.Cash;
                            }
                        }
                        if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Encryp.DiscordTag)
                        {
                            if (ProfileCollection.Encryp.Cash > 1533)
                            {
                                int v = ProfileCollection.Storm.Cash + remVal;
                                RemoveCash(stolenMoney);
                                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Storm.Tag + "Cash"}", v.ToString());
                                return "You Just Stole " + stolenMoney;
                            }
                            else
                            {
                                return "Man, It's not worth it planning a whole damn air strike super force attack just for " + ProfileCollection.Encryp.Cash;
                            }
                        }
                        if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
                        {
                            if (ProfileCollection.Google.Cash > 1533)
                            {
                                int v = ProfileCollection.Storm.Cash + remVal;
                                RemoveCash(stolenMoney);
                                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Storm.Tag + "Cash"}", v.ToString());
                                return "You Just Stole " + stolenMoney;
                            }
                            else
                            {
                                return "Man, It's not worth it planning a whole damn air strike super force attack just for " + ProfileCollection.Google.Cash;
                            }
                        }
                    }
                    else
                    {
                        CashCollection.RemoveCash(stolenMoney);
                        return "Well, You Suck. You litterally just lost " + stolenMoney;
                    }
                }
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\currUserTransaction") == ProfileCollection.Encryp.DiscordTag)
            {
                if (ProfileCollection.Encryp.Cash > 1533)
                {


                    if (Profile.RandomizeChoice() == "T")
                    {
                        if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
                        {
                            if (ProfileCollection.Shimo.Cash > 1533)
                            {
                                int v = ProfileCollection.Encryp.Cash + remVal;
                                RemoveCash(stolenMoney);
                                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Encryp.Tag + "Cash"}", v.ToString());
                                return "You Just Stole " + stolenMoney;
                            }
                            else
                            {
                                return "Man, It's not worth it planning a whole damn air strike super force attack just for " + ProfileCollection.Shimo.Cash;
                            }
                        }
                        if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Storm.DiscordTag)
                        {
                            if (ProfileCollection.Storm.Cash > 1533)
                            {
                                int v = ProfileCollection.Encryp.Cash + remVal;
                                RemoveCash(stolenMoney);
                                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Storm.Tag + "Cash"}", v.ToString());
                                return "You Just Stole " + stolenMoney;
                            }
                            else
                            {
                                return "Man, It's not worth it planning a whole damn air strike super force attack just for " + ProfileCollection.Storm.Cash;
                            }
                        }
                        if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
                        {
                            if (ProfileCollection.Google.Cash > 1533)
                            {
                                int v = ProfileCollection.Encryp.Cash + remVal;
                                RemoveCash(stolenMoney);
                                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Encryp.Tag + "Cash"}", v.ToString());
                                return "You Just Stole " + stolenMoney;
                            }
                            else
                            {
                                return "Man, It's not worth it planning a whole damn air strike super force attack just for " + ProfileCollection.Google.Cash;
                            }
                        }
                    }
                    else
                    {
                        CashCollection.RemoveCash(stolenMoney);
                        return "Well, You Suck. You litterally just lost " + stolenMoney;
                    }
                }
                if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
                {
                    if (Profile.RandomizeChoice() == "T")
                    {
                        int v = ProfileCollection.Shimo.Cash + remVal;
                        File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Shimo.Tag + "Cash"}", v.ToString());
                        return "You Just Stole " + stolenMoney;
                    }
                    else
                    {
                        CashCollection.RemoveCash(stolenMoney);
                        return "Well, You Suck. You litterally just lost " + stolenMoney;
                    }
                }
                if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
                {
                    if (Profile.RandomizeChoice() == "T")
                    {
                        int v = ProfileCollection.Google.Cash + remVal;
                        File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Google.Tag + "Cash"}", v.ToString());
                        return "You Just Stole " + stolenMoney;
                    }
                    else
                    {
                        CashCollection.RemoveCash(stolenMoney);
                        return "Well, You Suck. You litterally just lost " + stolenMoney;
                    }
                }
            }
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\currUserTransaction") == ProfileCollection.Google.DiscordTag)
            {
                if (ProfileCollection.Google.Cash > 1533)
                {


                    if (Profile.RandomizeChoice() == "T")
                    {
                        if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
                        {
                            if (ProfileCollection.Shimo.Cash > 1533)
                            {
                                int v = ProfileCollection.Google.Cash + remVal;
                                RemoveCash(stolenMoney);
                                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Google.Tag + "Cash"}", v.ToString());
                                return "You Just Stole " + stolenMoney;
                            }
                            else
                            {
                                return "Man, It's not worth it planning a whole damn air strike super force attack just for " + ProfileCollection.Shimo.Cash;
                            }
                        }
                        if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Storm.DiscordTag)
                        {
                            if (ProfileCollection.Storm.Cash > 1533)
                            {
                                int v = ProfileCollection.Google.Cash + remVal;
                                RemoveCash(stolenMoney);
                                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Google.Tag + "Cash"}", v.ToString());
                                return "You Just Stole " + stolenMoney;
                            }
                            else
                            {
                                return "Man, It's not worth it planning a whole damn air strike super force attack just for " + ProfileCollection.Storm.Cash;
                            }
                        }
                        if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
                        {
                            if (ProfileCollection.Shimo.Cash > 1533)
                            {
                                int v = ProfileCollection.Google.Cash + remVal;
                                RemoveCash(stolenMoney);
                                File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Google.Tag + "Cash"}", v.ToString());
                                return "You Just Stole " + stolenMoney;
                            }
                            else
                            {
                                return "Man, It's not worth it planning a whole damn air strike super force attack just for " + ProfileCollection.Google.Cash;
                            }
                        }
                    }
                    else
                    {
                        CashCollection.RemoveCash(stolenMoney);
                        return "Well, You Suck. You litterally just lost " + stolenMoney;
                    }
                }
                if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Shimo.DiscordTag)
                {
                    if (Profile.RandomizeChoice() == "T")
                    {
                        int v = ProfileCollection.Shimo.Cash + remVal;
                        File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Shimo.Tag + "Cash"}", v.ToString());
                        return "You Just Stole " + stolenMoney;
                    }
                    else
                    {
                        CashCollection.RemoveCash(stolenMoney);
                        return "Well, You Suck. You litterally just lost " + stolenMoney;
                    }
                }
                if (File.ReadAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction") == ProfileCollection.Google.DiscordTag)
                {
                    if (Profile.RandomizeChoice() == "T")
                    {
                        int v = ProfileCollection.Google.Cash + remVal;
                        File.WriteAllText(Environment.CurrentDirectory + $"\\Profiles\\{ProfileCollection.Google.Tag + "Cash"}", v.ToString());
                        return "You Just Stole " + stolenMoney;
                    }
                    else
                    {
                        CashCollection.RemoveCash(stolenMoney);
                        return "Well, You Suck. You litterally just lost " + stolenMoney;
                    }
                }
            }
            return "N/A";
        }
    }
}
