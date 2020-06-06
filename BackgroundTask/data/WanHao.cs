namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WanHao")]
    public partial class WanHao
    {
        [Key]
        [StringLength(11)]
        public string WanId { get; set; }
    }
}
