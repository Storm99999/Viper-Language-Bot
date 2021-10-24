using Discord;
using Discord.Commands;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ViperBot.Collections;
using ViperBot.Getters;
using ViperBot.Models;
using ViperBot.Services.General;
using ViperBot.Services.GitHub;
using ViperBot.Services.ReaderService;

namespace ViperBot.Services.Discord.CommandService
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("avatar")]
        public async Task Avatar(ulong id)
        {
            if (id.ToString().Length < 18)
            {
                await ReplyAsync("You Did Not Specify Any User ID. Be more specific next time, kid.");
            }
            else
            {
                await ReplyAsync(Context.Channel.GetUserAsync(id).GetAwaiter().GetResult().GetAvatarUrl());
            }
        }

        [Command("examples")]
        public async Task Examples()
        {
            await ReplyAsync($"**Hello World Example**: \n\n\n{RService.Read($"{VisualStudio.GetPath()}/Assets/Examples/HelloWorld.viper")}\n\n\n**Colored Console Example**\n\n\n{RService.Read($"{VisualStudio.GetPath()}/Assets/Examples/ColoredConsole.viper")}\n\n Want To Submit More Examples? Make A Fork Or Pull Request On Our GitHub Page: https://github.com/Storm99999/SaturnBot");
        }
        [Command("sources")]
        public async Task Sources()
        {
            await ReplyAsync(GService.Sources());
        }
        [Command("help")]
        public async Task Help()
        {
            var EmbedBuilder = new EmbedBuilder()
                .WithAuthor("Storm.#1020")
                .WithDescription("**Viper's Bot**\n\n\n\n\n v!sources - Every Lib Viper's Bot uses.\n\n v!help - this is the current command, idiot\n\n v!avatar - Displays The Avatar\n\n v!examples - Show's some examples of the viper language.");
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);
        }
        [Command("buy")]
        public async Task Buy(string item, string user)
        {
            string AllItems = File.ReadAllText("Profiles\\AllItems.txt");
            if (AllItems.Contains(item))
            {
                TransactionLogger.NewLog(user);
                await ReplyAsync("Sucess! you bought " + item + "!");
                CashCollection.RemoveCash(1000);
                ProfileCollection.AddItem(item);
            }
            else
            {
                await ReplyAsync("Kid, you want to buy a ps9 too right? That item doesn't even exist. Retard.");
            }
        }

        [Command("blc")]
        public async Task Blc(string user)
        {
            TransactionLogger.NewLog(user);
            await ReplyAsync(user);
            int cash = CashCollection.CountCash();
            var EmbedBuilder = new EmbedBuilder()
                .WithDescription(user + "'s Balance is " + cash)
                .WithColor(Color.Blue);
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);
        }
        [Command("use")]
        public async Task Use(string item, string user)
        {
            if (item.Length < 3)
            {
                await ReplyAsync("Dude, BE MORE SPECIFIC.");
            }
            else
            {
                if (item == "Computer")
                {
                    TransactionLogger.NewLog(user);
                    if (ProfileCollection.HasItem(item) == true)
                    {
                        Random rnd = new Random();
                        int cash;
                        cash = rnd.Next(2034, 6933);
                        ProfileCollection.RemoveItem(item);
                        CashCollection.AddCash(cash);
                        await ReplyAsync("Congrats you we're playing fortnite so hard that you landed in the Hospital. Well atleast you won the world cup. in your dreams. your mom still gave you " + cash + "$ Yikes! I forgot to mention your pc exploded.");
                    }
                    else
                    {
                        await ReplyAsync("I'm maybe not human, but I'm not stupid. You don't have this item. smh. What We're you even thinking?");
                    }
                }
                if (item == "Axe")
                {
                    TransactionLogger.NewLog(user);
                    if (ProfileCollection.HasItem(item) == true)
                    {
                        Random rnd = new Random();
                        int cash;
                        cash = rnd.Next(1034, 1933);
                        ProfileCollection.RemoveItem(item);
                        CashCollection.AddCash(cash);
                        if (Profile.RandomizeChoice() == "T")
                        {
                            await ReplyAsync("Damn. You threatend a Tree to kill it if it doesn't give you money. Well. It Didn't afterall. It did give you a lucky coin. You still brutaly killed it. Too bad. His Brother Gave You " + cash + "$ To protect the rest of the family. You're a murder.");
                        }
                        else
                        {
                            await ReplyAsync("Damn. You threatend a Tree to kill it if it doesn't give you money. Well. It Didn't afterall. You brutaly killed it. Too bad. His Brother Gave You " + cash + "$ To protect the rest of the family. You're a murder.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("I'm maybe not human, but I'm not stupid. You don't have this item. smh. What We're you even thinking?");
                    }
                }
                if (item == "LuckyCoin")
                {
                    TransactionLogger.NewLog(user);
                    if (ProfileCollection.HasItem(item) == true)
                    {
                        Random rnd = new Random();
                        int cash;
                        cash = rnd.Next(1034, 1933);
                        ProfileCollection.RemoveItem(item);
                        CashCollection.AddCash(cash);
                        await ReplyAsync("You used it and got " + cash + "$, I wonder where this came from. hmm. Wait IS THAT STOLEN FROM MARIO BROS? EW *Silently Dies of cringe*");
                    }
                    else
                    {
                        await ReplyAsync("I'm maybe not human, but I'm not stupid. You don't have this item. smh. What We're you even thinking?");
                    }
                }
                if (item == "NineteenDollarFortniteCard")
                {
                    TransactionLogger.NewLog(user);
                    if (ProfileCollection.HasItem(item) == true)
                    {
                        Random rnd = new Random();
                        int cash;
                        cash = rnd.Next(18, 19);
                        ProfileCollection.RemoveItem(item);
                        CashCollection.AddCash(cash);
                        if (cash == 19)
                        {
                            await ReplyAsync("Damn. you got " + cash + "$, Why did you even get this! This is gross im gonna go touch some fn wood dude. goodbye");
                        }
                        else
                        {
                            await ReplyAsync("Wow how generous of fortnite. they gave you " + cash + "$. Wait... THEY SCAMMED YOU FOR 1$ HAHHA LOOSER");
                        }
                    }
                    else
                    {
                        await ReplyAsync("I'm maybe not human, but I'm not stupid. You don't have this item. smh. What We're you even thinking?");
                    }
                }
                if (item == "InfinityCoin")
                {
                    TransactionLogger.NewLog(user);
                    if (ProfileCollection.HasItem(item) == true)
                    {
                        ProfileCollection.RemoveItem(item);
                        CashCollection.AddCash(10000000);
                        await ReplyAsync("He... is... inevitable.. well congrats for using the rarest item. you got 10 million coins. goodluck with em all");
                    }
                    else
                    {
                        await ReplyAsync("I'm maybe not human, but I'm not stupid. You don't have this item. smh. What We're you even thinking?");
                    }
                }
                if (item == "GucciCloths")
                {
                    TransactionLogger.NewLog(user);
                    if (ProfileCollection.HasItem(item) == true)
                    {
                        ProfileCollection.RemoveItem(item);
                        if (Profile.RandomizeChoice() == "T")
                        {
                            Random rnd = new Random();
                            int cash;
                            cash = rnd.Next(30000, 64311);
                            CashCollection.AddCash(cash);
                            await ReplyAsync("You dripped the world away with your fake gucci clothes. you had luck that you didn't get exposed.. You got " + cash + "$ from scamming people..");
                        }
                        else
                        {
                            await ReplyAsync("You got exposed over social media for your fake gucci clothes. The world hates you. you lost lots of cash. people pretty much robbed you.");
                            CashCollection.RemoveCash(3000);
                        }
                    }
                    else
                    {
                        await ReplyAsync("I'm maybe not human, but I'm not stupid. You don't have this item. smh. What We're you even thinking?");
                    }
                }

                if (item == "InfinityGauntlet")
                {
                    TransactionLogger.NewLog(user);
                    if (ProfileCollection.HasItem(item) == true)
                    {
                        if (ProfileCollection.HasItem("MoneyStone"))
                        {
                            if (Profile.RandomizeChoice() == "T")
                            {

                            }
                            else
                            {
                                await ReplyAsync("Aha, you had it all you snapped your finger, and awfully died! what a loser you are. really. Ur Cash Is bye bye.");
                                CashCollection.RemoveCash(2000000000);
                            }
                        }
                    }
                }
            }
        }
        [Command("meme")]
        public async Task Meme()
        {
            var HttpReq = new HttpClient();
            var res = await HttpReq.GetStringAsync("https://reddit.com/r/memes/random.json?limit=1");
            JArray arr = JArray.Parse(res);
            JObject rPost = JObject.Parse(arr[0]["data"]["children"][0]["data"].ToString());
            var eBuilder = new EmbedBuilder()
                .WithImageUrl(rPost["url"].ToString())
                .WithTitle(rPost["title"].ToString())
                .WithColor(Color.Blue)
                .WithFooter("💬 " + rPost["num_comments"] + " ⬆️ " + rPost["ups"]);
            var eRes = eBuilder.Build();

            await ReplyAsync(embed: eRes);
        }
        [Command("inv")]
        public async Task Inv(string user)
        {
            TransactionLogger.NewLog(user);
            var eBuilder = new EmbedBuilder()
                .WithTitle(user + "'s Inventory!")
                .WithDescription(ProfileCollection.ListInventory());
            var eRes = eBuilder.Build();
            await ReplyAsync(embed: eRes);
        }
        [Command("rob")]
        public async Task Rob(string user, string currUser)
        {
            TransactionLogger.NewLog(user);
            TransactionLogger.CurrLog(currUser);
            string status = CashCollection.Rob();
            if (status.Contains("You Just Stole"))
            {
                await ReplyAsync("You Stole Lotta Cash. Get Out of there before the police comes m8");
            }
            else
            {
                await ReplyAsync("You fucked up and got caught by the police");
            }
        }

        [Command("getroleinfo")]
        public async Task GetRoleInfo(string roleStr)
        {
            var role = Context.Guild.GetRole(Context.Message.MentionedRoles.First().Id);
            var e = new EmbedBuilder();
                e.AddField("Is Admin : ", role.Permissions.Administrator ? "Yes" : "No");

            var build = e.Build();
            await ReplyAsync(embed: build);
        }
    }
}
