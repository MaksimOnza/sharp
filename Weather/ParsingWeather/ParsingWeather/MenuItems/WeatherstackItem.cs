using System;

public class WeatherstackItem: MenuItem
{
	WeatherstackData WebData;
	public WeatherstackItem()
	{
		WebData = new WeatherstackData();
	}
	override public void start()
	{
		new WriteToTransit(WebData);
	}
	public override string Name { get; } = "WeatherstackItem";
	public override string KeyName { get; } = "1";
	public override string Key { get; } = "1";
}
