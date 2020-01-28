using System.Collections.Generic;
namespace ParsingWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> Children = new List<MenuItem>();
            Children.Add(new SelectWebItem());
            Children.Add(new SelectCityItem());
            Children.Add(new DisplayWeatherItem());
            Children.Add(new ExitItem());

            var appWeather = new Menu(Children);
            appWeather.start();
        }

    }
}
