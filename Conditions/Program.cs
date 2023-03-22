// See https://aka.ms/new-console-template for more information

string str1 = Console.ReadLine();
string str2 = Console.ReadLine();

Console.WriteLine($"before parse {str1}, {str2}");

bool x1 = int.TryParse(str1, out int result1);
bool x2 = int.TryParse(str1, out int result2);


if (x1)
{
    result1 += 1;
    Console.WriteLine(result1); //good
}
else
{
    Console.WriteLine($"{str1} is not number");
}

if (x2)
{
    result2 += 1;
    Console.WriteLine(result2); //good
}
else
{
    Console.WriteLine($"{str1} is not number");
}

if (x1)
{
    if (result1 is > 10 and < 20)//if (result1 > 10 && result1 < 20)
    {
        Console.WriteLine("result is between 10 an 20");
    }
    else if (result1 < 10)
    {
        Console.WriteLine("result is less than 10");
    }
    else
    {
        Console.WriteLine("result is greater than 20");
    }
}