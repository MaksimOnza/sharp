using System;
using System.Collections.Generic;

public class DisplayWeatherItem: MenuItem
{
	Dictionary<string, Resources> resources;
	Resources resource;
	State state;

	public DisplayWeatherItem(State state, Dictionary<string, Resources> resources)
	{
		this.state = state;
		this.resources = resources;

	}

	override public void Start() {
		resource = resources[state.resource];
		int output = resource.GetTemperature(state.city);
		Console.WriteLine(output);
		Console.ReadKey();
	}

	public override string Name { get; } = "DisplayWeather";

	public override string KeyName { get; } = "d";

	public override string Key { get; } = "d";
}
