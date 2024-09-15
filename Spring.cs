
namespace ConsoleApp1
{
   public class Spring
    {
        private string name;
        private string time;
        private string weather;

        public Spring(string name, string time, string weather)
        {
            Name = name;
            Time = time;
            Weather = weather;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Weather
        {
            get { return weather; }
            set { weather = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"During {Name} it is very {Weather} and the temperature is around {Time}");
        }
    }
}
