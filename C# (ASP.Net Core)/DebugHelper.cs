using System;
using System.Text.Json;
using System.Diagnostics;

public static class DebugHelper
{
	public static void d(object data)
	{
		string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
		
		Console.WriteLine(data.GetType());// Prints to Console
		Console.WriteLine(json);

		Debug.WriteLine(data.GetType());// Prints to Debug Output in Visual Studio
		Debug.WriteLine(json);
	}

	public static void e(object data)
	{
		Console.WriteLine( data );
	}
}