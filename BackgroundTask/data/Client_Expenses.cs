namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client_Expenses
    {
        [Key]
        [StringLength(50)]
        public string ExpensesId { get; set; }

        public DateTime? ExpensesDate { get; set; }

        public decimal? ExpensesPrice { get; set; }

        [StringLength(50)]
        public string ExpensesAccount { get; set; }

        [StringLength(50)]
        public string ExpensesType { get; set; }

        [StringLength(200)]
        public string ExpensesAbstract { get; set; }

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

        public int? ExpensesObject { get; set; }

        [StringLength(50)]
        public string Managers { get; set; }
    }
}
