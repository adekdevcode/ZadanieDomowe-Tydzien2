int a = 40;
int b = 55;
int c = 65;

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Można zbudować trójkąt");
} else
{
    Console.WriteLine("Nie można zbudować trójkąta");
}