namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TelphoneLiangBak721
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TelphoneID { get; set; }

        [StringLength(11)]
        public string Telphone { get; set; }

        [StringLength(10)]
        public string City { get; set; }

        [StringLength(10)]
        public string CityId { get; set; }

        [StringLength(10)]
        public string Operator { get; set; }

        [StringLength(50)]
        public string Grade { get; set; }

        public decimal? MinPrice { get; set; }

        public decimal? Price { get; set; }

        public decimal? ChaPrice { get; set; }

        [StringLength(150)]
        public string Package { get; set; }

        public int? ExistMark { get; set; }

        public int? SellMark { get; set; }

        [StringLength(50)]
        public string SellerId { get; set; }

        [StringLength(50)]
        public string SellerName { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public int? EnabledMark { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

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
