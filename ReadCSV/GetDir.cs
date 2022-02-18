using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBuilder
{
    public class GetDir
    {
        public static List<string> GetDirs()
        {
            List<string> dirs = new List<string>();
            Variables.Dirs = dirs;
            return Directory.GetDirectories(Variables.baseAddress).ToList();
        }
        public static List<string> GetFiles(string path)
        {
            List<string> dirs = new List<string>();
            return Directory.GetFiles(path).ToList();
        }
    }
}
