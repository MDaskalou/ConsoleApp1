using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        //Arvkonceptet
        {
            //här skapar vi objekt av klassen Seasons
            //SeasonsBase seasons = new SeasonsBase();
            //seasons.DescribeSeasons();
         
            var summer = new Summer();
            summer.Describe();

            // Polymorfismkonceptet

            //här skapar vi objekt av klassen Winter
            //Winter winter = new Winter();


            // Tilldelning av egenskaper för vintern



            // Användning av metoden DescribeSeason för vintern

            //winter.DescribeSeasons();

            // Inkapslingskonceptet


            Spring spring = new Spring("Spring", "April - June", "Warm");

            spring.DisplayInfo();

            //Abstraktionskonceptet

            //här skapar vi objekt av klassen Rain
            Rain rain = new Rain();
            rain.DescribeSeasons();

            //här skapar vi objekt av klassen Sun
            Sun sun = new Sun();
            sun.DescribeSeasons();



        }


    }
}
