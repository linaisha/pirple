// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// namespace Operators
// {
//     public class Learning
//     {
//         public static void Main(string[] args){
//             // O que são 'Operators'?
//             // são caracteres que permitem certas ações ou que algumas operações tomem lugar

//             // Equals
//             int myInt = 10;

//             // comparação de valores ==
//             if(myInt == 10){
//                 Console.WriteLine("I'm 10");
//             }

//             // not equals !=
//             if(myInt != 8){
//                 Console.WriteLine("I'm not 8");
//             }

//             // +
//             myInt = myInt + 2;
//             Console.WriteLine(myInt);
//             // -
//             myInt = myInt - 2;
//             Console.WriteLine(myInt);
//             // *
//             myInt = myInt * 2;
//             Console.WriteLine(myInt);
//             // /
//             myInt = myInt / 2;
//             Console.WriteLine(myInt);

//             // pre incrementação ++ --
//             int i = 0;
//             Console.WriteLine(++i); // deve printar 1

//             // pós incrementação
//             Console.WriteLine(i++); // ainda deve printar 1
//             Console.WriteLine(i); // deve printar 2

//             // > <
//             int A = 10;
//             int B = 15;
//             if(A > B){
//                 Console.WriteLine("A is bigger");
//             }else{
//                 Console.WriteLine("B is bigger");
//             }

//             // >= <=
//             B = 5;
//             if(A >= B){
//                 Console.WriteLine("A is bigger");
//             }else{
//                 Console.WriteLine("B is bigger");
//             }

//             // +=, -=, *=, /=
//             int C = 10;
//             C += 2;
//             C -= 2;
//             C *= 2;
//             C /= 2;

//             // modulo %
//             int D = 21;
//             int E = D % 2;
//             Console.WriteLine(E);

//             // ?:
//             int NewInt = 0;
//             NewInt = (E > 3) ? NewInt = 5 : NewInt = 2;
//             Console.WriteLine(NewInt);

//             // O que são operadores lógicos?
//             // eles permitem que as logicas de operação tomem lugar. são esses: AND, OR e NOT
//             // &&, ||, !

//             bool boolA = true;
//             bool boolB = false;

//             // &&
//             if( boolA && !boolB ){ //if boolA is true AND boolB is false
//                 Console.WriteLine("YAY!");
//             }else{
//                 Console.WriteLine("OH NO!");
//             }

//             // ||
//             if( boolA || !boolB ){ //if boolA is true AND boolB is false
//                 Console.WriteLine("YAY!");
//             }else{
//                 Console.WriteLine("OH NO!");
//             }

//             // !
//             if( boolA && !boolB ){ //if boolA is true AND boolB is false
//                 Console.WriteLine("YAY!");
//             }else{
//                 Console.WriteLine("OH NO!");
//             }

//             // HOW to make comments //
//         }
//     }
// }