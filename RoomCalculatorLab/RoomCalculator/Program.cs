// See https://aka.ms/new-console-template for more information
using RoomCalculatorLab;

RoomCalculator bedroom = new RoomCalculator();

Console.WriteLine("Enter the length of the room:");
bedroom.Length = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the width of the room:");
bedroom.Width = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"The area of the room is: {bedroom.CalculateArea()} square feet");
Console.WriteLine($"The perimeter of the room is: {bedroom.CalculatePerimeter()} feet");
Console.WriteLine($"Based on the calculations your room would be classified as {bedroom.ClassifyRoom()}");
