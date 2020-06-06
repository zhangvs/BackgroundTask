namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SmsInfo")]
    public partial class SmsInfo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(11)]
        public string Tel { get; set; }

        [Required]
        [StringLength(10)]
        public string Captcha { get; set; }

        public int SendCount { get; set; }

        public int? Status { get; set; }

        public int Type { get; set; }

        [StringLength(50)]
        public string CreateName { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(255)]
        public string SmsContent { get; set; }
    }
}
