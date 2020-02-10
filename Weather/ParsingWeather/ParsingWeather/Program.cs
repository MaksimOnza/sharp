using System.Collections.Generic;
namespace ParsingWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            State state = new State();
            Dictionary<string, Resources> resource = new Dictionary<string, Resources>() { { "Weatherstack", new WeatherstackResource(Config.WEATHERSTACK_ACCESS_KEY) },
                                                                                           { "Openweathermap", new OpenweathermapResource(Config.OPENWEATHERMAP_ACCESS_KEY) }};

            List<MenuItem> Children = new List<MenuItem>();
            Children.Add(new SelectWebItem(state));
            Children.Add(new SelectCityItem(state));
            Children.Add(new DisplayWeatherItem(state, resource));
            Children.Add(new ExitItem());

            var appWeather = new Menu(Children);
            appWeather.Start();
        }

    }
}
