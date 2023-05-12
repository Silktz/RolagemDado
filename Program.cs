//Made by Silktz

int facedado; 
Random prizedraw = new Random (); 

  Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine ("Rolagem de Dado");
Console.ResetColor();

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Digite a quantidade de faces do dado: ");
Console.ResetColor();

facedado = int.Parse(Console.ReadLine()!);

if (facedado < 0)
{
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Digite um número de faces validas: ");
    }
    else 
    {
       DefaultColor();

        int rolls = prizedraw.Next(1, facedado);
        Console.WriteLine("--- Dado rolando... ---");
        Console.WriteLine();

        DefaultColor();

        Console.WriteLine($"Número de faces: {facedado}");
        Console.WriteLine($"Rolagem: {rolls}");
    }

    void DefaultColor()
    {
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
