namespace LinqExamples
{
    internal class Program
    {
        delegate bool IsYoungerThan(Student stud, int youngAge);
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
            //Demo5();
            Demo6();
            //Demo7();
        }

        private static void Demo1()
        {
            Student[] studentArray = {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob", Age = 19  },
            };

            Student[] teenagers = new Student[10];

            int i = 0;

            foreach (Student std in studentArray)
            {
                if (std.Age > 12 && std.Age < 20)
                {
                    teenagers[i] = std;
                    i++;
                }
            }
        }

        private static void Demo2()
        {
            Student[] studentArray = {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                new Student() { StudentID = 7, StudentName = "Rob",Age = 19  } ,
            };

            Student[] students = StudentExtension.Where(studentArray, delegate (Student std) {
                return std.Age > 12 && std.Age < 20;
            });
        }

        private static void Demo3()
        {
            Student[] studentArray = {
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rob",Age = 19  } ,
                };

            // Use LINQ to find teenager students
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            // Use LINQ to find first student whose name is Bill 
            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

            // Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
        }

        private static void Demo4()
        {
            // string collection
            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            // LINQ Query Syntax
            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }

        private static void Demo5()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s.StudentName;
            Console.WriteLine("Teen age Students:");

            //foreach (Student std in teenAgerStudent)
            //{
            //    Console.WriteLine(std.StudentName);
            //}

            foreach(string name in teenAgerStudent)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }

        private static void Demo6()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            // LINQ Method Syntax to find out teenager students
            
            Func<Student, bool> predicate = s => s.Age > 12 && s.Age < 20;

            var teenAgerStudents = studentList.Where(predicate)
                                              .ToArray();

            var teens = from student in studentList
                        where predicate(student)
                        select student.StudentName;
        }

        private static void Demo7()
        {
            IsYoungerThan isYoungerThan = (s, youngAge) => s.Age < youngAge;

            Student stud = new Student() { Age = 25 };

            Console.WriteLine(isYoungerThan(stud, 24));
        }

        void PrintStudentDetail(Student s)
        {
            Console.WriteLine("Name: {0}, Age: {1} ", s.StudentName, s.Age);
        }
    }
}
