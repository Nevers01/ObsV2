using Obs.Core.Helper;

namespace Obs.Core.Models
{
    public class Discontinuity : CoreEntity
    {
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int StudentId { get; set; }
    }
}