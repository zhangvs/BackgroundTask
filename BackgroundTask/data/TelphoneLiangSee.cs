namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneLiangSee")]
    public partial class TelphoneLiangSee
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string IPAddressName { get; set; }

        [StringLength(50)]
        public string OpenId { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        public int? Sex { get; set; }

        [StringLength(255)]
        public string HeadimgUrl { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        public DateTime? SeeDate { get; set; }
    }
}
