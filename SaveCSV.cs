using CryptoRychara.GetChartData;
using System.Text;

namespace BaseBuilder
{
    internal class SaveCSV
    {
        public static async Task Save(string path, List<DataModel> data)
        {

            if (data != null)
            {
                using (StreamWriter streamWriter = new StreamWriter(path, true, Encoding.UTF8))
                {
                    foreach (var x in data)
                    {
                        streamWriter.WriteLine($"{x.open_time}, {x.open}, {x.high}, {x.low}, {x.close}, {x.volume}, {x.close_time}");
                    }
                }
            }
        }
    }
}
