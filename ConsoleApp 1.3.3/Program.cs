Console.WriteLine($"The numbers in the array are: ");

int[] numbers = { 2, 5, 7 };

foreach (int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"The numbers in reverse order are: ");



Array.Reverse(numbers);

foreach (int number in numbers)
{
    Console.Write(number + " ");
}



