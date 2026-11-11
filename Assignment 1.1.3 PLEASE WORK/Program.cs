Console.WriteLine("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

int quotient = num1 / num2;
Console.WriteLine($"The answer is {quotient}!");

int remainder = num1 % num2;
Console.WriteLine($"Remainder: {remainder}");