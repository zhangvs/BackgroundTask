namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WeChat_UserRelation
    {
        [Key]
        [StringLength(50)]
        public string UserRelationId { get; set; }

        [StringLength(50)]
        public string DeptId { get; set; }

        [StringLength(50)]
        public string DeptName { get; set; }

        public int? WeChatDeptId { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string SyncState { get; set; }

        [StringLength(200)]
        public string SyncLog { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
