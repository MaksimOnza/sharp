using System;

public class DisplayWeatherItem: MenuItem
{
	ControllerDisplayWeather displaweather;
	public DisplayWeatherItem()
	{
		displaweather = new ControllerDisplayWeather();
	}
	override public void start() {
		displaweather.start();
	}
	public override string Name { get; } = "DisplayWeatherItem";
	public override string KeyName { get; } = "d";
	public override string Key { get; } = "d";
}
