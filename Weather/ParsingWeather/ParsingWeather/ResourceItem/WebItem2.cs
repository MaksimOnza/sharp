using System;

public class WebItem2: MenuItem
{
    public WebItem2()
	{
	}

    public string getName { get; } = "Web2";

    public string getKeyName { get; } = "2";

    public string getKey { get { return getKeyName; } }
}
