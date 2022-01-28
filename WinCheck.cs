using System;
using System.Collections.Generic;
using System.Text;

namespace Hons_Project_Console_testin
{
    /// <summary>
    /// check if a win condition is met by a board state upon generation and print out if it is a win
    /// </summary>
    class WinCheck
    {
        
        public static bool Win(int[] arr)
        {

            if (arr[0] == 1)
            { if ((arr[0] == arr[1] && arr[1] == arr[2]) || (arr[0] == arr[3] && arr[3] == arr[6]) || (arr[0] == arr[4] && arr[4] == arr[8])) { /*Console.WriteLine("A team Wins!");*/ return true; } }

            if (arr[4] == 1)
            { if ((arr[2] == arr[4] && arr[4] == arr[6]) || (arr[1] == arr[4] && arr[4] == arr[7]) || (arr[3] == arr[4] && arr[4] == arr[5])) { /*Console.WriteLine("A team Wins!");*/ return true; } }

            if (arr[8] == 1)
            { if ((arr[6] == arr[7] && arr[7] == arr[8]) || (arr[2] == arr[5] && arr[5] == arr[8])) { /*Console.WriteLine("A team Wins!");*/ return true; } }

            if (arr[0] == 2)
            { if ((arr[0] == arr[1] && arr[1] == arr[2]) || (arr[0] == arr[3] && arr[3] == arr[6]) || (arr[0] == arr[4] && arr[4] == arr[8])) { /*Console.WriteLine("B team Wins!");*/ return true; } }

            if (arr[4] == 2)
            { if ((arr[2] == arr[4] && arr[4] == arr[6]) || (arr[1] == arr[4] && arr[4] == arr[7]) || (arr[3] == arr[4] && arr[4] == arr[5])) { /*Console.WriteLine("B team Wins!");*/ return true; } }

            if (arr[8] == 2)
            { if ((arr[6] == arr[7] && arr[7] == arr[8]) || (arr[2] == arr[5] && arr[5] == arr[8])) { /*Console.WriteLine("B team Wins!");*/ return true; } }

            return false;
        }

    }
}
