using System;
using System.IO;

namespace ViperBot.Services.General
{
    class TransactionLogger
    {
        // Transaction Logger is for tracking who sent the message
        public static void NewLog(string str)
        {
            File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\latestTransaction", str);
        }
        public static void CurrLog(string str)
        {
            File.WriteAllText(Environment.CurrentDirectory + "\\Profiles\\currUserTransaction", str);
        }
    }
}
