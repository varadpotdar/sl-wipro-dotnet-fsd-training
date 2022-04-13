using System;

namespace OopsUsingCSharp
{
    internal class Teacher
    {
        public override string ToString()
        {
            return $"{name} | {address} | {dateOfJoining.ToShortDateString()}";
            //return $"{name}";
        }

        public override bool Equals(object obj)
        {
            return (this.ToString() == obj.ToString());
            //return this.dateOfJoining == (obj as Teacher).DateOfJoining;
        }

        private string name;
        private string address;
        private string contactAddress;
        private DateTime dateOfJoining;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ContactAddress
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }

    }
}
