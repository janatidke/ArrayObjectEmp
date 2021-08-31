using System;

namespace ArrayObjectEmp
{
    class Employee
    {
        internal int Empid;
        internal string EmpName;

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int emp;
            Console.WriteLine("Enter The Number Of Employees:");
            emp = Convert.ToInt32(Console.ReadLine());
            Employee[] Emp = new Employee[emp];

            for (int i = 1; i < emp; i++)
            {
                Emp[i] = new Employee();
                Console.WriteLine("Enter Details of Employee {0} :", i);
                Console.Write("Enter Employee ID: ");
                Emp[i].Empid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name: ");
                Emp[i].EmpName = Console.ReadLine();
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("ID\tName");
            for (int i = 0; i < emp; i++)
                Console.WriteLine("{0}\t{1}", Emp[i].Empid, Emp[i].EmpName);
        }
    }
}
