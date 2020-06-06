namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_DatabaseLink
    {
        [Key]
        [StringLength(50)]
        public string DatabaseLinkId { get; set; }

        [StringLength(50)]
        public string ServerAddress { get; set; }

        [StringLength(50)]
        public string DBName { get; set; }

        [StringLength(50)]
        public string DBAlias { get; set; }

        [StringLength(50)]
        public string DbType { get; set; }

        [StringLength(50)]
        public string Version { get; set; }

        [StringLength(200)]
        public string DbConnection { get; set; }

        public int? DESEncrypt { get; set; }

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
