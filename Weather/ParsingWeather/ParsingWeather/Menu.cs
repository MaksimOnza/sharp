using System;
using System.Collections;
using System.Collections.Generic;

public class Menu
{
	string key = "";
	char EXIT = 'q';
	private List<MenuItem> Children = new List<MenuItem>();
	public Menu(List<MenuItem> items)
	{
		Children = items;
	}

	public void start()
	{
		key = "";
		while (key != EXIT.ToString())
		{
			Console.Clear();
			Console.WriteLine($"City -> { TransitData.getCity()}=============Web -> {TransitData.gettWeb()}");
			Console.WriteLine("*****************************************************************");
			foreach (var item in Children)
			{
				Console.WriteLine($"{item.Name} -> {item.KeyName}");
			}
			key = Console.ReadLine();
			foreach (var item in Children)
			{
				if (item.Key == key)
					item.start();
			}
		}
	} 
}