using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ComplexDataTypes
{
    public class Exercise
    {
        public static void Main(string[] args){
            string[] animals = new string[5];
            int[] numberOfPaws = new int[5];
            float[] weightInKg = new float[5];
            string[] colorOfFur = new string[5];
            double[] heightInM = new double[5];
            bool[] sexF = new bool[5];

        animals[0] = "dog";
        animals[1] = "horse";
        animals[2] = "cat";
        animals[3] = "human";
        animals[4] = "dinossaur";

        numberOfPaws[0] = 4;
        numberOfPaws[1] = 4;
        numberOfPaws[2] = 4;
        numberOfPaws[3] = 2;
        numberOfPaws[4] = 2;

        weightInKg[0] = 5f;
        weightInKg[1] = 100f;
        weightInKg[2] = 2.5f;
        weightInKg[3] = 80f;
        weightInKg[4] = 300.25f;

        colorOfFur[0] = "brown";
        colorOfFur[1] = "black";
        colorOfFur[2] = "white";
        colorOfFur[3] = "no fur";
        colorOfFur[4] = "no fur";

        heightInM[0] = 0.3;
        heightInM[1] = 2;
        heightInM[2] = 0.85;
        heightInM[3] = 1.53;
        heightInM[4] = 6;

        sexF[0] = true;
        sexF[1] = false;
        sexF[2] = true;
        sexF[3] = true;
        sexF[4] = false;

            for(int i = 0; i < 5; i++){
                Console.WriteLine("Name: " + animals[i]);
                Console.WriteLine("Number of paws: " + numberOfPaws[i]);
                Console.WriteLine("Weight in kg: " + weightInKg[i]);
                Console.WriteLine("Color of fur: " + colorOfFur[i]);
                Console.WriteLine("Height in meters: " + heightInM[i]);
                Console.WriteLine("It is a female? " + sexF[i]);
                Console.WriteLine("\n\n");
            }

        }
    }
}