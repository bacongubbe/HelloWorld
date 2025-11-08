

namespace HelloWorldApp.model;

public class Animal
{
    public required string Name { get; set; }
    public required int Age { get; set; }
    public virtual void MakeSound()
    {
       Console.WriteLine("I makea de noices no?");
    }

}