using System;
using System.Reflection.PortableExecutable;

namespace Temperature
{
	public class Temp_Checker
	{
		public static void Temperature()
		{
			
			int invalidInput = 0;
			int reader = 3;

            while (invalidInput < 3)
            {
                try
                {

                    int temperature;
                    Console.WriteLine("Insert temperature reading");

                    temperature = Convert.ToInt32(Console.ReadLine());

                    if (temperature < 0 || temperature > 100)
                    {
                        Console.WriteLine("The temperature reading is invalid");
                        invalidInput++;
                        reader--;
                        Console.WriteLine($"You've {reader} more tries before sensor breaks");
                    }
                    else if (temperature > 30)
                    {
                        Console.WriteLine("The temperature is critical");
                        Console.WriteLine();
                    }
                    else if (temperature > 24 && temperature <= 30)
                    {
                        Console.WriteLine("Warning!, temperature is a bit high");
                        Console.WriteLine();
                    }
                    else if (temperature <= 24)
                    {
                        Console.WriteLine("The temperature is normal");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bad input, enter numeric values only");
                }
            }
            Console.WriteLine("Sensor broken!!!");
        }
	}
}


