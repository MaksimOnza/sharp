using System;

public class SelectCityItem: MenuItem
{
	private State state;

	public SelectCityItem(State state)
	{
		this.state = state;
	}

	override public void Start() {
		Console.WriteLine();
		Console.WriteLine("Enter a City");
		state.city = Console.ReadLine();
	}

	public override string Name { get; } = "SelectCityItem";

	public override string KeyName { get; } = "c";

	public override string Key { get; } = "c";
}
