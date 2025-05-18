string resposta;
Console.WriteLine("Está se movendo? ");
resposta = Console.ReadLine()!.ToUpper();
if (resposta == "SIM")
{
    Console.WriteLine("Deveria: ");
    resposta = Console.ReadLine()!.ToUpper();

    if (resposta == "SIM")

    {
        Console.WriteLine("otimo");
    }
    else
    {
        Console.WriteLine("Silver Tape");
    }

}

else
{
    Console.WriteLine("Deveria ? ");
    resposta = Console.ReadLine()!.ToUpper();
    if (resposta == "SIM")
    {
        Console.WriteLine("WD-40");
    }
    else
    {
        Console.WriteLine("otimo");
    }
    
}