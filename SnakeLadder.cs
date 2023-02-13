using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeLadder
    {
        public static void SnakeladderGame()
        {
            Console.WriteLine("Roll Dice to find 1 To 6 number");
            Random random = new Random();
            int player = random.Next(1, 7);
            Console.WriteLine("Player Roll the Dice : " + player);

        }
        }
    }

