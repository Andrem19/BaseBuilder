
using BaseBuilder;

namespace Mainrocess
{
    public static class Program
    {
        public static async Task Main()
        {
            await ExtractZip.Extract();
            await Builder.BuildBase();
            await Check.Checkdata();
        }
    }
}
