namespace HelloWorldApp.model;

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Mjauuuw");
    }

    public void GiveItem(string item) => Console.WriteLine($"cat throws {item} on ground ");
    
}