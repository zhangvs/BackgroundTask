namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_ProcessInstance
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Code { get; set; }

        [StringLength(200)]
        public string CustomName { get; set; }

        [Required]
        [StringLength(50)]
        public string ActivityId { get; set; }

        public int ActivityType { get; set; }

        [Required]
        [StringLength(200)]
        public string ActivityName { get; set; }

        [StringLength(50)]
        public string PreviousId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProcessSchemeId { get; set; }

        [Required]
        [StringLength(50)]
        public string SchemeType { get; set; }

        public int? FrmType { get; set; }

        public int EnabledMark { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        public int? wfLevel { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? isFinish { get; set; }

        [StringLength(1000)]
        public string MakerList { get; set; }
    }
}
