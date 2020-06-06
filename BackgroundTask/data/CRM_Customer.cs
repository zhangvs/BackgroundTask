namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRM_Customer
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string CustomerCode { get; set; }

        [StringLength(50)]
        public string CustomerType { get; set; }

        [StringLength(50)]
        public string CustomerStatus { get; set; }

        [StringLength(50)]
        public string CustomerLabel { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }

        [StringLength(50)]
        public string WebSite { get; set; }

        [StringLength(50)]
        public string CorporateRepresentative { get; set; }

        [StringLength(50)]
        public string IndustryType { get; set; }

        [StringLength(50)]
        public string MainProject { get; set; }

        [StringLength(50)]
        public string Assets { get; set; }

        [StringLength(50)]
        public string AnnualTurnover { get; set; }

        [StringLength(50)]
        public string EnterpriseScale { get; set; }

        [StringLength(50)]
        public string EnterpriseNature { get; set; }

        [StringLength(50)]
        public string FollowUpUserName { get; set; }

        [StringLength(50)]
        public string FollowUpWorkerName { get; set; }

        [StringLength(50)]
        public string LastFllowTime { get; set; }

        [StringLength(50)]
        public string Source { get; set; }

        [StringLength(250)]
        public string Note { get; set; }
    }
}
