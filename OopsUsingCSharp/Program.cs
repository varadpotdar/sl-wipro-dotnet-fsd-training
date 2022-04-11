using System;
using System.Collections.Generic;

namespace OopsUsingCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = Car.BuyCar();

            //car.Drive();

            //Console.WriteLine(car.model);

            //Person person = new Person();
            //person.FirstName = "John"; //setter
            //person.LastName = "Doe"; //setter

            //Console.WriteLine(person.FullName); //getter

            StudentStructureDemo();
            StudentClassDemo();
        }

        static void StudentClassDemo()
        {
            string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
            string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };


            string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
            
            List<Student> listStudents = new List<Student>();
            List<Subject> listSubjects = new List<Subject>();

            for (int i = 0; i < arrSubjects.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = arrSubjects[i];
                subject.ShortName = arrSubjectShorts[i];
                listSubjects.Add(subject);
            }

            for (int i = 0; i < arrStudents.Length; i++)
            {
                Student student = new Student();
                student.Name = arrStudents[i];
                student.Address = "Some address";
                student.ContactNumber = "124567";
                student.GuardianName = "My Guardian";
                listStudents.Add(student);
            }


            ClassTeacher classTeacher = new ClassTeacher();
            classTeacher.Name = "Mr.RadheShyam";
            classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
            classTeacher.ContactAddress = "Some address";


            CClass class1A = new CClass();
            class1A.Name = "1A";
            class1A.Students = listStudents;
            class1A.Subjects = listSubjects;
            class1A.ClassTeacher = classTeacher;

            classTeacher.WhichClass = class1A;

        }

        static void StudentStructureDemo()
        {
            StudentStructure[] students = new StudentStructure[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i].name = "Name " + i.ToString();
                students[i].address = "Address of student ";
                students[i].rollNumber = i;
                students[i].className = " VA";
                students[i].dateOfBirth = Convert.ToDateTime("1992-09-10 00:00:00");
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].name + ",");
                Console.Write(students[i].address + ",");
                Console.Write(students[i].rollNumber + ",");
                Console.Write(students[i].className + ",");
                Console.Write(students[i].dateOfBirth);
                Console.WriteLine("------------------------");
            }
        }
    }    
}
