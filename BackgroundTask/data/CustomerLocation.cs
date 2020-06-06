namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLocation")]
    public partial class CustomerLocation
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string wxLon { get; set; }

        [StringLength(50)]
        public string wxLat { get; set; }

        [StringLength(50)]
        public string bdLon { get; set; }

        [StringLength(50)]
        public string bdLat { get; set; }

        [StringLength(250)]
        public string ShopAddress { get; set; }

        [StringLength(50)]
        public string ShopName { get; set; }

        [StringLength(500)]
        public string ShopPicture { get; set; }

        [StringLength(50)]
        public string Contacts { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string ContactsSpare { get; set; }

        [StringLength(50)]
        public string TelphoneSpare { get; set; }

        public int? State { get; set; }

        [StringLength(50)]
        public string SellerId { get; set; }

        [StringLength(50)]
        public string SellerName { get; set; }

        [StringLength(50)]
        public string OpenId { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
