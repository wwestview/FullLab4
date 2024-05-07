using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace struct_lab_student
{
    partial class Program
    {
        public static List<Student> ReadData(StreamReader sr)
        {
            List<Student> students = new List<Student>();
            try
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] subs = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string newStr = string.Join(" ", subs);
                    students.Add(new Student(newStr));
                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sr.Close();
            }
            return students;
        }

        static void RunMenu(List<Student> studs)
        {
            RunMenu11(studs.ToArray());
        }

        static void RunMenu11(Student[] students)
        {
            foreach (var student in students)
            {
                double avgMark = ((student.mathematicsMark + student.physicsMark + student.informaticsMark) / 3.0);
                if (avgMark > 4.5)
                {
                    Console.WriteLine($"{student.surName} {student.firstName} {student.patronymic}: {student.physicsMark}");
                }
            }
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            List<Student> students = ReadData(sr);

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            RunMenu(students);
        }
    }
}
