using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RQ_0x1_CodeLines
{
    public class SourceCodeController
    {
        string readContents;
        public string ReadContent(string path)
        {
            StreamReader streamReader = new StreamReader(path, Encoding.UTF8);
            readContents = streamReader.ReadToEnd();
            return readContents;
        }

        public int CountCodeLines(string text)
        {
            Regex regex = new Regex(@"^", RegexOptions.Multiline);

            int linesTotal = regex.Matches(text).Count;

            int single = CountSingleLineComments(text);

            int blank = CountBlankLines(text);

            return linesTotal - blank - single;
        }

        private int CountBlankLines(string text)
        {
            Regex regex = new Regex(@"^\r", RegexOptions.Multiline);

            return regex.Matches(text).Count;
        }

        private int CountSingleLineComments(string text)
        {

            Regex regex = new Regex(@"(^\s+//)|(^//)", RegexOptions.Multiline);

            return regex.Matches(text).Count;
        }
    }
}
