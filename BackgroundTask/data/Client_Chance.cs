namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client_Chance
    {
        [Key]
        [StringLength(50)]
        public string ChanceId { get; set; }

        [StringLength(50)]
        public string EnCode { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string SourceId { get; set; }

        [StringLength(50)]
        public string StageId { get; set; }

        public decimal? SuccessRate { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Profit { get; set; }

        [StringLength(50)]
        public string ChanceTypeId { get; set; }

        public decimal? SaleCost { get; set; }

        public DateTime? DealDate { get; set; }

        public int? IsToCustom { get; set; }

        [StringLength(200)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string CompanyNatureId { get; set; }

        [StringLength(200)]
        public string CompanyAddress { get; set; }

        [StringLength(50)]
        public string CompanySite { get; set; }

        public string CompanyDesc { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Contacts { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Wechat { get; set; }

        [StringLength(200)]
        public string Hobby { get; set; }

        [StringLength(50)]
        public string TraceUserId { get; set; }

        [StringLength(50)]
        public string TraceUserName { get; set; }

        public int? ChanceState { get; set; }

        public DateTime? AlertDateTime { get; set; }

        public int? AlertState { get; set; }

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
