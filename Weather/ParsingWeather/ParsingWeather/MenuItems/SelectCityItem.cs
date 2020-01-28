using System;

public class SelectCityItem: MenuItem
{
	private string cityName;
	public SelectCityItem()
	{
	}
	override public void start() {
		Console.WriteLine();
		Console.WriteLine("Enter a City");
		cityName = Console.ReadLine();
		TransitData.cityName = cityName;
	}
	public override string Name { get; } = "SelectCityItem";
	public override string KeyName { get; } = "c";
	public override string Key { get; } = "c";
}
