using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Unit Conversion Tool by Jeremy");
            Console.WriteLine("1. Convert Length");
            Console.WriteLine("2. Convert Mass");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertLengthMenu();
                    break;
                case "2":
                    ConvertMassMenu();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Choice, please select again");
                    break;
            }
        }
    }

    // Conversion Input Menus for Length and Mass Below
    public static void ConvertLengthMenu()
    {
        Console.WriteLine("Enter the value to convert:");
        string valueInput = Console.ReadLine();
        double value = valueInput != null ? double.Parse(valueInput) : 0.0;

        Console.WriteLine("Enter the unit to convert from (meters, centimeters, millimeters, inches, feet):");
        string fromUnit = Console.ReadLine();

        Console.WriteLine("Enter the unit to convert to (meters, centimeters, millimeters, inches, feet):");
        string toUnit = Console.ReadLine();

        double result = ConvertLength(value, fromUnit, toUnit);
        Console.WriteLine($"Converted value: {result} {toUnit}");
    }

    public static void ConvertMassMenu()
    {
        // Get Mass to convert
        Console.WriteLine("Enter the value to convert: ");
        string? valueInput = Console.ReadLine();
        double value = valueInput != null ? double.Parse(valueInput) : 0.0;
        // Get current unit of mass 
        Console.WriteLine("Enter the unit to convert from (kilograms, grams, milligrams, pounds, ounces): ");
        string? fromUnit = Console.ReadLine();
        // Get desired unit of mass
        Console.WriteLine("Enter the unit to convert to (kilograms, grams, milligrams, pounds, ounces): ");
        string? toUnit = Console.ReadLine();

        double result = ConvertMass(value, fromUnit, toUnit);
        Console.WriteLine($"Converted value: {result} {toUnit}");
    }

    // Conversion Logic for Length and Mass Below

    public static double ConvertLength(double value, string fromUnit, string toUnit)
    {
        double convertedValue = value;

        switch (fromUnit.ToLower())
        {
            case "meters":
                convertedValue = value;
                break;
            case "centimeters":
                convertedValue = value / 100;
                break;
            case "millimeters":
                convertedValue = value / 1000;
                break;
            case "inches":
                convertedValue = value * 0.0254;
                break;
            case "feet":
                convertedValue = value * 0.3048;
                break;
            default:
                Console.WriteLine("Invalid 'from' unit for conversion.");
                return value;
        }

        switch (toUnit.ToLower())
        {
            case "meters":
                return convertedValue;
            case "centimeters":
                return convertedValue * 100;
            case "millimeters":
                return convertedValue * 1000;
            case "inches":
                return convertedValue / 0.0254;
            case "feet":
                return convertedValue / 0.3048;
            default:
                Console.WriteLine("Invalid 'to' unit for conversion.");
                return value;
        }
    }

    // kilograms, grams, milligrams, pounds, ounces
    public static double ConvertMass(double value, string fromUnit, string toUnit)
    {
        double convertedValue = value;

        // Convert from the original unit to kilograms
        switch (fromUnit.ToLower())
        {
            case "kilograms":
                convertedValue = value;
                break;
            case "grams":
                convertedValue = value / 1000;
                break;
            case "milligrams":
                convertedValue = value / 1000000;
                break;
            case "pounds":
                convertedValue = value * 0.453592;
                break;
            case "ounces":
                convertedValue = value * 0.0283495;
                break;
            default:
                Console.WriteLine("Invalid 'from' unit for conversion.");
                return value;
        }

        // Convert from kilograms to the desired unit
        switch (toUnit.ToLower())
        {
            case "kilograms":
                return convertedValue;
            case "grams":
                return convertedValue * 1000;
            case "milligrams":
                return convertedValue * 1000000;
            case "pounds":
                return convertedValue / 0.453592;
            case "ounces":
                return convertedValue / 0.0283495;
            default:
                Console.WriteLine("Invalid 'to' unit for conversion.");
                return value;
        }
    }
}
