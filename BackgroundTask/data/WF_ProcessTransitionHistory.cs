namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_ProcessTransitionHistory
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProcessId { get; set; }

        [Required]
        [StringLength(50)]
        public string fromNodeId { get; set; }

        public int? fromNodeType { get; set; }

        [StringLength(200)]
        public string fromNodeName { get; set; }

        [Required]
        [StringLength(50)]
        public string toNodeId { get; set; }

        public int? toNodeType { get; set; }

        [StringLength(200)]
        public string toNodeName { get; set; }

        public int TransitionSate { get; set; }

        public int isFinish { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
