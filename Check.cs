using CustomCexWrapper.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStrategyRychara.GetChartData.ReadCSV;

namespace BaseBuilder
{
    public class Check
    {
        public static async Task Checkdata()
        {
            string[] path = Directory.GetFiles(@"C:\Users\72555\Desktop\MarketData");
            Variables.FullDataSet = await ReadCSV.readData(path[0], false);
            int pause = 0;
            for (int i = 0; i < Variables.FullDataSet.Count-1; i++)
            {
                if (pause < i)
                {
                    Console.WriteLine(UnixTimeHelper.UnixTimeStampToDateTime((long)Variables.FullDataSet[i].open_time));
                    pause = i + 200;
                }
            }
            Console.WriteLine($"Count: {Variables.FullDataSet.Count}");
        }
    }
}
