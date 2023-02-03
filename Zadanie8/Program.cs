//8.Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:
    
//    Wynik z Matury z matematyki powyżej 70
//    Wynik z fizyki powyżej 55
//    Wynik z chemii powyżej 45
//    Łączny wynik z 3 przedmiotów powyżej 180
//    Albo
//    Wynik z matematyki i jednego przedmiotu powyżej 150

//    Dane testowe:
//    Matematyka 80
//    Fizyka 71
//    Chemia 0

//    Rezultat w terminalu:
//    Kandydat dopuszczony do rekrutacji

int mathsPoints = 80;
int physicsPoints = 71;
int chemistryPoints = 0;

int sumOfAllPoints = mathsPoints + physicsPoints + chemistryPoints;
int sumMathsWithPhysics = sumOfAllPoints - chemistryPoints;
int sumMathsWithChemistry = sumOfAllPoints - physicsPoints;

if (((mathsPoints > 70 && physicsPoints > 55 && chemistryPoints > 45) && sumOfAllPoints > 180) || 
    (sumMathsWithPhysics > 150 || sumMathsWithChemistry > 150))
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
} else
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
}