using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Operators
{
    public class Exercicio
    {
        public static void Main(String[] args){

            bool flavor2 = true; // true = chocolate
            bool flavor1 = false; // false = vanilla

            if(flavor1 || flavor2){ // if the cake is chocolate or vanilla
                Console.WriteLine("The cake's flavor is either vanilla or chocolate");
            }

            if(flavor2 && !flavor1){ // if the cake isn't chocolate
                Console.WriteLine("The cake isn't chocolate then it can only be vanilla");
            }else{
                Console.WriteLine("The cake is chocolate");
            }
            
            bool mortal = true;
            bool imortal = false;
            bool man = mortal;
            bool socrates = man;

            if(socrates = imortal){ // if socrates = imortal then he isn't mortal, if socrates != imortal, then he's mortal
                Console.WriteLine("Socrates is imortal");
            }else{
                Console.WriteLine("Socrates is mortal");
            }
            
        }
        
    }
}