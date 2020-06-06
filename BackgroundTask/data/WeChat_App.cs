namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WeChat_App
    {
        [Key]
        [StringLength(50)]
        public string AppId { get; set; }

        [StringLength(200)]
        public string AppLogo { get; set; }

        [StringLength(50)]
        public string AppName { get; set; }

        public int? AppType { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(200)]
        public string AppUrl { get; set; }

        [StringLength(200)]
        public string RedirectDomain { get; set; }

        [StringLength(5000)]
        public string MenuJson { get; set; }

        public int? IsReportUser { get; set; }

        public int? IsReportenter { get; set; }

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
