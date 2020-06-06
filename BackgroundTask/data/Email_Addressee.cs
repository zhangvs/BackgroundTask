namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Email_Addressee
    {
        [Key]
        [StringLength(50)]
        public string AddresseeId { get; set; }

        [StringLength(50)]
        public string ContentId { get; set; }

        [StringLength(50)]
        public string CategoryId { get; set; }

        [StringLength(50)]
        public string RecipientId { get; set; }

        [StringLength(50)]
        public string RecipientName { get; set; }

        public int? RecipientState { get; set; }

        public int? IsRead { get; set; }

        public int? ReadCount { get; set; }

        public DateTime? ReadDate { get; set; }

        public int? IsHighlight { get; set; }

        public int? Backlog { get; set; }

        public int? DeleteMark { get; set; }

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
