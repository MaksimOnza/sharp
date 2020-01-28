using Newtonsoft.Json.Linq;
using System;

public interface ParserWeb
{

	JToken start(string response);
}
