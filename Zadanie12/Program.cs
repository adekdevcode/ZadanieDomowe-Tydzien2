//12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwęDane 
    
//    testowe: 4
    
//    Rezultat w terminalu:
//    Czwartek

int dayNo = 4;

switch (dayNo)
{
    case 1:
        Console.WriteLine("Poniedziałek");
        break;
    case 2:
        Console.WriteLine("Wtorek");
        break;
    case 3:
        Console.WriteLine("Środa");
        break;
    case 4:
        Console.WriteLine("Czwartek");
        break;
    case 5:
        Console.WriteLine("Piątek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Niedziela");
        break;
    default:
        Console.WriteLine("Nie występuje taki dzień w tygodniu!");
        break;
}