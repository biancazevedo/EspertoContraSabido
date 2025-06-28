
//Esperto contra sabido 
Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine("--- Esperto Contra Sabido ---");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine();
Console.Write("Quanto de comida vocês vão dividir? ");
int tudo = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

if (tudo <= 0) return;

Console.WriteLine();

int resto = tudo;
int picapau = 0, Raposa = 0;

int PraVoce = 0, PraMim = 0;
while (resto > 0)
{
    PraVoce++;
    picapau += 1;
    resto -= 1;
    Console.Write($"{picapau} para você. ");
    PraMim
 = 0;
    while (resto > 0 & PraMim
 < PraVoce)
    {
        PraMim
    ++;
        Raposa += 1;
        resto -= 1;

        Console.Write($"{PraMim
    }");
        if (resto > 0 && PraMim
     < PraVoce)
        {
            Console.Write(",");
        }
        Console.Write(" ");
    }
    if (PraMim
 > 0)
    {
        Console.WriteLine("para mim.");
    }
}
if (PraMim == 0)
{
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Pica-pau recebeu {picapau} alimento(s).");
Console.WriteLine($"Raposa recebeu {Raposa} alimento(s).");