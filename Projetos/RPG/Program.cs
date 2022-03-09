using System;

using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
        Knight Arus  = new Knight("Arus", 42, "Knight", 749, 72);
        WhiteWizard Jenica  = new WhiteWizard("Jenica", 42, "White Wizard", 601, 482);
        Ninja Wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);
        DarkWizard Topapa = new DarkWizard("Topapa", 42, "Dark Wizard", 385, 641);

        Console.WriteLine(Arus.Attack);
        Console.WriteLine(Jenica);
        Console.WriteLine(Wedge);
        Console.WriteLine(Topapa);
        }
    }
}
    


