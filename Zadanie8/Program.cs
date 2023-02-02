int mathsPoints = 80;
int physicsPoints = 71;
int chemistryPoints = 0;

int sumOfAllPoints = mathsPoints + physicsPoints + chemistryPoints;
int sumMathsWithPhysics = sumOfAllPoints - chemistryPoints;
int sumMathsWithChemistry = sumOfAllPoints - physicsPoints;

if (sumOfAllPoints > 180 || (sumMathsWithPhysics > 150 || sumMathsWithChemistry > 150))
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
} else
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
}