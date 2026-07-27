using System;
using System.Reflection;

using ReflectionDemo;


    class Program
    {
        static void Main()
        {
            //-------------------------------
            // STEP 1 : Get Type Information
            //-------------------------------

            Type t = typeof(Student);

            Console.WriteLine("===== BASIC INFORMATION =====");
            Console.WriteLine($"Class Name : {t.Name}");
            Console.WriteLine($"Full Name  : {t.FullName}");
            Console.WriteLine($"Namespace  : {t.Namespace}");
            Console.WriteLine($"Base Type  : {t.BaseType}");

            Console.WriteLine();

            //-------------------------------
            // STEP 2 : List Constructors
            //-------------------------------

            Console.WriteLine("===== CONSTRUCTORS =====");

            ConstructorInfo[] constructors = t.GetConstructors();

            foreach (ConstructorInfo c in constructors)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            //-------------------------------
            // STEP 3 : List Fields
            //-------------------------------

            Console.WriteLine("===== FIELDS =====");

            FieldInfo[] fields = t.GetFields();

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine();

            //-------------------------------
            // STEP 4 : List Properties
            //-------------------------------

            Console.WriteLine("===== PROPERTIES =====");

            PropertyInfo[] properties = t.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine();

            //-------------------------------
            // STEP 5 : List Methods
            //-------------------------------

            Console.WriteLine("===== METHODS =====");

            MethodInfo[] methods = t.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine();

            //-------------------------------
            // STEP 6 : Create Object Dynamically
            //-------------------------------

            Console.WriteLine("===== CREATING OBJECT =====");

            object obj = Activator.CreateInstance(t);

            Console.WriteLine();

            //-------------------------------
            // STEP 7 : Set Field Value
            //-------------------------------

            FieldInfo rollField = t.GetField("RollNo");

            rollField.SetValue(obj, 101);

            //-------------------------------
            // STEP 8 : Set Property Values
            //-------------------------------

            PropertyInfo nameProperty = t.GetProperty("Name");
            PropertyInfo ageProperty = t.GetProperty("Age");

            nameProperty.SetValue(obj, "Parikshit");
            ageProperty.SetValue(obj, 22);

            //-------------------------------
            // STEP 9 : Read Property Values
            //-------------------------------

            Console.WriteLine("===== PROPERTY VALUES =====");

            Console.WriteLine(nameProperty.GetValue(obj));
            Console.WriteLine(ageProperty.GetValue(obj));

            Console.WriteLine();

            //-------------------------------
            // STEP 10 : Invoke Display()
            //-------------------------------

            Console.WriteLine("===== INVOKING Display() =====");

            MethodInfo displayMethod = t.GetMethod("Display");

            displayMethod.Invoke(obj, null);

            Console.WriteLine();

            //-------------------------------
            // STEP 11 : Invoke Method with Parameters
            //-------------------------------

            Console.WriteLine("===== INVOKING SayHello() =====");

            MethodInfo helloMethod = t.GetMethod("SayHello");

            helloMethod.Invoke(obj, new object[]
            {
                "Welcome to Reflection!"
            });

        }
    }
