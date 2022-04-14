using System;
using System.Collections.Generic;
using WiproExtensions;

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

            //StudentStructureDemo();
            //StudentClassDemo();

            //Animal myAnimal = new Animal();  // Create a Animal object
            //Animal myPig = new Pig();  // Create a Pig object
            //Animal myDog = new Dog();  // Create a Dog object

            //myAnimal.animalSound();
            //myPig.animalSound();
            //myDog.animalSound();

            //Pig2 myPig2 = new Pig2(); // Create a Pig object
            //myPig2.animalSound();  // Call the abstract method
            //myPig2.sleep();  // Call the regular method

            //Dog3 myDog3 = new Dog3();
            //myDog3.animalSound();

            //try
            //{
            //    int[] myNumbers = { 1, 2, 3 };
            //    Console.WriteLine(myNumbers[10]);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Something went wrong.");
            //}
            //finally
            //{
            //    Console.WriteLine("The 'try catch' is finished.");
            //}

            //PolymorphismDemo();

            //InterfaceDemo();

            //InterfaceModifiedToAbstractDemo();

            //Teacher teacher1 = new Teacher();
            //teacher1.Name = "Mr. Bakshi";
            //teacher1.ContactAddress = "Chennai";
            //teacher1.DateOfJoining = DateTime.Now;

            //Teacher teacher2 = new Teacher();
            //teacher2.Name = "Mr. Bakshi";
            //teacher2.ContactAddress = "Assam";
            //teacher2.DateOfJoining = DateTime.Now;

            //Car car = new Car();
            
            ////Console.WriteLine(teacher1.Equals(teacher2));
            //Console.WriteLine(teacher1.Equals(car));

            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.IsLeapYear());

            Console.WriteLine("We are in the .Net FSD training!".GetWordCount());

            Extensions.GetWordCount("We are in the .Net FSD training!");

            DateTimeHelper.IsLeapYear(DateTime.Now);

            DateTime.Now.IsLeapYear();
        }

        static void InterfaceDemo() 
        {
            Teacher2 teacher = new Teacher2();
            teacher.Name = "Mr.Teacher";
            teacher.Address = "some address";
            teacher.DateOfJoining = DateTime.Today;

            Student2 student = new Student2();
            student.Name = "Student name";
            student.Address = "some address";
            student.DateOfJoining = DateTime.Today;

            OfficeStaff staff = new OfficeStaff();
            staff.Name = "Mr.Staff";
            staff.Address = "some address";
            staff.DateOfJoining = DateTime.Today;

            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
        }

        static void InterfaceModifiedToAbstractDemo()
        {
            DerivedTeacher teacher = new DerivedTeacher();
            teacher.Name = "Mr.Teacher";
            teacher.Address = "some address";
            teacher.DateOfJoining = DateTime.Today;

            DerivedStudent student = new DerivedStudent();
            student.Name = "Student name";
            student.Address = "some address";
            student.DateOfJoining = DateTime.Today;

            DerivedStaff staff = new DerivedStaff();
            staff.Name = "Mr.Staff";
            staff.Address = "some address";
            staff.DateOfJoining = DateTime.Today;

            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
        }

        static void PolymorphismDemo()
        {
            ElementarySchoolGradeCard elementary = new ElementarySchoolGradeCard();
            elementary.Maths = 90;
            elementary.English = 78;
            elementary.SecondLanguage = 80;
            elementary.SocialScience = 67;
            Console.WriteLine("total marks =" +
                              elementary.getTotalMarks());

            MiddleSchoolGradeCard middle = new MiddleSchoolGradeCard();
            middle.Maths = 90;
            middle.English = 78;
            middle.SecondLanguage = 80;
            middle.Geography = 87;
            middle.History = 76;
            Console.WriteLine("total marks =" + middle.getTotalMarks());

            HighSchoolGradeCard high = new HighSchoolGradeCard();
            high.Maths = 90;
            high.English = 78;
            high.SecondLanguage = 80;
            high.Geography = 87;
            high.History = 76;
            high.Physics = 90;
            high.Chemistry = 76;
            high.Biology = 70;
            Console.WriteLine("total marks =" + high.getTotalMarks());

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
