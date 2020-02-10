using System;

public class OpenweathermapItem: MenuItem
{
	State state;

	public OpenweathermapItem(State state)
	{
		this.state = state;
	}

	override public void Start()
	{
		state.resource = Name;
	}

	public override string Name { get; } = "Openweathermap";

	public override string KeyName { get; } = "2";

	public override string Key { get; } = "2";
}
