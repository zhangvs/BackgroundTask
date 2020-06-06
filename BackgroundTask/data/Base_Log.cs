namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Log
    {
        [Key]
        [StringLength(50)]
        public string LogId { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(50)]
        public string SourceObjectId { get; set; }

        [Column(TypeName = "text")]
        public string SourceContentJson { get; set; }

        public DateTime? OperateTime { get; set; }

        [StringLength(50)]
        public string OperateUserId { get; set; }

        [StringLength(50)]
        public string OperateAccount { get; set; }

        [StringLength(50)]
        public string OperateTypeId { get; set; }

        [StringLength(50)]
        public string OperateType { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        [StringLength(50)]
        public string Module { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(200)]
        public string IPAddressName { get; set; }

        [StringLength(200)]
        public string Host { get; set; }

        [StringLength(50)]
        public string Browser { get; set; }

        public int? ExecuteResult { get; set; }

        [Column(TypeName = "text")]
        public string ExecuteResultJson { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? DeleteMark { get; set; }

        public int? EnabledMark { get; set; }
    }
}
