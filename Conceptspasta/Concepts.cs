// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// namespace concepts
// {
//     // o que são classes?
//     // planta pra criar um objeto
//     //elas permitem que o usuario crie seu proprio tipo de objetos
//     public class Monster{
//         //  o que uma classe pode ter
//         // membro de dados - constantes/variaveis
//         // metodos/funções

//         // public - pode ser acessado em qualquer lugar no projeto
//         // public dados de membros/metodos - pode ser acessado qualquer lugar da classe
//         // was instantiated
//         public string name_;
//         public int size_;
//         public const int legs_ = 2;

//         // private dados de membros/metodos - pode APENAS ser acessado da classe
//         private int scare_;

//         // static dados de membros/metodos - aplicado para a classe inteira do q a instancia nela
//         public static int nMonsters_;

//         // default constructor -initiated all values
//         public Monster(){
//             name_ = "default";
//             size_ = 20;
//             scare_ = 10;
//             nMonsters_++; // aumenta numero de monstros
//         }

//         // constructors
//         public Monster(string name, int size, int scare){
//             name_ = name;
//             size_ = size;
//             scare_ = scare;
//             nMonsters_++;
//         }

//         // methods
//         public void print(){
//             Console.WriteLine("Monsters name: " + name_);
//             Console.WriteLine("Monsters size: " + size_);
//             Console.WriteLine("Mosnters scare: " + scare_);
//         }
//     }
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             Monster Dinosour = new Monster();
//             // public members
//             Console.WriteLine(Dinosour.name_);
//             // can be changed
//             Dinosour.name_ = "Rex";
//             Console.WriteLine(Dinosour.name_);

//             // change a const cannot be changed
//             // example Dinosour.legs_ = 3;

//             // private members cannot be accessed here
//             // example -- Console.WriteLine(Dinosour.scare_);

//             // using non-default-constructor
//             Console.WriteLine(Monster.nMonsters_);
//             Monster Dragon = new Monster("Drako", 30, 25);
//             Console.WriteLine(Dragon.name_);

//             // static check
//             Console.WriteLine(Monster.nMonsters_);

//             Monster Zombie = new Monster("Zombie", 6, 8);
//             // call print
//             Zombie.print();
//             Dragon.print();
//             Dinosour.print();

//             Console.WriteLine(Monster.nMonsters_);
//         }
//     }
// }
