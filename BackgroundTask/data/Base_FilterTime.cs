namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_FilterTime
    {
        [Key]
        [StringLength(50)]
        public string FilterTimeId { get; set; }

        [StringLength(50)]
        public string ObjectType { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        public int? VisitType { get; set; }

        [StringLength(200)]
        public string WeekDay1 { get; set; }

        [StringLength(200)]
        public string WeekDay2 { get; set; }

        [StringLength(200)]
        public string WeekDay3 { get; set; }

        [StringLength(200)]
        public string WeekDay4 { get; set; }

        [StringLength(200)]
        public string WeekDay5 { get; set; }

        [StringLength(200)]
        public string WeekDay6 { get; set; }

        [StringLength(200)]
        public string WeekDay7 { get; set; }

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
