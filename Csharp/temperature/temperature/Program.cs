
Console.WriteLine("Temperature in Celsius\tTemperature in Fahrenheit");
for (int i = 0; i <= 90; i = i + 10)
{
    int fahrenheit = (i * 9) / 5 + 32;
    Console.WriteLine($"{i}\t\t\t\t{fahrenheit}°F");
}


