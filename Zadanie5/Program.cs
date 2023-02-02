const int REQUIRE_AGE_OF_PRESITENT = 35;
const int REQUIRE_AGE_MEMBER_OF_SENATE = 30;
const int REQUIRE_AGE_MEMBER_OF_PARLAMENT = 21;

int age = 35;

if (age >= REQUIRE_AGE_OF_PRESITENT)
{
    Console.WriteLine("Możesz zostać prezydentem");
} else if (age >= REQUIRE_AGE_MEMBER_OF_SENATE)
{
    Console.WriteLine("senatorem");
} else if (age >= REQUIRE_AGE_MEMBER_OF_PARLAMENT)
{
    Console.WriteLine("Możesz zostać posełem lub premierem");
} else
{
    Console.WriteLine("Nie możesz jeszcze zostać politykiem");
}