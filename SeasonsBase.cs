namespace ConsoleApp1
{
    public class SeasonsBase
    {
        private int Temperature { get; set; }
        private string SeasonName { get; set; }
        private string SeasonTime { get; set; }
        private string SeasonWeather { get; set; }
        public SeasonsBase(int temperature, string seasonName, string seasonWeather, string seasonTime)
        {
            Temperature = temperature;
            SeasonName = seasonName;
            SeasonTime = seasonTime;
            SeasonWeather = seasonWeather;
        }

        public string DescribeSeason()
        {
            return $"During {SeasonName} it is very {SeasonWeather} and the temperature is around {Temperature}";
        }
    }
}