namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_Organize
    {
        [Key]
        [StringLength(50)]
        public string OrganizeId { get; set; }

        public int? Category { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string EnCode { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string Nature { get; set; }

        [StringLength(50)]
        public string OuterPhone { get; set; }

        [StringLength(50)]
        public string InnerPhone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Postalcode { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string ManagerId { get; set; }

        [StringLength(50)]
        public string Manager { get; set; }

        [StringLength(50)]
        public string ProvinceId { get; set; }

        [StringLength(50)]
        public string CityId { get; set; }

        [StringLength(50)]
        public string CountyId { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(200)]
        public string WebAddress { get; set; }

        public DateTime? FoundedTime { get; set; }

        [StringLength(200)]
        public string BusinessScope { get; set; }

        public int? Layer { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public int? EnabledMark { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(200)]
        public string Img1 { get; set; }

        [StringLength(200)]
        public string Img2 { get; set; }

        [StringLength(200)]
        public string Img3 { get; set; }

        [StringLength(200)]
        public string Img4 { get; set; }

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

        public int? AgreementMark { get; set; }

        public DateTime? AgreementDate { get; set; }

        [StringLength(50)]
        public string TopOrganizeId { get; set; }

        [StringLength(50)]
        public string OtherOrganizeId { get; set; }

        public int? VipMark { get; set; }
    }
}
