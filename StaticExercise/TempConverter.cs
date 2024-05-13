using System;
namespace StaticExercise
{
	public class TempConverter
	{

		public static double FahrenheitToCelsius(double temp1)
		{
			var result = (temp1 - 32) / 1.8;
			return result;
		}

		public static double CelsiusToFahrenheit(double temp2)
		{
			return (temp2 * 9) / 5 + 32;
			 
		}
		public TempConverter()
		{
		}
	}
}

