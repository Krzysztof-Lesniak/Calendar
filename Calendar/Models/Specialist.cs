namespace Calendar
{
    public class Specialist : User
    {
        public string surname { get; }
        public int budget { get; set; }

        public Specialist(string name, string password, role role = role.specialist) 
            : base(name,password, role)
        {

        }

        private void StartTask()
        {

        }
        private void EndTask()
        {

        }

    }
}