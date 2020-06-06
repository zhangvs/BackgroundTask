namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client_OrderEntry
    {
        [Key]
        [StringLength(50)]
        public string OrderEntryId { get; set; }

        [StringLength(50)]
        public string OrderId { get; set; }

        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [StringLength(200)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string UnitId { get; set; }

        public decimal? Qty { get; set; }

        public decimal? Price { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Taxprice { get; set; }

        public decimal? TaxRate { get; set; }

        public decimal? Tax { get; set; }

        public decimal? TaxAmount { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public int? EnabledMark { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
