namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Email_Content
    {
        [Key]
        [StringLength(50)]
        public string ContentId { get; set; }

        [StringLength(50)]
        public string CategoryId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(200)]
        public string Theme { get; set; }

        [StringLength(50)]
        public string ThemeColor { get; set; }

        [Column(TypeName = "text")]
        public string EmailContent { get; set; }

        public int? EmailType { get; set; }

        [StringLength(50)]
        public string SenderId { get; set; }

        [StringLength(50)]
        public string SenderName { get; set; }

        public DateTime? SenderTime { get; set; }

        public int? IsHighlight { get; set; }

        [StringLength(50)]
        public string SendPriority { get; set; }

        public int? IsSmsReminder { get; set; }

        public int? IsReceipt { get; set; }

        [Column(TypeName = "text")]
        public string AddresssHtml { get; set; }

        [Column(TypeName = "text")]
        public string CopysendHtml { get; set; }

        [Column(TypeName = "text")]
        public string BccsendHtml { get; set; }

        public int? SendState { get; set; }

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
