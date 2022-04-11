namespace OopsUsingCSharp
{
    internal class Person
    {
        public string FirstName { private get; set; } //write-only
        public string LastName { private get; set; } //write-only

        public string FullName { get
            {
                return $"{FirstName} {LastName}".Trim(); //read-only
            }
        }
    }
}
