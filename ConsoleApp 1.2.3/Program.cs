string choice = "Y";

do
{ 
Console.WriteLine("Insert Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Insert Number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Would you like to add (A), subtract (S), multiply (M) or divide (D) ? (Type either A, S, M, or D)");
string operation = Console.ReadLine();

  
switch (operation)
{
    case "A":
        int result = num1 + num2;
        Console.WriteLine($"The result is {result}");
        break;

    case "S":
        int result2 = num1 - num2;
        Console.WriteLine($"The result is {result2}");
        break;

    case "M":
        int result3 = num1 * num2;
        Console.WriteLine($"The result is {result3}");
        break;

    case "D":
        int result4 = num1 / num2;
        Console.WriteLine($"The result is {result4}");
        break;



default:
    Console.WriteLine("please pick a valid character");
    break;
}
    Console.WriteLine("Would you like to continue? Type Y for yes or N for no");
    choice = Console.ReadLine().ToUpper();
}
 while (choice == "Y");


