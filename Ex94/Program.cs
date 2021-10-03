using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex94
{
    class Student : IComparable
    {
        double id;
        string name;

        public Student(double p_id, string p_name)
        {
            this.id = p_id;
            this.name = p_name;
        }
        public override string ToString()
        {
            return "id is: " + id + " name is: " + name;
        }



        public int CompareTo(object obj)
        {
            Student s = (Student)obj;
            return id.CompareTo(s.id);

        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();
            stu.Add(new Student(123456789, "name1"));
            stu.Add(new Student(111111111, "name2"));
            stu.Add(new Student(111111112, "name3"));
            stu.Add(new Student(111111114, "name4"));
            stu.Add(new Student(111111113, "name5"));

            for (int i = 0; i < stu.Count; i++)
                    Console.WriteLine(stu[i]);           

            Console.WriteLine("----------------------");

            stu.Sort();

            for (int i = 0; i < stu.Count; i++)
                Console.WriteLine(stu[i]);   
        }
    }
}
