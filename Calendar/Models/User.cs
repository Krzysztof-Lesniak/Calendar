namespace Calendar
{
    public class User
    {
        public string _userName { get; set; }
        public string _password { get; set; }
        public role _role { get; set; }

        public User(string name,string password, role role)
        {
            _role = role;
            _userName = name;
            _password = password;

        }

        public void ReportProblem()
        {

        }
        private void DeleteUser()
        {

        }

    }
}