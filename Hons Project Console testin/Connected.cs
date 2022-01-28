using System;
using System.Collections.Generic;
using System.Text;

namespace Hons_Project_Console_testin
{
    class Connected
    {

        /// <summary>
        /// checks if there is only one cell different between arrays, and if one of them has one more entry than the other, if so they are connected
        /// used for making the graph of the game
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static bool connect(int[] arr1, int[] arr2)
        {
            int count = 0;
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < 9; i++)
            {
                if (arr1[i] != arr2[i]) { count++; }
                if (arr1[i] != 0) { num1++; }
                if (arr2[i] != 0) { num2++; }
            }
            if (count == 1 && Math.Abs(num1 - num2) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
