namespace Population
{
    
    public class Person
{
    public string Name;
    public int Age;
    public bool HasPet;
    
    public Person(string name, int age,  bool hasPet)
        {
            Name = name;
            Age = age;
            HasPet = hasPet;
        }
    //defining a method

    public void Greetings(){
        Console.WriteLine("Hello, my name is " + Name + ", I am " + Age + " years old.");
    }    
}

}