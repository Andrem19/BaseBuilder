using CryptoRychara.GetChartData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBuilder
{
    public static class Variables
    {
        public static string symbol { get; set; } = "BTCUSDT";
        public static string interval { get; set; } = "15m";
        public static string baseAddress { get; set; } = $"C:\\Users\\72555\\Desktop\\MarketData\\{symbol}";
        public static string addressToSave { get; set; } = $"C:\\Users\\72555\\Desktop\\MarketData";
        public static List<string> Dirs { get; set; }
        public static List<DataModel> FullDataSet { get; set; } = new();
    }
}
