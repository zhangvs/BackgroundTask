namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TelphoneCertification0
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string mobileNumber { get; set; }

        [StringLength(50)]
        public string custTelphone { get; set; }

        [StringLength(50)]
        public string custName { get; set; }

        [StringLength(50)]
        public string custCertCode { get; set; }

        [StringLength(50)]
        public string custCertDate { get; set; }

        [StringLength(350)]
        public string custCertAddress { get; set; }

        [StringLength(250)]
        public string photo_z { get; set; }

        [StringLength(250)]
        public string photo_b { get; set; }

        [StringLength(250)]
        public string photo_s { get; set; }

        public int? loadMark { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        public int? loadCount { get; set; }

        public DateTime? createTime { get; set; }

        public DateTime? modifyTime { get; set; }
    }
}
