using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace RQ_0x1_CodeLines
{
    public class Program
    {
        public static int Main(string[] args)
        {
            bool fileExists = File.Exists(args[0]);
            if (fileExists)
            {
                return 0;
            }
            else return 1;
        }
    }
}
