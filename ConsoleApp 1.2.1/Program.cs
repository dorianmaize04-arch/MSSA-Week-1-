Console.WriteLine("Insert first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
    { 
    Console.WriteLine($"Both numbers are equal: {num1} = {num2}");

}
else
{
    Console.WriteLine($"The numbers are not equal: {num1} does not equal {num2}");


}

