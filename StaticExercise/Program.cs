namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit -> Celsius");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(212));

            Console.WriteLine("Celsius -> Fahrenheit");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(100));
        }
    }
}
