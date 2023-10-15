using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeParser
{
    public class JsonParser
    {
        public static string ParseFileForJson(string path)
        {
            Parser parser = new(path);
            parser.ReplaceEscapeCharacters();
            return parser.GetFormattedContent();
        }
    }
}
