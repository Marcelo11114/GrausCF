using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {

           Double C, F; // VARIAVEIS C=centigrados F=fharenheit
           String T;

          do
           {
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.WriteLine("      +---------------------+");
           Console.WriteLine("      |                     |");
           Console.WriteLine("      +---------------------+");

           Console.SetCursorPosition(8, 1);
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("Graus em Fahrenheit");
           Console.SetCursorPosition(0, 3);
           Console.ResetColor();

           Console.Write("Temperatura em Centigrados :");
           C=Convert.ToDouble(Console.ReadLine());
           F=C*1.8+32;

           Console.WriteLine($"Temperatura em Fahrenheit é {F}°F");

           Console.Write("(S)air?:");           
           T = Console.ReadLine().ToUpper();
           }

           while(T != "S");

           Console.Clear();




        }
    }
}
