namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_DataItemDetail
    {
        [Key]
        [StringLength(50)]
        public string ItemDetailId { get; set; }

        [StringLength(50)]
        public string ItemId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string ItemValue { get; set; }

        [StringLength(200)]
        public string QuickQuery { get; set; }

        [StringLength(200)]
        public string SimpleSpelling { get; set; }

        public int? IsDefault { get; set; }

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
