using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Distance Converter");
            Console.WriteLine("By Fudail Khan");
            Console.WriteLine("");

            Console.WriteLine("Select unit to convert from:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Meters");
            Console.WriteLine("");

            int fromUnit;
            while (true)
            {
                Console.Write("Enter your choice (1-3): ");
                if (!int.TryParse(Console.ReadLine(), out fromUnit) || fromUnit < 1 || fromUnit > 3)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("");

            Console.WriteLine("Select unit to convert to:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Meters");
            Console.WriteLine("");

            int toUnit;
            while (true)
            {
                Console.Write("Enter your choice (1-3): ");
                if (!int.TryParse(Console.ReadLine(), out toUnit) || toUnit < 1 || toUnit > 3)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("");

            Console.Write("Enter the distance: ");
            double distance;
            while (!double.TryParse(Console.ReadLine(), out distance))
            {
                Console.WriteLine("Invalid distance. Please enter a valid number.");
                Console.Write("Enter the distance: ");
            }
            Console.WriteLine("");

            string fromUnitStr = "";
            string toUnitStr = "";
            double convertedDistance = 0;

            switch (fromUnit)
            {
                case 1:
                    fromUnitStr = "miles";
                    switch (toUnit)
                    {
                        case 1:
                            toUnitStr = "miles";
                            convertedDistance = distance;
                            break;
                        case 2:
                            toUnitStr = "feet";
                            convertedDistance = distance * 5280;
                            break;
                        case 3:
                            toUnitStr = "meters";
                            convertedDistance = distance * 1609.34;
                            break;
                    }
                    break;
                case 2:
                    fromUnitStr = "feet";
                    switch (toUnit)
                    {
                        case 1:
                            toUnitStr = "miles";
                            convertedDistance = distance / 5280;
                            break;
                        case 2:
                            toUnitStr = "feet";
                            convertedDistance = distance;
                            break;
                        case 3:
                            toUnitStr = "meters";
                            convertedDistance = distance / 3.281;
                            break;
                    }
                    break;
                case 3:
                    fromUnitStr = "meters";
                    switch (toUnit)
                    {
                        case 1:
                            toUnitStr = "miles";
                            convertedDistance = distance / 1609.34;
                            break;
                        case 2:
                            toUnitStr = "feet";
                            convertedDistance = distance * 3.281;
                            break;
                        case 3:
                            toUnitStr = "meters";
                            convertedDistance = distance;
                            break;
                    }
                    break;
            }

            Console.WriteLine("{0} {1} is equal to {2} {3}.", distance, fromUnitStr, convertedDistance, toUnitStr);
            Console.ReadLine();

        }
    }
}

