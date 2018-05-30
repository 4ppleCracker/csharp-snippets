//We need to include System because that's where the Console class lays
using System;

//In C#, functions, methods, etc needs to be associated to a class, in this case we name the class  "Program"
class Program {

    //Here we make a method called Main,
    //it has the accessability modifier "public" which means that it can be called outside of the Program class.
    //it also has the modifier "static", meaning we call the method using the class/type, NOT an object or an instance of the class.
    
    //the return type always comes after the modifiers and before the method name,
    //in this case it's "void" which stands for nothing, it has no return type.
    public static void Main() {
        //WriteLine is a static method in the Console class that takes a string, we call it with the string "Hello World" below
        //this then prints "Hello World" to the console or terminal.
        Console.WriteLine("Hello World");
        
        //ReadKey is also a method in Console, taking no parameters.
        //It waits for the user to press a key, and then returns the pressed key.
        //We use this to make sure the program doesn't close as soon as it's opened, 
        //since we don't want to know what key was pressed,
        //we just call it without assigning it to a variable.
        Console.ReadKey();
    }
}
