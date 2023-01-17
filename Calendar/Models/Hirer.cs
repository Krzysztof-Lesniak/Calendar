namespace Calendar.Models
{
    public class Hirer : User
    {
        public string surname { get; }
        public int budget { get; set; }

        public Hirer(string userName, string password, role role = role.hirer) 
            : base(userName, password, role)
        {

        }
        public Hirer(string userName, string password, string surname, role role) 
            : base(userName,password, role)
        {
            this.surname = surname;
        }
        public Hirer(string userName, string password, string surname, role role, int budget) 
            : base(userName,password, role)
        {
            this.surname = surname;
            this.budget = budget;
        }

        public void CreateEvent()
        {

        }
    }
}