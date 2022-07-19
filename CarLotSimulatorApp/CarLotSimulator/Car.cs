using System;
public class Car
{
	public Car()
	{
	}

	public int Year { get; set; }
	public string Make { get; set; }
	public string Model { get; set; }
	public string EngineNoise { get; set; } = "Vroom";
	public string HonkNoise { get; set; } = "Beep";
	public bool IsDriveable { get; set; }

	public void MakeEngineNoise()
	{
		Console.WriteLine(EngineNoise);
	}
	public void MakeHonkNoise()
	{
		Console.WriteLine(HonkNoise);
	}
}
