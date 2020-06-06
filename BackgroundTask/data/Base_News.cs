namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_News
    {
        [Key]
        [StringLength(50)]
        public string NewsId { get; set; }

        public int? TypeId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(200)]
        public string FullHead { get; set; }

        [StringLength(50)]
        public string FullHeadColor { get; set; }

        [StringLength(50)]
        public string BriefHead { get; set; }

        [StringLength(50)]
        public string AuthorName { get; set; }

        [StringLength(50)]
        public string CompileName { get; set; }

        [StringLength(200)]
        public string TagWord { get; set; }

        [StringLength(200)]
        public string Keyword { get; set; }

        [StringLength(50)]
        public string SourceName { get; set; }

        [StringLength(50)]
        public string SourceAddress { get; set; }

        [Column(TypeName = "text")]
        public string NewsContent { get; set; }

        public int? PV { get; set; }

        public DateTime? ReleaseTime { get; set; }

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
