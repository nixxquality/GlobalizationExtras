using System;
using System.Globalization;

namespace GlobalizationExtras
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Registering ja-JP-Latn...");
            try
            {
                var builder = new CultureAndRegionInfoBuilder("ja-JP-Latn", CultureAndRegionModifiers.None);
                builder.LoadDataFromCultureInfo(new CultureInfo("ja-JP"));
                builder.LoadDataFromRegionInfo(new RegionInfo("JP"));

                builder.CultureEnglishName = "Japanese (Romaji)";
                builder.CultureNativeName = "日本語 (ローマ字)";

                builder.Register();
                Console.WriteLine("Done!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Already registered.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Not authorized! Run the program as administrator.");
            }
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}