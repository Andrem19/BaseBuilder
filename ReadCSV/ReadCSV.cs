using BaseBuilder;
using CryptoRychara.GetChartData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStrategyRychara.GetChartData.ReadCSV
{
    public class ReadCSV
    {
        public static string ServerAdress { get; set; } = "Administrator";
        public static string PcAdress { get; set; } = "72555";
        public static string old { get; set; } = "";
        public static string adress { get; set; } = "";
        public async static Task<List<DataModel>> readData(string path, bool check)
        {            
            List<DataModel> values = File.ReadAllLines(path)
                                          .Select(v => FromCsv(v, check))
                                          .ToList();
            return values;
        }
        public static DataModel FromCsv(string csvLine, bool check)
        {
            DataModel dailyValues = new DataModel();
            if (check == false)
            {
                string[] values = csvLine.Split(',');
                
                dailyValues.open_time = Convert.ToInt64(values[0]) / 1000;
                dailyValues.open = Convert.ToDouble(values[1]);
                dailyValues.high = Convert.ToDouble(values[2]);
                dailyValues.low = Convert.ToDouble(values[3]);
                dailyValues.close = Convert.ToDouble(values[4]);
                dailyValues.volume = Convert.ToDouble(values[5]);
                dailyValues.close_time = Convert.ToInt64(values[6]) / 1000;
            }
            else if (check == true)
            {
                string[] values = csvLine.Split(',');

                dailyValues.open_time = Convert.ToInt64(values[0]);
                dailyValues.open = Convert.ToDouble(values[1]);
                dailyValues.high = Convert.ToDouble(values[2]);
                dailyValues.low = Convert.ToDouble(values[3]);
                dailyValues.close = Convert.ToDouble(values[4]);
                dailyValues.volume = Convert.ToDouble(values[5]);
                dailyValues.close_time = Convert.ToInt64(values[6]);
            }
            return dailyValues;
        }
    }
    
}
