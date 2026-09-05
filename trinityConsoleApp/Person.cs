namespace HR;

//Reference Type

public class Person
{
    private string firstName;
    private string lastName;

    readonly int id;    


    //Method overloading

    public Person()  //Constructor
    {
        this.firstName="Ravi";
        this.lastName="Tambade";
        this.id=56;
    }


    //Parameterized Constructor

    public Person(string fName, string lName, int theId)
    {
        this.firstName=fName;
        this.lastName=lName;
        this.id=theId;
    }


}