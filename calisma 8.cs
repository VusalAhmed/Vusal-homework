using System;

namespace calisma_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Vusal", "Ahmadzada", 20,"Code Academy");
            Student student2 = new Student("Ekber", "Ibrahimov", 19, "Step IT");

            Console.WriteLine(student1.Person());
            Console.WriteLine(student2.Person());
            Console.ReadLine();
        }
    }
}
