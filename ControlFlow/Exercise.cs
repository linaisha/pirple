using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ControlFlow
{
    public class Exercise
    {
        static void Main(string[] args){
            for(int i = 1; i < 101; i++){
                if(i%3 == 0 && i%5 == 0){
                    Console.WriteLine(i + " - FizzBuzz");
                }else if(i%3 == 0){
                    Console.WriteLine(i + " - Fizz");
                }else if(i%5 == 0){
                    Console.WriteLine(i + " - Buzz");
                }else{
                    Console.WriteLine(i);
                }
            }

        }
    }
}