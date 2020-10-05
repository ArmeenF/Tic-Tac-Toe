using System;
using System.Threading;

namespace Tic_Tac_Toe
{
    class Program
    {
        static char[] arr = {'0','1','2','3','4','5','6','7','8','9' };
        static int player = 1;
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear  
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if(player % 2 == 0)//checking the chance of the player
                {
                    Console.WriteLine("Player 2 chance");
                }
                else
                {
                    Console.WriteLine("Player 1 chance");
                }
                Console.WriteLine("\n");
                //Board();//Calling Board function
                choice = Int32.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else//Error handiling
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}",choice,arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 seconds while the board reloads");
                    Thread.Sleep(2000);
                }
                //flag = CheckWin();//Calling check win
            }
            while (flag != 1 || flag != -1);
            
        }
    }
}
