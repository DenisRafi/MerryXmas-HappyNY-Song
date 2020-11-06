using System;

namespace ByDenisRafi
{
    class Program
    {
        static void Main()
        {
            Console.Title = ("C# Console App | Merry Xmas & Happy NY + Song | Turn On the 🔈");
            Random random_row = new Random();
            int color, i = 0;
            int height = random_row.Next(6, 25);
            int h = height - 2;
            
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            int colorNumber = colors.Length;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*".PadLeft(h + 1));
          
            while (i <= h)
            {
                color = random_row.Next(0, colorNumber);
                Console.ForegroundColor = colors[color];
                Console.WriteLine(new string('^', i++ * 2 + 1).PadLeft(h + i));
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('|', 3).PadLeft(h + 2));          
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" *Merry Xmas & Happy NY!* | *ByDenisRafi!*");

            int time = 280; 
            for (i = 0; i < 15; i++)
                song(time);
        }
        static void song(int time)
        {
            
            for (int i = 0; i < 6; i++)
                Console.Beep(659, time);

            Console.Beep(783, time);
            Console.Beep(523, time);
            Console.Beep(587, time);
            Console.Beep(659, time);

            Console.Beep(261, time);
            Console.Beep(293, time);

            for (int i = 0; i <= 4; i++)
                Console.Beep(698, time);

            for (int i = 0; i < 4; i++)
                Console.Beep(659, time);

            Console.Beep(587, time);
            Console.Beep(587, time);
            Console.Beep(659, time);
            Console.Beep(587, time);

            Console.Beep(783, time);
        }
    }
}