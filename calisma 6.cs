using System;

namespace calisma_6
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Course;
        public string University;
        public string Gmail;
    }


    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Student student = new Student();
            student.Name = "Vusal";
            student.Surname = "Ahmadzada";
            student.Age = 20;
            student.Course = "Code Academy";
            student.University = "Iqtisadiyyat Universiteti";
            student.Gmail = "vusalaaa.code.edu.az";
            Console.WriteLine("Name : {0} Surname : {1} Age : {2} Course : {3} University : {4} Gmail : {5}", student.Name,student.Surname,student.Age,student.Course,
                student.University,student.Gmail);
        }
    }
}
