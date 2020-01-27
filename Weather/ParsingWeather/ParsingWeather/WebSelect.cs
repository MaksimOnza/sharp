using System;
using System.Collections;
using System.Collections.Generic;

public class WebSelect: MenuItem
{
    private Menu webSelect;

    public string getName { get; } = "WebSelect";

    public string getKeyName { get; } = "w";

    public string getKey { get; } = "w";


    public WebSelect(ArrayList items)
	{
        webSelect = new Menu(items);
    }

    public void start()
    {
        webSelect.start();
    }
        
}
