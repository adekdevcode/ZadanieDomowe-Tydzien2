Console.WriteLine("Podaj liczbę, a sprawdzę czy jest dodania czy ujemna: ");
int givenNumber = int.Parse(Console.ReadLine());

if (givenNumber >= 0)
{
    Console.WriteLine($"{givenNumber} jest liczbą dodatnią");
}else
{
    Console.WriteLine($"{givenNumber} jest liczbą ujemną");
}