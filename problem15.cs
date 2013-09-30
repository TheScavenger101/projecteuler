using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int gridSize = 20;
            
            long[,] gridArray = new long[21, 21];
            int count = 0;
            bool Flag = true;
            
            while (Flag == true)
            {
                count = count + 1;
                gridArray[count, gridSize] = 1;
                gridArray[gridSize, count] = 1;
                
                if (count == 20)
                {
                    Flag = false;
                }
            }
            
            for (int i = gridSize - 1; i >= 0; i--)
            {
                for (int j = gridSize - 1; j >= 0; j--)
                {
                    gridArray[i, j] = gridArray[i+1, j] + gridArray[i, j+1];
                }
            }
            Console.WriteLine("There are: " + gridArray[0,0] + " possible ways");
        }
    }
}
