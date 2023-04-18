namespace StudentWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Age { get; set; }
        public int Roll { get; set; }

        public string Address { get; set; }

        public DateTime CreateOn { get; set; }
        public string CreateBy { get; set; }

        public DateTime UpdateOn { get; set; }
        public string UpdateBy { get; set; }

        public DateTime DeleteOn { get; set; }
        public string DeleteBy { get; set; }

        //public Teacher Teacher { get; set; }
    }
}
