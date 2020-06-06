namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Role
    {
        [Key]
        [StringLength(50)]
        public string RoleId { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        public int? Category { get; set; }

        [StringLength(50)]
        public string EnCode { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public int? IsPublic { get; set; }

        public DateTime? OverdueTime { get; set; }

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
