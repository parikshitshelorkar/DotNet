using System.Security.Cryptography.X509Certificates;
using opt;
class Calculate
{
    public static void Main(string[] args)
    {   
        Operator op = new Operator();
        
        delegate addDelegate=op.Add;

       
        addDelegate(op.Add(5, 5));
        Console.WriteLine("Welcome to the Dotnet Calculator");

    }
}