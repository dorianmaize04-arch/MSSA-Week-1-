Console.WriteLine("Hello, World!");
string[] breakfast = { "Eggs", "Bacon", "Toast" };

Console.WriteLine(breakfast[2]);
for (int i = 0; i < breakfast.Length; i++)
{
    Console.WriteLine(breakfast[i]);
}

foreach (string item in breakfast)
{
    Console.WriteLine(item);
}