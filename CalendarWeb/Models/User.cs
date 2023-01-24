using System.ComponentModel.DataAnnotations;

namespace Calendar
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public role Role { get; set; }

        public User(string name,string password, role role)
        {
            Role = role;
            UserName = name;
            Password = password;
        }
        public User()
        {
        }

        public void ReportProblem()
        {

        }
        private void DeleteUser()
        {

        }

    }
}