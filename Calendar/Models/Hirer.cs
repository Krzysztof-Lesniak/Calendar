namespace Calendar.Models
{
    public class Hirer : User
    {
        public string surname { get; }
        public int budget { get; set; }

        public Hirer(string name, role role = role.hirer) : base(name, role)
        {

        }
        public Hirer(string name, string surname, role role) : base(name, role)
        {
            this.surname = surname;
        }
        public Hirer(string name, string surname, role role, int budget) : base(name, role)
        {
            this.surname = surname;
            this.budget = budget;
        }

        public void CreateEvent()
        {

        }
    }
}