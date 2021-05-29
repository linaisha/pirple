// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// namespace arraysandstrings
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] myArray;

//             int[] myNewArray = new int[10];

//             myArray = new int[5];
//             myArray[0] = 234;
//             myArray[1] = 5;
//             myArray[2] = 6;
//             myArray[3] = 8;
//             myArray[4] = 15;
//             Console.WriteLine(myArray[0]);

//             // multidimensional array (matriz)
//             // declaring a 2Darray
//             int[,] a2DArray = new int[2,2];

//             // declare a 2d array and initializing
//             int[,] my2DArray = new int[2,2] {{1,2},{3,4}};

//             // access with indexes
//             Console.WriteLine("my2DArray[0,1] is " + my2DArray[0,1]);

//             // 3D array
//             int[,,] my3DArray = new int[2,2,3] {{{1,2,3},{4,5,6}},{{7,8,9},{10,11,12}}};
//             Console.WriteLine("my3DArray[1,0,2] is " + my3DArray[1,0,2]);

//             // jagged arrays
//             // these are arrays that hold other arrays that can be different sizes
//             int[][] myJagArray = new int[3][];
//             myJagArray[0] = new int[3] {1,2,3};
//             myJagArray[1] = new int[7] {4,5,6,7,8,9,10};
//             myJagArray[2] = new int[1] {11};

//             // accessing a jagged array
//             Console.WriteLine("My Jag Array[1][6] is: " + myJagArray[1][6]);

//             // alternate way of initializing our jagged arrays
//             char[][] myCharJagArray = new char[][]{
//                 new char[]{'h','e','l','l','o'},
//                 new char[]{'c','o','o','l'},
//                 new char[]{'b','y','e'}
//             };

//             Console.WriteLine("My char jag array of [2][1] is: " + myCharJagArray[2][1]);

//             char[] myCharArray = new char[5];
//             myCharArray[0] = 'h';
//             myCharArray[1] = 'e';
//             myCharArray[2] = 'l';
//             myCharArray[3] = 'l';
//             myCharArray[4] = 'o';

//             for(int i = 0; i < 5; i++){
//                 Console.WriteLine(myCharArray[i]);
//             }

//             // lists
//             // used to store multiple values
//             // the difference between a list and an array is that a list has dinamic memory and array has a fixed memory allocation

//             // declaring one
//             List<int> myList = new List<int>();

//             // add items we use Add
//             myList.Add(1);
//             myList.Add(2);
//             myList.Add(3);

//             Console.WriteLine("My first list item is: " + myList[0]);

//             // we can also add an entire array to a list
//             // we use AddRange
//             Console.WriteLine("myList size is: " + myList.Count);
//             myList.AddRange(myArray);
//             Console.WriteLine("myList size is: " + myList.Count);
//             Console.WriteLine("myList's fouth item is: " + myList[3]);
            
//             string myString = "hello";
//             Console.WriteLine("The last letter of Hello is: " + myString[4]);

//             // removing items from the list
//             // remover or removeAt

//             // remove
//             // choosing a specific item in the list
//             List<string> Bosses = new List<string>();
//             Bosses.Add("Dragon");
//             Bosses.Add("Dinosaur");
//             Bosses.Add("Gorrilla");
//             Bosses.Add("Rat");
//             Console.WriteLine("Bosses size is: " + Bosses.Count);

//             Bosses.Remove("Rat");
//             Console.WriteLine("Bosses size is: " + Bosses.Count);

//             // removeAt
//             // removes an item at a location using indexing

//             Bosses.RemoveAt(1);
//             Console.WriteLine("Bosses size is: " + Bosses.Count);

//             // the ability to combine two lists
//             // they must be the same type
//             List<string> Monsters = new List<string>();
//             Monsters.Add("Megalodon");
//             Monsters.Add("Aliens");
//             Monsters.Add("Giant");

//             // use AddRange
//             Console.WriteLine("Monsters size is: " + Monsters.Count);
//             Monsters.AddRange(Bosses);
//             Console.WriteLine("Monsters size is: " + Monsters.Count);

//             for(int i = 0; i < 5; i++ ){
//                 Console.WriteLine(Monsters[i]);
//             }
//         }
//     }
// }
