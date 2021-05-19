﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Pyramids1.Array_Variations
{
   public  class MulDI_array1
    {
        public static void Display_Array()
        {
            // Two Dimensional Array

            int[,] array2D = new int[3, 2] { { 4, 5 }, { 5, 0 }, { 3, 1 } };

            // Three Dimensional Array

            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine("---Two Dimensional Array Elements---");

            for (int i = 0; i < 3; i++)

            {

                for (int j = 0; j < 2; j++)

                {

                    Console.WriteLine("a[{0},{1}] = {2}", i, j, array2D[i, j]);

                }

            }

            Console.WriteLine("---Three Dimensional Array Elements---");

            for (int i = 0; i < 2; i++)

            {

                for (int j = 0; j < 2; j++)

                {

                    for (int k = 0; k < 3; k++)

                    {

                        Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, k, array3D[i, j, k]);

                    }

                }

            }

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();


        }
    }
}
