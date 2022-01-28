using System;
using System.Collections.Generic;
using System.Text;

namespace Hons_Project_Console_testin
{
    /// <summary>
    /// check if win conditions are met, and how many of them
    /// </summary>
    class WinValid
    {
        public static int WinVal(int[] arr)
        {
            int count = 0;

            if (arr[0] == 1) { if (arr[0] == arr[1] && arr[1] == arr[2]) { count++; } }
            if (arr[0] == 1) { if (arr[0] == arr[3] && arr[3] == arr[6]) { count++; } }
            if (arr[0] == 1) { if (arr[0] == arr[4] && arr[4] == arr[8]) { count++; } }

            if (arr[4] == 1) { if (arr[2] == arr[4] && arr[4] == arr[6]) { count++; } }
            if (arr[4] == 1) { if (arr[1] == arr[4] && arr[4] == arr[7]) { count++; } }
            if (arr[4] == 1) { if (arr[3] == arr[4] && arr[4] == arr[5]) { count++; } }

            if (arr[8] == 1) { if (arr[6] == arr[7] && arr[7] == arr[8]) { count++; } }
            if (arr[8] == 1) { if (arr[2] == arr[5] && arr[5] == arr[8]) { count++; } }

            if (arr[0] == 2) { if (arr[0] == arr[1] && arr[1] == arr[2]) { count++; } }
            if (arr[0] == 2) { if (arr[0] == arr[3] && arr[3] == arr[6]) { count++; } }
            if (arr[0] == 2) { if (arr[0] == arr[4] && arr[4] == arr[8]) { count++; } }

            if (arr[4] == 2) { if (arr[2] == arr[4] && arr[4] == arr[6]) { count++; } }
            if (arr[4] == 2) { if (arr[1] == arr[4] && arr[4] == arr[7]) { count++; } }
            if (arr[4] == 2) { if (arr[3] == arr[4] && arr[4] == arr[5]) { count++; } }

            if (arr[8] == 2) { if (arr[6] == arr[7] && arr[7] == arr[8]) { count++; } }
            if (arr[8] == 2) { if (arr[2] == arr[5] && arr[5] == arr[8]) { count++; } }

            return count;
        }
    }
}
