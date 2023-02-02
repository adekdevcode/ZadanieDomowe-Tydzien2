Console.WriteLine("Podaj 3 liczby: ");
Console.WriteLine("Liczba 1: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Liczba 2: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Liczba 3: ");
int number3 = int.Parse(Console.ReadLine());

int max = 0;

if (number1 > number2)
{
    max = number1;
} else
{
    max = number2;
}

if (max < number3)
{
    max = number3;
}

Console.WriteLine($"{max} jest największa z podanych");