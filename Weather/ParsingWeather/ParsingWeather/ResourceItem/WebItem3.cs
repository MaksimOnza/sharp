using System;

public class WebItem3: MenuItem
{
    public WebItem3()
	{
	}

    public string getName { get; } = "Web3";

    public string getKeyName { get; } = "3";

    public string getKey { get { return getKeyName; } }
}
