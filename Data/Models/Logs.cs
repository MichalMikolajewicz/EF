using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Logs
    {
        public int Id { get; set; }
        public DateTime LogDate { get; set; }
        public string LogThread { get; set; }
        public string LogLevel { get; set; }
        public string LogSource { get; set; }
        public string LogMessage { get; set; }
        public string Exception { get; set; }
    }
}
