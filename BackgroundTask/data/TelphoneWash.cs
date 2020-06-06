namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneWash")]
    public partial class TelphoneWash
    {
        [Key]
        public int TelphoneID { get; set; }

        [StringLength(11)]
        public string Telphone { get; set; }

        [StringLength(4)]
        public string Grade { get; set; }

        [StringLength(4)]
        public string Number { get; set; }

        public int? AssignMark { get; set; }

        [StringLength(50)]
        public string SellerId { get; set; }

        [StringLength(50)]
        public string SellerName { get; set; }

        public DateTime? ObtainDate { get; set; }

        public DateTime? CallTime { get; set; }

        public int? NoConnectMark { get; set; }

        public int? NoDealMark { get; set; }

        [StringLength(10)]
        public string Surname { get; set; }

        public int? SexMark { get; set; }

        public int? AgeMark { get; set; }

        public int? AreaMark { get; set; }

        public int? ToneMark { get; set; }

        public int? IntentionMark { get; set; }

        public int? SellMark { get; set; }

        [StringLength(200)]
        public string CallDescription { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public int? EnabledMark { get; set; }

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
