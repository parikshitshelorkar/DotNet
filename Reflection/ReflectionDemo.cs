    namespace ReflectionDemo;
    class Student
    {
        // Field
        public int RollNo;

        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructors
        public Student()
        {
            Console.WriteLine("Default Constructor Called");
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Methods
        public void Display()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age  : {Age}");
            Console.WriteLine($"Roll : {RollNo}");
        }

        public void SayHello(string message)
        {
            Console.WriteLine(message);
        }
    }