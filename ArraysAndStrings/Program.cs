﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace arraysandstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;

            int[] myNewArray = new int[10];

            myArray = new int[5];
            myArray[0] = 234;
            myArray[1] = 5;
            myArray[2] = 6;
            Console.WriteLine(myArray[0]);

            // multidimensional array (matriz)
            // declaring a 2Darray
            int[,] a2DArray = new int[2,2];

            // declare a 2d array and initializing
            int[,] my2DArray = new int[2,2] {{1,2},{3,4}};

            // access with indexes
            Console.WriteLine("my2DArray[0,1] is " + my2DArray[0,1]);

            // 3D array
            int[,,] my3DArray = new int[2,2,3] {{{1,2,3},{4,5,6}},{{7,8,9},{10,11,12}}};
            Console.WriteLine("my3DArray[1,0,2] is " + my3DArray[1,0,2]);

            char[] myCharArray = new char[5];
            myCharArray[0] = 'h';
            myCharArray[1] = 'e';
            myCharArray[2] = 'l';
            myCharArray[3] = 'l';
            myCharArray[4] = 'o';

            for(int i = 0; i < 5; i++){
                Console.WriteLine(myCharArray[i]);
            }
            
            string myString = "hello";
            Console.WriteLine("The last letter of Hello is: " + myString[4]);
        }
    }
}
