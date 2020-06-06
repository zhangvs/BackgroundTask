namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneXiNo")]
    public partial class TelphoneXiNo
    {
        public int Id { get; set; }

        [StringLength(11)]
        public string Telphone { get; set; }

        public int? state { get; set; }
    }
}
