using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costom_Exception
{
    internal class Program
    {
        class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
        }

        class InvalidStudentNameException : Exception
        {
            public InvalidStudentNameException() { }

            public InvalidStudentNameException(string name)
                : base(String.Format("Invalid Student Name: {0}", name))
            {

            }

            public InvalidStudentNameException(int message, Exception innerException) :
               base(message, innerException)
            {
                
            }
        }

        class Costomexception
        {
            private static void ValidateStudent(string std)
            {

                if (std.Contains("james") == false)
                    throw new InvalidStudentNameException(std);

            }
            private static void ValidateStudentID(int id)
            {

                if (id <= 0)
                    throw new InvalidStudentNameException(id);

            }


            static void Main(string[] args)
            {

                try
                {
                    Student newStudent = new Student();
                    var student = newStudent.StudentName = "James007";
                    var Id = newStudent.StudentID = 12;


                    ValidateStudent(student);
                    ValidateStudentID(Id);
                }
                catch (InvalidStudentNameException ex)
                {
                    Console.WriteLine("first exception caught:", ex.Message);
                }

                Console.ReadKey();
            }

        }
    }
}
