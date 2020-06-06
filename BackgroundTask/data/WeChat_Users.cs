namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WeChat_Users
    {
        [Key]
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

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string AppName { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
