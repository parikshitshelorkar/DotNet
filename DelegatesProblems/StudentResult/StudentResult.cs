namespace Student;
class StudentResult
{
    public int marks;
    public string grade;

    public StudentResult(int marks)
    {
        this.marks = marks;
        grade = "";
    }
    public void DisplayMarks()
    {
        Console.WriteLine($"Student's marks: {marks}");
    }
    public void DisplayGrade()
    {   
        if(marks >= 90)
        {
            grade = "A";
        }
        else if(marks >= 80)
        {
            grade = "B";
        }
        else if(marks >= 70)
        {
            grade = "C";
        }
        else if(marks >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine($"Student's grade: {grade}");
    }
    public void DisplayResult()
    {
        if(marks >= 40)
        {
            Console.WriteLine("Student has passed the exam.");
        }
        else
        {
            Console.WriteLine("Student has failed the exam.");
        }
    }
}