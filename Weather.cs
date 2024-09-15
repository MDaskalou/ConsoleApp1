
namespace ConsoleApp1
{
   abstract class Weather
    {
        public abstract void DescribeSeasons();
    }

    class Rain : Weather
    {
        public override void DescribeSeasons()
        {
            Console.WriteLine("Rain is a type of weather");
        }
    }

    class Sun : Weather 
    {
        public override void DescribeSeasons()
        {
            Console.WriteLine("Sun is a type of weather");
        }
    }

}
