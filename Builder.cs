using CryptoRychara.GetChartData;
using TestStrategyRychara.GetChartData.ReadCSV;

namespace BaseBuilder
{
    public class Builder
    {
        public static async Task BuildBase()
        {
            //List<string> directories = new List<string>();
            //directories = GetDir.GetDirs();
            List<string> file = new List<string>();
            List<DataModel> dataModels = new List<DataModel>();
            file = Directory.GetFiles(Variables.addressToSave).ToList();
            for (int i = 0; i <= file.Count-1; i++)
            {
                dataModels = await ReadCSV.readData(file[i], true);
                using (StreamWriter sw = File.AppendText($"{Variables.addressToSave}\\{Variables.interval}{Variables.symbol}.csv"))
                {
                    for (int j = 0; j < dataModels.Count - 1; j++)
                    {
                        var line = string.Format($"{dataModels[j].open_time}, {dataModels[j].open}, {dataModels[j].high}, {dataModels[j].low}, {dataModels[j].close}, {dataModels[j].volume}, {dataModels[j].close_time}");
                        sw.WriteLine(line);
                        sw.Flush();
                    }
                }
                if (dataModels.Count > 0)
                {
                    File.Delete(file[i]);
                    Console.WriteLine($"{file[i]} was added");
                }
            }
            
        }
    }
}
