namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_Content
    {
        [Key]
        [StringLength(50)]
        public string ContentId { get; set; }

        public int? IsGroup { get; set; }

        [StringLength(50)]
        public string SendId { get; set; }

        [StringLength(50)]
        public string ToId { get; set; }

        [StringLength(200)]
        public string MsgContent { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
