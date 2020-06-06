namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_ModuleButton
    {
        [Key]
        [StringLength(50)]
        public string ModuleButtonId { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

        [StringLength(50)]
        public string EnCode { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string ActionAddress { get; set; }

        public int? SortCode { get; set; }
    }
}
