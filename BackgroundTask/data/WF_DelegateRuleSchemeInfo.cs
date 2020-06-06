namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_DelegateRuleSchemeInfo
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DelegateRuleId { get; set; }

        [Required]
        [StringLength(50)]
        public string SchemeInfoId { get; set; }
    }
}
