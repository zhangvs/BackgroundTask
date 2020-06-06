namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_SchemeContent
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string WFSchemeInfoId { get; set; }

        [Required]
        [StringLength(50)]
        public string SchemeVersion { get; set; }

        public string SchemeContent { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
