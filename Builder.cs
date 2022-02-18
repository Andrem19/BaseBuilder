using CryptoRychara.GetChartData;
using TestStrategyRychara.GetChartData.ReadCSV;

namespace BaseBuilder
{
    public class Builder
    {
        public static async Task BuildBase()
        {
            List<string> directories = new List<string>();
            directories = GetDir.GetDirs();
            List<string> file = new List<string>();
            List<DataModel> dataModels = new List<DataModel>();
            for (int i = 0; i < directories.Count-1; i++)
            {
                file = GetDir.GetFiles(directories[i]);
                dataModels = await ReadCSV.readData(file[0], false);
                for (int j = 0; j < dataModels.Count; j++)
                {
                    Variables.FullDataSet.Add(dataModels[i]);
                }
            }
            using (var w = new StreamWriter($"{Variables.addressToSave}\\{Variables.interval}{Variables.symbol}.csv"))
            {
                for (int i = 0; i < Variables.FullDataSet.Count-1; i++)
                {
                    var line = string.Format($"{Variables.FullDataSet[i].open_time}, {Variables.FullDataSet[i].open}, {Variables.FullDataSet[i].high}, {Variables.FullDataSet[i].low}, {Variables.FullDataSet[i].close}, {Variables.FullDataSet[i].volume}, {Variables.FullDataSet[i].close_time}");
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }
    }
}
