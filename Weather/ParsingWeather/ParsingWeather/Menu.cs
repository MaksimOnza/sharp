using System;
using System.Collections;
using System.Collections.Generic;

public class Menu
{
	string key = "";
	char EXIT = 'q';
	ArrayList menuItems;
	private ClearDisplay clear = new ClearDisplay();
	private DisplayTopList topList = new DisplayTopList();
	public Menu(ArrayList items)
	{
		menuItems = items;
	}

	public void start()
	{
		while (key != EXIT.ToString())
		{
			clear.clearDisplay();
			topList.displayTopList();
			foreach (var item in menuItems)
			{
				//Console.WriteLine($"{item.getName} -> {item.getKeyName}");
			}
			key = Console.ReadLine();
			foreach (var item in menuItems)
			{
				//if (item.getKey == key)
				//	item.start();
			}
		}
	} 
}