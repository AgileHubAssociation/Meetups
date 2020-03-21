namespace UniversityLibrary
{
    public class Person
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }
        
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}