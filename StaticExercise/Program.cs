namespace StaticExercise
{
    public  static class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("After Conversion");  
            var celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"Celsius {celsius}");
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"Fahrenheit {fahrenheit}");
            
        }
    }
}
