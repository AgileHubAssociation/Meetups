namespace Structural_Models
{
    public class Student : Person
    {
        public int Id { get; set; }

        public Student()
        {

        }

        public Student(int id, string firstName, string lastName)
            : base(firstName, lastName)
        {
            Id = id;
        }
    }
}
