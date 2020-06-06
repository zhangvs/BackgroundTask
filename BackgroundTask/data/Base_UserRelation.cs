namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_UserRelation
    {
        [Key]
        [StringLength(50)]
        public string UserRelationId { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        public int? Category { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        public int? IsDefault { get; set; }

        public int? SortCode { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
