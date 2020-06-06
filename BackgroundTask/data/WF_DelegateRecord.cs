namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_DelegateRecord
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string WFDelegateRuleId { get; set; }

        [StringLength(50)]
        public string FromUserId { get; set; }

        [StringLength(50)]
        public string FromUserName { get; set; }

        [StringLength(50)]
        public string ToUserId { get; set; }

        [StringLength(50)]
        public string ToUserName { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string ProcessId { get; set; }

        [StringLength(200)]
        public string ProcessCode { get; set; }

        [StringLength(200)]
        public string ProcessName { get; set; }
    }
}
