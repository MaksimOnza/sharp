using System;

public class WebItem1: MenuItem
{
    public WebItem1()
	{
	}

    public string getName { get; } = "Web1";

    public string getKeyName { get; } = "1";

    public string getKey { get { return getKeyName; } }
}
