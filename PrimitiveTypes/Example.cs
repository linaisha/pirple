// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// namespace PrimitiveTypes{
//     public class Program{
//         public static void Main(string[] args){
//             // variaveis são declaradas uma vez e podem ser mudadas depois

//             int myInt = 1;
//             int my_Int = 2;
//             int myInt1 = 3;

//             // constantes são declaradas uma vez e não podem ser mudadas depois
//             const int A_CONST_INT = 100;

//             // integer
//             // Ints são por padrão 32 bits
//             int anInt = 1;
//             const int THE_CONST_INT = 2;

//             // float
//             // floats são por padrão 32 bits
//             float aFloat = 2.5634523f;
//             const float MY_FLOAT = 2.1425f;

//             // double
//             // 64 bits decimais
//             double aDouble = 2.234234;
//             const double MY_DOUBLE = 12.345654;

//             // char
//             // letra a simbolo
//             char myChar = 'a';
//             const char MY_CONST_CHAR = '-';

//             // boolean
//             // valores sim/nao, positivo/negativo
//             bool myBool = true;
//             const bool MY_CONST_BOOL = false;

//             byte myByte = 120;
//             const byte MY_CONST_BYTE = 255;

//             short myShort = 32000;
//             const short MY_CONST_SHORT = -32000;

//             long myLong = 323232323232;
//             const long MY_CONST_LONG = -3232323212;

//             uint myUint = 11232;
//             ushort myUshort = 12232;
//             ulong myUlong = 1232323;

//             sbyte mySbyte = -120;

//             // overflowing quando vc tenta atribuir um tipo muito grande para um container
//             // exemplo sbyte mybyte_ = 129;

//             // scopo é onde vc pode acessar valores dele
//             int testInt = 10;

//             if(testInt == 10) // checando se o testInt é igual a 10
//             {
//                 Console.WriteLine(myInt);
//                 Console.WriteLine("I'm 10");
//                 myInt = 25;
//                 Console.WriteLine(myInt);
//                 int newInt = -1;
//                 bool myNewBool = true;
//                 if(myNewBool == true) // if(myNewBool) "for true" if(!myNewBool) "for false"
//                 {
//                     newInt = -10;
//                     Console.WriteLine(newInt);
//                 }
//             }
//             // exemplo de um escopo ruim
//             // newInt = 20;

//             // conversão implicita
//             // não requer sintaxe
//             // não tem perda de dado
//             float floatA = 2.3f;
//             double doubleA = floatA;

//             sbyte sbyteA = 12;
//             int intA = sbyteA;

//             // conversão explicita
//             // possivel perda de dados
//             // requer sintaxe
//             short shortA = (short)intA;

//             double doubleB = 2.44324324;
//             float floatB = (float)doubleB;
//             Console.WriteLine(floatB); // perde 2 unidades decimais

//             // conversões entre tipos não compativeis
//             // ASCII table é usado para isso
//             char charA = 'a';
//             int intB = charA;
//             Console.WriteLine(intB);
//             char charB = (char)intB;
//             Console.WriteLine(charB);

//             // usando convert class
//             string myString = "12000";
//             // myString = myString + 50;
//             Console.WriteLine(myString);

//             int myNewInt = Convert.ToInt32(myString);
//             long myNewLong = Convert.ToInt64(myString);
//             myNewInt = myNewInt + 50;
//             Console.WriteLine(myNewInt);
//         }
//     }
// }