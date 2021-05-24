using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace controlflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // random class
            // allows us to regerate ransom numbers
            Random randInt = new Random();

            // initiate it
            // use next keyboard
            // 3 possible uses

            // default
            int test = randInt.Next();
            // generates a non-negative 32bit integer

            int test2 = randInt.Next(55);
            // generates a non-negative 32bit from 0 - 55

            int test3 = randInt.Next(-100,100);
            // generates number from -100 to 100... x-y

            Console.WriteLine("Test 1: " + test + ", Test 2: " + test2 + ", Test 3: " + test3);

            int q = 10;
            int c = 11;

            // if statements
            // check for a condition and does something according to the thing

            if(test2 == 10){
                Console.WriteLine("I'm 10"); // do this
            }else if(test2 == 11){ // else check for this condition
                Console.WriteLine("I'm 11");
            }else if(test2 == 0){ // we can have multiple else if
                int Sum = c + q;
            }else // if the condition is not true
            {
                Console.WriteLine("I'm not 10");
            }

            // switch statemts
            //used to replace multiple else ifs-

            switch(c){
                case 10:
                    Console.WriteLine("I'm 10");
                    break;
                case 11:
                    Console.WriteLine("I'm 11");
                    break;
                case 12:
                    Console.WriteLine("I'm 12");
                    break;
                default:
                    Console.WriteLine("I'm not 10");
                    break;
            }

            // for loops
            // AVOID infinite loops
            int x = 0;

            for(int i = 0; i < 10; i++){
                x += i;
                Console.WriteLine(i);
                Console.WriteLine("The sum is: " + x);
                if(i == 7){
                    Console.WriteLine("You are a winner!");
                }
            }

            // while loops
            bool go = true;
            int check = 0;

            while(!go){
                Console.WriteLine("continue");

                if(check == 13){
                    go = false;
                }
                check++;
            }

            do{
                Console.WriteLine("OKAY");
                check--;
                if(check == 0){
                    go = true;
                }
            }while(!go);
        }
    }
}
