﻿using System;
using System.Collections;
using System.Collections.Generic;

public class WebSelect: MenuItem
{
    private Menu webSelect;

    public string getName { get; } = "WebSelect";

    public string getKeyName { get; } = "w";

    public string getKey { get; } = "w";


    public WebSelect(List<MenuItem> items)
	{
        webSelect = new Menu(items);
    }

    public void start()
    {
        webSelect.Start();
    }
        
}
