namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client_Customer
    {
        [Key]
        [StringLength(50)]
        public string CustomerId { get; set; }

        [StringLength(50)]
        public string EnCode { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string CustIndustryId { get; set; }

        [StringLength(50)]
        public string CustTypeId { get; set; }

        [StringLength(50)]
        public string CustLevelId { get; set; }

        [StringLength(50)]
        public string CustDegreeId { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

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

        [StringLength(50)]
        public string Hobby { get; set; }

        [StringLength(50)]
        public string LegalPerson { get; set; }

        [StringLength(200)]
        public string CompanyAddress { get; set; }

        [StringLength(50)]
        public string CompanySite { get; set; }

        public string CompanyDesc { get; set; }

        [StringLength(50)]
        public string TraceUserId { get; set; }

        [StringLength(50)]
        public string TraceUserName { get; set; }

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
