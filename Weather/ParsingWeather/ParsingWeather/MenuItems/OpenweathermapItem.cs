using System;

public class OpenweathermapItem: MenuItem
{
	OpenweathermapData WebData;
	public OpenweathermapItem()
	{
		WebData = new OpenweathermapData();
	}
	override public void start()
	{
		new WriteToTransit(WebData);
	}
	public override string Name { get; } = "WeatherstackItem";
	public override string KeyName { get; } = "2";
	public override string Key { get; } = "2";
}
