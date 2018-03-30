namespace Persistance.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log
    {
        public int id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime logDate { get; set; }

        [Required]
        [StringLength(50)]
        public string logThread { get; set; }

        [Required]
        [StringLength(50)]
        public string logLevel { get; set; }

        [Required]
        [StringLength(300)]
        public string logSource { get; set; }

        [Required]
        [StringLength(4000)]
        public string logMessage { get; set; }

        [StringLength(4000)]
        public string exception { get; set; }
    }
}
