namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_AuthorizeData
    {
        [Key]
        [StringLength(50)]
        public string AuthorizeDataId { get; set; }

        public int? AuthorizeType { get; set; }

        public int? Category { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [StringLength(50)]
        public string ItemId { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string ResourceId { get; set; }

        public int? IsRead { get; set; }

        [StringLength(200)]
        public string AuthorizeConstraint { get; set; }

        public int? SortCode { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
