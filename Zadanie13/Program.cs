//13.Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem
//    Podaj 
//    pierwszą liczbę: ...Podaj 
//    drugą liczbę:...
//    Podaj numer operacji do wykonania:
//    1.Dodawanie
//    2.Odejmowanie
//    3.Mnożenie
//    4.Dzielenie...
    
//    Twój wynik to:

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

switch (operationType)
{
    case 1:
        result = number1 + number2;
        Console.WriteLine($"Twój wynik to: {result}");
        break;
    case 2:
        result = number1 - number2;
        Console.WriteLine($"Twój wynik to: {result}");
        break;
    case 3:
        result = number1 * number2;
        Console.WriteLine($"Twój wynik to: {result}");
        break;
    case 4:
        if (number2 == 0)
        {
            Console.WriteLine("Nie można dzielić przez 0!");
            break;
        }
        result = (double)number1 / number2;
        Console.WriteLine($"Twój wynik to: {result}");
        break;
    default:
        Console.WriteLine("Nie ma takiej operacji");
        break;
}