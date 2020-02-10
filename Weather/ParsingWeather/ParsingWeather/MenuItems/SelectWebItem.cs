using System;
using System.Collections.Generic;

public class SelectWebItem:MenuItem
{
	Menu menu;

	public SelectWebItem(State state)
	{
		Children.Add(new WeatherstackItem(state));
		Children.Add(new OpenweathermapItem(state));
		Children.Add(new ExitItem());
		menu = new Menu(Children);
	}

	override public void Start() {
		menu.Start();
	}
	public override string Name { get; } = "SelectWebItem";

	public override string KeyName { get; } = "w";

	public override string Key { get; } = "w";
}
