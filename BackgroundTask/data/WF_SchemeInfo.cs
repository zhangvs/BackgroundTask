namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_SchemeInfo
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string SchemeCode { get; set; }

        [StringLength(200)]
        public string SchemeName { get; set; }

        [StringLength(50)]
        public string SchemeType { get; set; }

        [StringLength(50)]
        public string SchemeVersion { get; set; }

        public string SchemeCanUser { get; set; }

        public int? FrmType { get; set; }

        public int? AuthorizeType { get; set; }

        public int? SortCode { get; set; }

        public int DeleteMark { get; set; }

        public int EnabledMark { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
