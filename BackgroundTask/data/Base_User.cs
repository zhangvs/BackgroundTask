namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Base_User
    {
        [Key]
        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string EnCode { get; set; }

        [StringLength(50)]
        public string Account { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Secretkey { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(200)]
        public string HeadIcon { get; set; }

        [StringLength(200)]
        public string QuickQuery { get; set; }

        [StringLength(200)]
        public string SimpleSpelling { get; set; }

        public int? Gender { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string OICQ { get; set; }

        [StringLength(50)]
        public string WeChat { get; set; }

        [StringLength(50)]
        public string MSN { get; set; }

        [StringLength(50)]
        public string ManagerId { get; set; }

        [StringLength(50)]
        public string Manager { get; set; }

        [StringLength(50)]
        public string OrganizeId { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        [StringLength(50)]
        public string RoleId { get; set; }

        [StringLength(50)]
        public string DutyId { get; set; }

        [StringLength(50)]
        public string DutyName { get; set; }

        [StringLength(50)]
        public string PostId { get; set; }

        [StringLength(50)]
        public string PostName { get; set; }

        [StringLength(50)]
        public string WorkGroupId { get; set; }

        public int? SecurityLevel { get; set; }

        public int? UserOnLine { get; set; }

        public int? OpenId { get; set; }

        [StringLength(50)]
        public string Question { get; set; }

        [StringLength(50)]
        public string AnswerQuestion { get; set; }

        public int? CheckOnLine { get; set; }

        public DateTime? AllowStartTime { get; set; }

        public DateTime? AllowEndTime { get; set; }

        public DateTime? LockStartDate { get; set; }

        public DateTime? LockEndDate { get; set; }

        public DateTime? FirstVisit { get; set; }

        public DateTime? PreviousVisit { get; set; }

        public DateTime? LastVisit { get; set; }

        public int? LogOnCount { get; set; }

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
