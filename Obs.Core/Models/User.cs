using Obs.Core.Helper;

namespace Obs.Core.Models
{
    public class User : CoreEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Auth { get; set; } = string.Empty;
        public long Tckn { get; set; }
    }
}