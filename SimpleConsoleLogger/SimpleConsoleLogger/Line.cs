using System.Runtime.Serialization;

namespace SimpleConsoleLogger
{
    [DataContract]
    public class Line
    {
        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "color")]
        public string Color { get; set; }

        [DataMember(Name = "level")]
        public Level Level { get; set; }
    }
}
