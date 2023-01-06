namespace Calendar
{
    internal static partial class Program
    {
        /// <summary> 
        /// The App will have funcionality of adding and removing users, as well as, assigning the users to role.
        /// users should be able to create and remove events from calendar accordingly to their role permissions.
        /// </summary>

        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}