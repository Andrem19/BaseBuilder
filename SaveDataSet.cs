using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBuilder
{
    public class SaveDataSet
    {
        public async static Task<string> SLogs(object model)
        {
            string output = JsonConvert.SerializeObject(model);
            string folderName = Variables.addressToSave;
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            string path = Path.Combine(folderName, $"{Variables.interval}{Variables.symbol}.csv");
            using (FileStream file = new FileStream(path, FileMode.Append))
            using (StreamWriter stream = new StreamWriter(file))
                stream.WriteLine(output);
            return output;
        }
    }
}
