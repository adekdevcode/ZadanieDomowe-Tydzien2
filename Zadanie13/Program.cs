Console.WriteLine("Podaj pierwszą liczbę: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj numer operacji do wykonania: ");
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");

//int operation = int.Parse(Console.ReadLine());

string operation = Console.ReadLine();

int operationType = 0;

Int32.TryParse(operation, out operationType);

double result = 0;

try
{
    switch (operationType)
    {
        case 1:
            result = number1 + number2;
            break;
        case 2:
            result = number1 - number2;
            break;
        case 3:
            result = number1 * number2;
            break;
        case 4:
            if (number2 == 0)
                throw new ArithmeticException("Niestety nie można dzielić przez 0");
            result = (double)number1 / number2;
            break;
        default:
            throw new Exception("Nie ma takiej operacji");
    }

    Console.WriteLine($"Twój wynik to: {result}");
}
catch (ArithmeticException a)
{
    Console.WriteLine($"{a}");
}
catch (Exception e)
{
    Console.WriteLine($"{e}");
}