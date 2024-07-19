using System;

class Program
{
    static void heart_shape_Print()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (
                    (i == 0 && j % 3 != 0) ||
                    (i == 1 && j % 3 == 0) ||
                    (i - j == 2) ||
                    (i + j == 8)
                )
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        heart_shape_Print();
    }
}

/* Test Case: 

#          * *   * *   
#        *     *     * 
#        *           * 
#          *       *   
#            *   *     
#              *       
*/
