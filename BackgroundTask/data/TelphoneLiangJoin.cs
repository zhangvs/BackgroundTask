namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneLiangJoin")]
    public partial class TelphoneLiangJoin
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Pro { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(50)]
        public string OpenId { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        public int? Sex { get; set; }

        [StringLength(255)]
        public string HeadimgUrl { get; set; }

        [StringLength(50)]
        public string WXPro { get; set; }

        [StringLength(50)]
        public string WxCity { get; set; }

        [StringLength(50)]
        public string WxAccount { get; set; }

        [StringLength(250)]
        public string WxQRcode { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        public int? CheckMark { get; set; }

        public int? DeleteMark { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? ModifyTime { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
