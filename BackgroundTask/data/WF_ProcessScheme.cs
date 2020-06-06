namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_ProcessScheme
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        public string SchemeContent { get; set; }

        [Required]
        [StringLength(50)]
        public string WFSchemeInfoId { get; set; }

        [Required]
        [StringLength(50)]
        public string SchemeVersion { get; set; }

        public int ProcessType { get; set; }
    }
}
