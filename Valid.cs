using System;
using System.Collections.Generic;
using System.Text;

namespace Hons_Project_Console_testin
{
    /// <summary>
    /// check to ensure that only valid board states are used in the firs place
    /// like ensuring that the board states with a difference of more than one between the number of moves is not allowed
    /// </summary>
    class Valid
    {
        public static bool check(int[] arr)
        {
            int twoCount = 0;
            int oneCount = 0;

            foreach (int x in arr)
            {
                if (x == 1) { oneCount++; }
                if (x == 2) { twoCount++; }

            }

            if (twoCount - oneCount > 1) { return false; }
            if (oneCount - twoCount > 0) { return false; }


            if (WinValid.WinVal(arr) > 1) { return false; }




            else { return true; }
        }

    }
}
