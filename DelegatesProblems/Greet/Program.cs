class Greet{

    public static void Main(string[] args){

        Greet greet = new Greet();
        greet.GreetUser("Alice"); // Call the GreetUser method directly
        GreetDelegate greetDelegate = new GreetDelegate(greet.GreetUser); // Create a delegate instance
        Console.WriteLine("Calling delegate:" + greetDelegate("Bob"));
         // Invoke the delegate
    }

    public string GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
        return $"Hello, {name}!";
    }

    delegate string GreetDelegate(string name);

    
}