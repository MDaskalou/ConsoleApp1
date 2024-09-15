

namespace ConsoleApp1
{

    public class Summer : SeasonsBase
    {
       public static string _seasonName = "Summer";
       public static string _seasonTime = "June - August";
       public static string _seasonWeather = "Warm";
       public static int  _temperature = 25;
        public Summer()
            : base(_temperature, _seasonName, _seasonWeather, _seasonTime) { }

        public void Describe()
        {
           var description = base.DescribeSeason();
           Console.WriteLine(description);
        }
    }
}