namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneLiangShare")]
    public partial class TelphoneLiangShare
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string OpenId { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(255)]
        public string HeadimgUrl { get; set; }

        [StringLength(255)]
        public string ShareUrl { get; set; }

        [StringLength(255)]
        public string ShareTitle { get; set; }

        [StringLength(2000)]
        public string ShareContent { get; set; }

        [StringLength(50)]
        public string ShareTo { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
