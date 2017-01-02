using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HoHoHo
{
    class Program
    {
      static void Main()
        {
            Random random_row = new Random();
            int color, i = 0;
            int height = random_row.Next(6, 22); 
            
            int h = height - 2;
            //getting all console colors in one array
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            int colorNumber = colors.Length;
            
            //the "cherry on top"
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*".PadLeft(h + 1));
            
            //generating christmas tree
            while (i <= h)
            {
                color = random_row.Next(0, colorNumber);
                Console.ForegroundColor = colors[color];
                Console.WriteLine(new string('^', i++ * 2 + 1).PadLeft(h + i));
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('|', 3).PadLeft(h+2));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Please turn up the speakers for the full ride!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Merry Christmas and Happy New Year!");
                
            int time = 280; //you can adjust the song speed by changing the variable time
            for (i=0; i<15; i++)
                  christmas_song(time); 
        }

        static void christmas_song(int time)
        {
            //I looked up beep tones for the Merry Christmas song to light up your day
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
