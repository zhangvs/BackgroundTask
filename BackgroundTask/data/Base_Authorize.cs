namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Authorize
    {
        [Key]
        [StringLength(50)]
        public string AuthorizeId { get; set; }

        public int? Category { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        public int? ItemType { get; set; }

        [StringLength(50)]
        public string ItemId { get; set; }

        public int? SortCode { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
