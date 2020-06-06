namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneReserveSearch")]
    public partial class TelphoneReserveSearch
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string SearchNumber { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string IPAddressName { get; set; }

        public DateTime? SearchDate { get; set; }
    }
}
