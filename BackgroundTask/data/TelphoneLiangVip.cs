namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneLiangVip")]
    public partial class TelphoneLiangVip
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public int? UploadMax { get; set; }

        public int? OtherMax { get; set; }

        public int? OrgMax { get; set; }

        public decimal? Price { get; set; }

        public DateTime? VipStartDate { get; set; }

        public DateTime? VipEndDate { get; set; }

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
