namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_FrmMain
    {
        [Key]
        [StringLength(50)]
        public string FrmMainId { get; set; }

        [StringLength(50)]
        public string FrmCode { get; set; }

        [StringLength(200)]
        public string FrmName { get; set; }

        [StringLength(50)]
        public string FrmType { get; set; }

        [StringLength(50)]
        public string FrmDbId { get; set; }

        [StringLength(50)]
        public string FrmTable { get; set; }

        public int? isSystemTable { get; set; }

        [StringLength(50)]
        public string FrmTableId { get; set; }

        [Column(TypeName = "text")]
        public string FrmContent { get; set; }

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
