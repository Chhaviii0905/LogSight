using LogSight.Domain.Enums;

namespace LogSight.Domain.Entities
{
    public class AlertRule : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid CreatedByUserId { get; set; }
        public User? CreatedByUser { get; set; }
        public bool IsEnabled { get; set; } = true;
        public LogSeverity Severity { get; set; }
        public int Threshold { get; set; }
    }
}