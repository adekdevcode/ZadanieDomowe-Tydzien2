//5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko
//    posła, 
//    premiera, 
//    sentarora, 
//    prezydenta.
    
//    Dane testowe : 21
//    Rezultat w terminalu:
//    Możesz zostać posłem

const int REQUIRE_AGE_OF_PRESITENT = 35;
const int REQUIRE_AGE_MEMBER_OF_SENATE = 30;
const int REQUIRE_AGE_MEMBER_OF_PARLAMENT = 21;

int age = 31;
string positions = "";

if (age >= REQUIRE_AGE_OF_PRESITENT)
{
    positions += "prezydentem ";
}

if (age >= REQUIRE_AGE_MEMBER_OF_SENATE)
{
    positions += "senatorem ";
}

if (age >= REQUIRE_AGE_MEMBER_OF_PARLAMENT)
{
    positions += "politykiem lub premierem";
}

if (!string.IsNullOrEmpty(positions))
{
    Console.WriteLine($"Możesz zostać {positions}");
} else
{
    Console.WriteLine("Nie możesz jeszcze zostać politykiem");
}

