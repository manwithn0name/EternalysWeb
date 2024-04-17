namespace qwerty_12345
{
    using System.Configuration;

    public class Credentials
    {
        private static readonly string _email;
        private static readonly string _password;
        private static readonly string _connectionString;

        static Credentials()
        {
            _email = "i.yussupov@eternalys.com";
            _password = "";
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public static string Email { get { return _email; } }
        public static string Password { get { return _password; } }
        public static string ConnectionString { get { return _connectionString; } }
    }
}
