using Obs.Core.Helper;

namespace Obs.Core.Models
{
    public class Announcement : CoreEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public string AnnoType { get; set; } = string.Empty;
        public string? AnnoEdu { get; set; }
    }
}