using System;
using System.Collections.Generic;

public class MenuItem
{
	public List<MenuItem> Children = new List<MenuItem>();

	public virtual void Start() { }

	public virtual string Name { get;}

	public virtual string KeyName { get;}

	public virtual string Key { get;}
}
