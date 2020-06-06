namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_ProcessOperationHistory
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProcessId { get; set; }

        [Required]
        [StringLength(200)]
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
