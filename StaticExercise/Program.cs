namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var celsius = TempConverter.FahrenheitToCelsius(67);

            var fahrenheit = TempConverter.CelsiusToFahrenheit(21);

            Console.WriteLine($"{celsius}");
            Console.WriteLine($"{fahrenheit}");
        }
    }
}
