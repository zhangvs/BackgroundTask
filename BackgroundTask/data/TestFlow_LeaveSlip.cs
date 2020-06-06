namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TestFlow_LeaveSlip
    {
        [StringLength(50)]
        public string id { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        public string reason { get; set; }

        [StringLength(40)]
        public string begintime { get; set; }

        [StringLength(40)]
        public string endtime { get; set; }

        public int? days { get; set; }
    }
}
