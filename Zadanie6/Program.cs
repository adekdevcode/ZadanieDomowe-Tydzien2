int height = 140;

string result = height switch
{
    > 200 => "olbrzymem",
    > 180 => "wielkoludem",
    > 170 => "średniakiem",
    >= 150 => "maluchem",
    < 150 => "krasnoludem",
};

Console.WriteLine($"Jesteś {result}");