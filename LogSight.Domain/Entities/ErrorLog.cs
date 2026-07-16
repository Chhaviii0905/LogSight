using LogSight.Domain.Enums;

namespace LogSight.Domain.Entities
{
    public class ErrorLog : BaseEntity
    {
        public string Message { get; set; } = string.Empty;
        public string ExceptionType { get; set; } = string.Empty;
        public string? StackTrace { get; set; }
        public string Endpoint { get; set; } = string.Empty;
        public string HttpMethod { get; set; } = string.Empty;
        public int StatusCode { get; set; }
        public LogSeverity Severity { get; set; }
        public string CorrelationId { get; set; } = string.Empty;
        public string? UserName { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public string Environment { get; set; } = string.Empty;
    }
}