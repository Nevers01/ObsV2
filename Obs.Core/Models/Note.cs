using Obs.Core.Helper;

namespace Obs.Core.Models
{
    public class Note : CoreEntity
    {
        public int StudentId { get; set; }
        public string EduCode { get; set; } = string.Empty;
        public int StudentNote { get; set; }
        public DateTime Date { get; set; }
    }
}