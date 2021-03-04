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
                SourceCodeController controller = new SourceCodeController();
                int loc = controller.CountCodeLines(controller.ReadContent(args[0]));
                Console.WriteLine($"Lines of code: {loc}");
                return 0;
            }
            else return 1;
        }
    }
}
