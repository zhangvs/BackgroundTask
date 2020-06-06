namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneOrder")]
    public partial class TelphoneOrder
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string OrderCode { get; set; }

        [StringLength(11)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string SellerId { get; set; }

        [StringLength(50)]
        public string SellerName { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Paid { get; set; }

        [StringLength(50)]
        public string PaidDate { get; set; }

        public decimal? ToPay { get; set; }

        [StringLength(50)]
        public string ToPayDate { get; set; }

        public decimal? ToPayCharge { get; set; }

        [StringLength(50)]
        public string PayMode { get; set; }

        [StringLength(50)]
        public string Account { get; set; }

        public int? Transferred { get; set; }

        [StringLength(20)]
        public string Consignee { get; set; }

        [StringLength(20)]
        public string Contact { get; set; }

        [StringLength(50)]
        public string Pro { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Express { get; set; }

        [StringLength(20)]
        public string Numbers { get; set; }

        public int? CheckMark { get; set; }

        public int? SendMark { get; set; }

        public int? Sign { get; set; }

        [StringLength(50)]
        public string AcceptTime { get; set; }

        [StringLength(50)]
        public string AcceptStation { get; set; }

        public int? ActivationMark { get; set; }

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

        [StringLength(50)]
        public string Source { get; set; }
    }
}
