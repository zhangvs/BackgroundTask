namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelphoneData")]
    public partial class TelphoneData
    {
        public int ID { get; set; }

        [StringLength(7)]
        public string Number7 { get; set; }

        [StringLength(20)]
        public string ProvinceId { get; set; }

        [StringLength(20)]
        public string Province { get; set; }

        [StringLength(20)]
        public string CityId { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string Operate { get; set; }

        [StringLength(10)]
        public string Areacode { get; set; }

        [StringLength(10)]
        public string Zipcode { get; set; }

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
