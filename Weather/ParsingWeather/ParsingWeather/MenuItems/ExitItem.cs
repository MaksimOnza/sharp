using System;

public class ExitItem: MenuItem
{
	public override void start()
	{
		Console.Clear();
	}
	public override string Name { get; } = "Exit";
	public override string KeyName { get; } = "q";
	public override string Key { get; } = "q";

}
