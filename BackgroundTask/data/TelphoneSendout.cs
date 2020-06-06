namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneSendout")]
    public partial class TelphoneSendout
    {
        public int Id { get; set; }

        [StringLength(11)]
        public string Telphone { get; set; }

        [StringLength(10)]
        public string Number { get; set; }

        [StringLength(10)]
        public string Grade { get; set; }

        [StringLength(50)]
        public string Pro { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? SellMark { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

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
