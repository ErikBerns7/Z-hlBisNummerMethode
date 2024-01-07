

Console.WriteLine("Tell me a number to count to");
string numberText = Console.ReadLine();
int number = Convert.ToInt32(numberText);

Console.Clear();


Count(number);



void Count(int numberToCountTo)
{   
    for (int i = 1; i <= numberToCountTo; i++)
    {
        Console.WriteLine(i);
    }
}