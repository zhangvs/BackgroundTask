namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneReserveSee")]
    public partial class TelphoneReserveSee
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string IPAddressName { get; set; }

        public DateTime? SeeDate { get; set; }
    }
}
