
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViperBot.Services.ReaderService
{
    class RService
    {
        public static string Read(string file)
        {
            return File.ReadAllText(file);
        }
    }
}
