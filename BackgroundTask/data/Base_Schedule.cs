namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Schedule
    {
        [Key]
        [StringLength(50)]
        public string ScheduleId { get; set; }

        [StringLength(50)]
        public string ScheduleName { get; set; }

        [StringLength(200)]
        public string ScheduleContent { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        public DateTime? StartDate { get; set; }

        [StringLength(50)]
        public string StartTime { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string EndTime { get; set; }

        public int? Early { get; set; }

        public int? IsMailAlert { get; set; }

        public int? IsMobileAlert { get; set; }

        public int? IsWeChatAlert { get; set; }

        public int? ScheduleState { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public int? EnabledMark { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
