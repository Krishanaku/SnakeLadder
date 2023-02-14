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
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            int position = 0;
            int numberOfTimesDiceRolled = 0;

            Console.WriteLine("Welcome Player 1, Let's start the Game");
            Console.WriteLine("Player 1 is at position : " + position);

            Random random = new Random();

            while (position < 100)
            {
                int temp = position;

                int dice = random.Next(1, 7);
                numberOfTimesDiceRolled++;

                Console.WriteLine($"The Player rolls a dice and gets: {dice}");
                Console.WriteLine($"Number of Times Dice rolled is: {numberOfTimesDiceRolled}");

                int option = random.Next(0, 3);

                if (option == 0)
                {
                    Console.WriteLine("Player stays at same Position");
                }
                else if (option == 1)
                {
                    Console.WriteLine("Player Moves Ahead by {0} from ladder", dice);
                    position += dice;
                }
                else
                {
                    Console.WriteLine("Player Moves Behind by {0} from Snake", dice);
                    position -= dice;
                }

                if (position < 0)
                {
                    position = 0;
                }
                else if (position > 100)
                {
                    position = temp;
                }
                Console.WriteLine("Player Current Position is at : {0}", position);

            }
            Console.WriteLine("Player is at Position : {0}", position);
            Console.WriteLine($"Total Number of Times Dice rolled is: {numberOfTimesDiceRolled}");

        }
    }
    }

