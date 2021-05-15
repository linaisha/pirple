using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PrimitiveTypes
{
    public class Animal
    {
        public static void Main(string[] args){
            string animal = "Cachorro";
            int numeroDePatas = 4;
            float pesoEmKg = 10.25f;
            string corDoPelo = "marrom";
            double alturaEmM = 0.30;
            bool sexoF = false;

            Console.WriteLine(animal);
            Console.WriteLine(numeroDePatas);
            Console.WriteLine(pesoEmKg);
            Console.WriteLine(corDoPelo);
            Console.WriteLine(alturaEmM);
            Console.WriteLine(sexoF);

        }
    }
}