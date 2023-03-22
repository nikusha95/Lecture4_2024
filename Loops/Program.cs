using System.Threading.Channels;

string s = Console.ReadLine();


bool res = int.TryParse(s, out int number);
if (res)
{
    int even = 0, odd = 0;

    while (number > 0)
    {
        if (number % 2 == 0)
        {
            even += number;
        }
        else
        {
            odd += number;
        }

        number--;
    }

    Console.WriteLine($"even sum is {even}\nodd sum is {odd}");
}

int x = 4;
int sum = 0;
while (x > 0)
{
    Console.WriteLine(x);
    if (x == 3)
    {
        x--;
        continue;
    }

    sum += x;

    x--;
}

Console.WriteLine($"sum is {sum}");


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}