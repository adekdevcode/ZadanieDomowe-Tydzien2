int year = 1998;

if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
{
    Console.WriteLine($"{year} jest rokiem przestępnym");
}
else
{
    Console.WriteLine($"{year} NIE jest rokiem przestępnym");
}