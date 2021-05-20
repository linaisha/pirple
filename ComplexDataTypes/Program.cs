using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace complexdatatypes
{

    // enum
    // value type
    // used to declare a list of constant ints

    // example
    // days of the week
    enum Day{
        Monday,
        Tuesday,
        // ...
    }

    enum Direction{
        Left = 100,               // Left, as first item will be assigned to 0
        Up,                 // Left = 1, up = 2, right = 100, down = 123
        Right,              // Left = 1, the rest will just follow the number... up would be 2...
        Down
    }

    class Program
    {
        static void Main(string[] args)
        {
            Direction dir = new Direction();
            dir = Direction.Down;

            if(dir == Direction.Left){
                Console.WriteLine("Go left");
            }else if(dir == Direction.Up){
                Console.WriteLine("Go up");
            }else if(dir == Direction.Right){
                Console.WriteLine("Go right");
            }else if(dir == Direction.Down){
                Console.WriteLine("Go down");
            }
        }
    }
}
