namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRM_FollowUpRecords
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string EnterpriseId { get; set; }

        [StringLength(50)]
        public string CustomerId { get; set; }

        [StringLength(50)]
        public string ContactId { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string CallNumber { get; set; }

        [StringLength(50)]
        public string FollowUpType { get; set; }

        [StringLength(50)]
        public string Purpose { get; set; }

        [StringLength(50)]
        public string Progress { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        [StringLength(50)]
        public string FollowUpTime { get; set; }

        [StringLength(50)]
        public string NextPurpose { get; set; }

        [StringLength(50)]
        public string NextPlanTime { get; set; }

        [StringLength(50)]
        public string CallLogId { get; set; }

        public bool? IsDone { get; set; }
    }
}
