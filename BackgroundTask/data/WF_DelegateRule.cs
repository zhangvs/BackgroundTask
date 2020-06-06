namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_DelegateRule
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string ToUserId { get; set; }

        [StringLength(50)]
        public string ToUserName { get; set; }

        public DateTime? BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? EnabledMark { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
