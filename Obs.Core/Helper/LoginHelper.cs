namespace Obs.Core.Helper
{
    public class LoginHelper
    {
        private readonly ObsDbContext _context;

        public LoginHelper(ObsDbContext context)
        {
            _context = context;
        }

        public class LoginResult
        {
            public bool IsSuccess { get; set; }
            public bool IsAdmin { get; set; }
            public int UserId { get; set; }
            public string Message { get; set; }
        }

        public LoginResult LoginControl(string username, string password)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user == null)
            {
                return new LoginResult
                {
                    IsSuccess = false,
                    IsAdmin = false,
                    Message = "Kullanıcı adı veya şifre hatalı."
                };
            }

            var yetki = _context.Authoritys
                .FirstOrDefault(y => y.AuthName == user.Auth);

            bool isAdmin = yetki?.IsAdmin ?? false;

            return new LoginResult
            {
                IsSuccess = true,
                IsAdmin = isAdmin,
                UserId = user.Id,
                Message = "Giriş başarılı."
            };
        }
    }
}