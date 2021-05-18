// What is the difference between a class and a structure?
// Structures: objects are small, cannot be change, has one single value, they cannot be inheriting.
// Classes: are used in every case that a struct can become a problem, they are much more commum in aplicattions. It's the blueprint.
// Example:

// class declaration
public class Conceptspasta{
    // data members of class
    public string name_;
    public int size_;
    public int scare_;

    // method of class
    public void print(){
        Console.WriteLine(name_);
        Console.WriteLine(size_);
        Console.WriteLine(scare_);
    }

    // main method
    public static void Main(string[] args){
        Monster Mike = new Monster("Mike", 10, 15);
            Console.WriteLine(Mike.name_);
            Mike.print();

            Monster Jack = new Monster();
            Jack.print();
    }
}

// defining structure
public struct Monster{
    public string name_;
    public int size_;
    public int scare_;
}

// When would you want to use one versus the other?
// use structures when things are small, that they dont need to be inheriting. Use classes mostly of the times (when you dont use structures)