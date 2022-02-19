using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBuilder
{
    public class ExtractZip
    {
        public static async Task Extract()
        {
            List<string> directories = new List<string>();
            directories = Directory.GetFiles(Variables.addressToSave).ToList();
            for (int i = 0; i < directories.Count; i++)
            {
                ZipFile.ExtractToDirectory(directories[i], Variables.addressToSave);
                File.Delete(directories[i]);
            }
            
        }
    }
}
