namespace Calendar
{
    public class User
    {
        public string _name { get; set; }
        private role _role;

        public User(string name, role role)
        {
            this._role = role;
            _name = name;
        }

        public void ReportProblem()
        {

        }
        private void DeleteUser()
        {

        }

    }
}