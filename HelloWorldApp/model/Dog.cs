namespace HelloWorldApp.model;

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("woff");
    }

    public void PissOnPole()
    {
      
        Console.WriteLine($"{this.Name} is pissin on a pole");
    }
    
}