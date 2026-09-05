using System.Formats.Asn1;
using HR;

public class HelloWorld
{

// Pass by Refernce
void Swap(ref int a, ref int b)
{
    int temp = a; 
    a = b; 
    b = temp;
}

//out parameter
public static void  Calculate(float r, out float area, out float perimeter)
{
    area = 3.14f * r * r;
    perimeter = 2 * 3.14f * r;
}


    static void ViewNames(params string[] names)
    {
        foreach (var name in names)
            Console.WriteLine(name);
    }

    //Value Types
    struct Point { public int x; public int y; }

    
    enum Color{ Red, Green, Blue}

    enum Weekdays { Mon, Tue, Wed }
    enum Months{Jan, Feb, March, Aprl, May, June, July, August, Sept, Oct, Nov, Dec}
    //Command line arguments
    public static void Main(string[] args)
    {

        //Primitve Type

        int count=45;
        bool status=false;
        char ch='D';

        Weekdays theDay=Weekdays.Tue;
        Months currentMonth=Months.July;
        Color myColor=Color.Red;


        Person p2=new Person();
        Person p3= new Person("Ishwari", "Karale",456);

        int x = 100;
        long y = x;              // Implicit


        double d = 3.14;
        float f = (float)d;      // Explicit


        string val = "5456";
        int num = Convert.ToInt32(val);

        Console.WriteLine(num);

        string strPrice="45.6";
        double price=Convert.ToDouble(strPrice);

        const int MaxValue = 100; // fixed at compile time
            // can be set in constructor

        int[] marks = new int[] { 90, 80, 70 };

        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }   

        ViewNames("Raj");
        ViewNames("Ishwari", "Nandini", "Sanika");
        ViewNames("Sameer", "Shrutik", "Yash", "Pranav");

        float area1;
        float circumference;
      
        Calculate(25, out area1, out circumference);
        Console.WriteLine(area1);
        Console.WriteLine(circumference);
    } 
}