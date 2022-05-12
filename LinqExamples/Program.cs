namespace LinqExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            Demo3();
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
    }
}
