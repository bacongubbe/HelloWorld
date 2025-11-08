// See https://aka.ms/new-console-template for more information


using HelloWorldApp.model;

namespace HelloWorldApp;

class Program
{
    static void Main(String[] args)
    {

        Animal dogge = new Dog() { Name = "doggeh", Age = 32};
        Cat cat = new Cat() { Name = "Felix the pussycat" , Age = 44};
        dogge.MakeSound();
        cat.GiveItem("glass");
       
    }

    private static void LoopArgs(String[] args)
    {
        String[] input = args;
        
        for (int i = 0; i < args.Length; i++) 
        {
            Console.WriteLine(input[i]);
        }
    }
    
    private static void LoopArgsBackward(String[] args)
    {
        String[] input = args;
        for (int i = args.Length - 1; i < 0; i--) 
        {
            Console.WriteLine(input[i]);
        }
    }

    private static void BeNiceOnEvenAndRudeOnOddExceptSeven(String[] args)
    {
        var input = args[0];

        if (args.Length % 2 == 0)
        {
            Console.WriteLine($"You're so cute I cannot even <3, {input}");
        }
        else if (args.Length == 7)
        {
            Console.WriteLine($"you're not only gorgeous, you're also lucky!, {input}");
        }
        else
        {
            Console.WriteLine($"No, I would not date you, {input}");
        }
    }
}
