using Student;
class Program
{
    public delegate void DisplayMarksDelegate();
    public static void Main(string[] args)
    {
        StudentResult student = new StudentResult(50);


        DisplayMarksDelegate displayMarksDelegate = new DisplayMarksDelegate(student.DisplayMarks);
        displayMarksDelegate += student.DisplayGrade;
        displayMarksDelegate += student.DisplayResult;
        displayMarksDelegate();


        // student.DisplayMarks();
        // student.DisplayGrade();
        // student.DisplayResult();
        // Console.WriteLine();
    }
}