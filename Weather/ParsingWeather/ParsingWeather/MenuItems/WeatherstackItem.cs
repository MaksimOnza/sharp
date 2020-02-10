using System;
using System.Collections.Generic;

public class WeatherstackItem: MenuItem
{
	State state;

	public WeatherstackItem(State state)
	{
		this.state = state;
	}

	override public void Start()
	{
		state.resource = Name;
	}

	public override string Name { get; } = "Weatherstack";

	public override string KeyName { get; } = "1";

	public override string Key { get; } = "1";
}
