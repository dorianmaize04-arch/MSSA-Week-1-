int num1, num2, result = 0;

Console.WriteLine("I am you area calculator.");
Console.WriteLine("Choose a shape to calculate the area:");
Console.WriteLine();
Console.WriteLine("A: Triangle");
Console.WriteLine("B: Square");
Console.WriteLine("C: Rectangle");

string choice = Console.ReadLine().ToUpper();


switch (choice)
    { case "A":
        Console.WriteLine("Please enter the base of the triangle:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the height of the triangle:");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = (num1 * num2) / 2;
        Console.WriteLine($"The area of the triangle is: {result}");
        break;

    case "B":
        Console.WriteLine("Please enter the length of one side of the square:");
        num1 = Convert.ToInt32(Console.ReadLine());
        result = num1 * num1;
        Console.WriteLine($"The area of the square is: {result}");
        break;

    case "C":
        Console.WriteLine("Pleas eneter the length of the rectangle :");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the width of the rectangle");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = num1 * num2;
        Console.WriteLine($"The area of the rectangle is: {result}");
        break;

    default:
        Console.WriteLine("Invalid choice. Please select A, B, or C.");
        break;

}

