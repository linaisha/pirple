using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester{
    public class Program{
        public static void Main(string[] args){
            // variaveis são declaradas uma vez e podem ser mudadas depois

            int myInt = 1;
            int my_Int = 2;
            int myInt1 = 3;

            // constantes são declaradas uma vez e não podem ser mudadas depois
            const int A_CONST_INT = 100;

            // integer
            // Ints são por padrão 32 bits
            int anInt = 1;
            const int THE_CONST INT = 2;

            // float
            // floats são por padrão 32 bits
            float aFloat = 2.5634523f;
            const float MY_FLOAT = 2.1425f;

            // double
            // 64 bits decimais
            double aDouble = 2.234234;
            const double MY_DOUBLE = 12.345654;

        }
    }
}