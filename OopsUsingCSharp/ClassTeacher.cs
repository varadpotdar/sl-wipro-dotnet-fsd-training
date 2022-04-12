namespace OopsUsingCSharp
{
    internal class ClassTeacher : Teacher
    {
        private CClass whichClass;

        public CClass WhichClass
        {
            get { return whichClass; }
            set { whichClass = value; }
        }
    }
}
