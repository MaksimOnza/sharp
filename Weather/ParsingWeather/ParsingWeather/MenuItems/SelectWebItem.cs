using System;
using System.Collections.Generic;

public class SelectWebItem:MenuItem
{
	Menu menu;
	public SelectWebItem()
	{
		Children.Add(new WeatherstackItem());
		Children.Add(new ExitItem());
		menu = new Menu(Children);
	}
	override public void start() {
		menu.start();
	}
	public override string Name { get; } = "SelectWebItem";
	public override string KeyName { get; } = "w";
	public override string Key { get; } = "w";
}
