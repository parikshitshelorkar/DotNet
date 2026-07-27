namespace std;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }


    public Student(int Id, string name, int age, string department)
    {
        this.Id = Id;
        this.Name = name;
        this.Age = age;
        this.Department = department;
    }
    public Student AddStudent(int Id, string name, int age, string department)
    {
        return new Student(Id, name, age, department);
    }
    public void ViewStudent(int id)
    {
        Console.WriteLine($"Student ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Department: {Department}");
    }
    public void UpdateStudent(int id, string name, int age)
    {
        // Code to update a student
    }
    public void DeleteStudent(int id)
    {
        // Code to delete a student
    }
}