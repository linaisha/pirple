using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Conceptspasta
{

    // structures
    // similar to classes in the sense that they can have public and private
    // data members and functions

    // classes support inheritance and polymorphism and structs don't
    // classes are a reference type and structures are a calue type
    // data member in classes by default are private where as in structs they are public

    // reference types hold a reference to the object in memory

    // value types hold their value in memory in the location where they were declared

    public struct Monster{
        public string name_;
        public int scare_;
        public int size_;

        // can also hold structors
        public Monster(string name, int scare, int size){
            name_ = name;
            scare_ = scare;
            size_ = size;
        }

        public void print(){
            Console.WriteLine(name_);
            Console.WriteLine(size_);
            Console.WriteLine(scare_);
        }
    }

        public class Structures
    {
        public static void Main(string[] args){
            Monster Mike = new Monster("Mike", 10, 15);
            Console.WriteLine(Mike.name_);
            Mike.print();

            Monster Jack = new Monster();
            Jack.print();
        }
    }
}