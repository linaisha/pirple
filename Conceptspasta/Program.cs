// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// namespace Conceptspasta{



// // inheritance
// // class inherits methods and data members from the class above

// // abstract class
// // cannot instantiated
// // can contain abstract methods but its not required
// // can contain non abstract methods

//     public abstract class Character{
//         public string name_;
//         public int speed_;
//         public int health_;
//         public int test_ = 2;

//         public abstract void print(); // MUST BE modified in inheriting classes

//         public int testFunction(){
//             test_ = test_*2;
//             return test_;
//         }

//         // virtual class
//         // can be changed in classes that derive from the base class BUT NOT required
//         public virtual void Swing(){
//             Console.WriteLine("SWING!");
//         }
//     }

//     public class SwordsMan : Character{
//         public SwordsMan(){
//             name_ = "Erik";
//             speed_ = 10;
//             health_ = 100;
//         }

//         // implement abstract class we must use override
//         public override void print()
//         {
//             Console.WriteLine("My name is "+ name_);
//             Console.WriteLine("and I am " + speed_ + " fast");
//             Console.WriteLine("my health is " + health_);
//         }

//         // virtual functions can be overriden as well
//         public override void Swing()
//         {
//             Console.WriteLine("I'm not going to swing!");
//         }
//     }

//         public class Program
//         {
//             public static void Main(String[] args){
//                 SwordsMan Erik = new SwordsMan();
//                 Erik.print();
//                 Erik.testFunction();
//                 Erik.Swing();
//                 Console.WriteLine(Erik.test_);
//             }
//         }
// }