using System.Linq;
using FinanceFlow.Data;

namespace FinanceFlow.Service
{
    public class AuthService
    {
        private readonly FinanceFlowContext _context;

        public AuthService(FinanceFlowContext context)
        {
            _context = context;
        }

        public bool Register(string username, string password)
        {
            if (_context.Users.Any(u => u.Username == username))
                return false;

            var user = new User { Username = username, Password = HashPassword(password) };
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public User Login(string username, string password)
        {
            var hashedPassword = HashPassword(password);
            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == hashedPassword);
        }

        private string HashPassword(string password)
        {
            // Implement a hashing method here
            return password;
        }
    }
}
