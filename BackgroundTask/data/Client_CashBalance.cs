namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client_CashBalance
    {
        [Key]
        [StringLength(50)]
        public string CashBalanceId { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        public DateTime? ExecutionDate { get; set; }

        [StringLength(50)]
        public string CashAccount { get; set; }

        public decimal? Receivable { get; set; }

        public decimal? Expenses { get; set; }

        public decimal? Balance { get; set; }

        [StringLength(200)]
        public string Abstract { get; set; }

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
