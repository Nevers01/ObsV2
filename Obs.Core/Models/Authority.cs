using Obs.Core.Helper;

namespace Obs.Core.Models
{
    public class Authority : CoreEntity
    {
        public string AuthName { get; set; } = string.Empty;
        public bool IsAdmin { get; set; }
    }
}