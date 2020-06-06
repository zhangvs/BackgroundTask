namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_ModuleFormInstance
    {
        [Key]
        [StringLength(50)]
        public string FormInstanceId { get; set; }

        [StringLength(50)]
        public string FormId { get; set; }

        public string FormInstanceJson { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        public int? SortCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
