using System;
using Population;
using MyCalc;
using  Cinema;

namespace ClassTut
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Creating an object of the class person
        Person person1 = new Person("Alice", 30, true);
        //declaring values to the properties of the object
            
            person1.Greetings();
            Calculator calc = new Calculator();
            int result = calc.Addition(5, 10, 15, 20);
            Movie mv1= new Movie("Inception", "Christopher Nolan", 2010);
            Console.WriteLine("The sum is: " + result);
            Console.WriteLine("-----Movie Class Demo-----");
            Console.WriteLine
            ("Total Movies Created: " + Movie.Count);}
}

}


