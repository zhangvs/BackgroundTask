namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_FileInfo
    {
        [Key]
        [StringLength(50)]
        public string FileId { get; set; }

        [StringLength(50)]
        public string FolderId { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(200)]
        public string FilePath { get; set; }

        [StringLength(50)]
        public string FileSize { get; set; }

        [StringLength(50)]
        public string FileExtensions { get; set; }

        [StringLength(50)]
        public string FileType { get; set; }

        public int? IsShare { get; set; }

        [StringLength(200)]
        public string ShareLink { get; set; }

        public int? ShareCode { get; set; }

        public DateTime? ShareTime { get; set; }

        public int? DownloadCount { get; set; }

        public int? IsTop { get; set; }

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
