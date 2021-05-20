// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// namespace ComplexDataTypes.obj
// {
//     public class Arrays
//     {
//         public static void Main(string[] args){
//             // single dimensional array
//             // a reference type that can store multiple values
//             // can be accessed through indexing

//             // declaring it
//             int[] myArray;
            
//             // initiating
//             // as we declare it
//             int[] myNewArray = new int[10]; // 0-9 used to access

//             // indexes start at 0

//             // after declaring
//             myArray = new int[5]; // 0-4
//             myArray[0] = 234;
//             myArray[1] = 5;
//             myArray[2] = 6;
//             // myArray[5] = 9; gonna have an error cause we only have til 4. DO NOT DO
//             Console.WriteLine(myArray[0]);

//             // string, chars, bool... wharever tyoe can be stored in an array
//             char[] myCharArray = new char[5];
//             myCharArray[0] = 'h';
//             myCharArray[1] = 'e';
//             myCharArray[2] = 'l';
//             myCharArray[3] = 'l';
//             myCharArray[4] = 'o';

//             for(int i = 0; i < 5; i++){
//                 Console.WriteLine(myCharArray[i]);
//             }

//             // strings
//             // strings are an array of characters
//             // we can access through indexing but cannot change them
//             string myString = "hello";
//             Console.WriteLine("The last letter of Hello is: " + myString[4]);

//             // BAD example
//             // DO NOT DO: myString[0] = "Y";
//         }
//     }
// }