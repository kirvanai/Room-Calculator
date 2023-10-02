using System;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
        Console.WriteLine("Enter Length:");
        string entryLength = Console.ReadLine();
        double length = double.Parse(entryLength);
        Console.WriteLine("Enter Width:.");
        string entryWidth = Console.ReadLine();
        double width = double.Parse(entryWidth);
        Console.WriteLine("Enter Height:");
        string entryHeight = Console.ReadLine();
        double height = double.Parse(entryHeight);
        double area = width * length;
        double perimeter = width + width + length + length;
        double volume = length * width * height;
        double surfaceArea = 2 * (area) + 2 * (length * height) + 2 * (width * height);
        string roomClassification;
        
        if (area <= 250)
            {
            roomClassification = "small";
            }
        else if (area > 250 & area < 650) 
            {
            roomClassification = "medium";
            }
        else 
            {
            roomClassification = "large";
            }
        
        
        
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine($"Volume: {volume}");
        Console.WriteLine($"Surface Area: {surfaceArea}");
        Console.WriteLine($"Room Size: {roomClassification}");
        Console.WriteLine("Thank you for using the Room Detail Generator!");
    }
}