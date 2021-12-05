using ImTools;
using System;

namespace stringreverse1
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            
            string str;
            string result = "";
            Console.WriteLine("Orginal: Hello World");
            str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; --i) ;
            result = result + str[i];
            Console.WriteLine("Reverse String:" + result);
        }
    }
}



 
public class StudentAndTeacherTest
{
    public static void Main()
    {
        Person myPerson = new Person();
        myPerson.Greet();

        Student myStudent = new Student();
        myStudent.SetAge(20);
        myStudent.Greet();
        myStudent.ShowAge();
        myStudent.Study();

        Teacher myTeacher = new Teacher();
        myTeacher.SetAge(28);
        myTeacher.Greet();
        myTeacher.Explain();
    }
}

public class Person
{
    protected int age;

    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public void SetAge(int x)
    {
        age = x; 
    }
}

public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is {0} years old", age);
    }
}

public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining");
    }
}