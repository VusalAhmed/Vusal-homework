using System;

namespace calisma_77
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Vusal", "Ahmadzada", 20);
            Student student2 = new Student("Ekber", "Ibrahimov", 19);
            student1.Person();
            student2.Person();
            Console.ReadKey();
        }
    }
    class Student
    {
         String name;
        String surname;
        int age;

        public Student(String name, String surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            
           

        }
        public void Person()
                {
                    Console.WriteLine(name + " " + surname + age);
                }
            }

       
}
