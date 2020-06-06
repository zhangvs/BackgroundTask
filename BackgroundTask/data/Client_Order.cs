namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client_Order
    {
        [Key]
        [StringLength(50)]
        public string OrderId { get; set; }

        [StringLength(50)]
        public string CustomerId { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string SellerId { get; set; }

        [StringLength(50)]
        public string SellerName { get; set; }

        public DateTime? OrderDate { get; set; }

        [StringLength(50)]
        public string OrderCode { get; set; }

        public decimal? DiscountSum { get; set; }

        public decimal? Accounts { get; set; }

        public decimal? ReceivedAmount { get; set; }

        public DateTime? PaymentDate { get; set; }

        [StringLength(50)]
        public string PaymentMode { get; set; }

        public int? PaymentState { get; set; }

        public decimal? SaleCost { get; set; }

        [StringLength(200)]
        public string AbstractInfo { get; set; }

        [StringLength(50)]
        public string ContractCode { get; set; }

        [StringLength(200)]
        public string ContractFile { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public int? EnabledMark { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
