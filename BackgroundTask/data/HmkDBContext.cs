namespace BackgroundTask.data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HmkDBContext : DbContext
    {
        public HmkDBContext()
            : base("name=HmkDBContext")
        {
        }

        public virtual DbSet<Base_Area> Base_Area { get; set; }
        public virtual DbSet<Base_Authorize> Base_Authorize { get; set; }
        public virtual DbSet<Base_AuthorizeData> Base_AuthorizeData { get; set; }
        public virtual DbSet<Base_CodeRule> Base_CodeRule { get; set; }
        public virtual DbSet<Base_CodeRuleSeed> Base_CodeRuleSeed { get; set; }
        public virtual DbSet<Base_DatabaseBackup> Base_DatabaseBackup { get; set; }
        public virtual DbSet<Base_DatabaseLink> Base_DatabaseLink { get; set; }
        public virtual DbSet<Base_DataItem> Base_DataItem { get; set; }
        public virtual DbSet<Base_DataItemDetail> Base_DataItemDetail { get; set; }
        public virtual DbSet<Base_Department> Base_Department { get; set; }
        public virtual DbSet<Base_FileFolder> Base_FileFolder { get; set; }
        public virtual DbSet<Base_FileInfo> Base_FileInfo { get; set; }
        public virtual DbSet<Base_FilterIP> Base_FilterIP { get; set; }
        public virtual DbSet<Base_FilterTime> Base_FilterTime { get; set; }
        public virtual DbSet<Base_Log> Base_Log { get; set; }
        public virtual DbSet<Base_Module> Base_Module { get; set; }
        public virtual DbSet<Base_ModuleButton> Base_ModuleButton { get; set; }
        public virtual DbSet<Base_ModuleColumn> Base_ModuleColumn { get; set; }
        public virtual DbSet<Base_ModuleForm> Base_ModuleForm { get; set; }
        public virtual DbSet<Base_ModuleFormInstance> Base_ModuleFormInstance { get; set; }
        public virtual DbSet<Base_News> Base_News { get; set; }
        public virtual DbSet<Base_Organize> Base_Organize { get; set; }
        public virtual DbSet<Base_Role> Base_Role { get; set; }
        public virtual DbSet<Base_Schedule> Base_Schedule { get; set; }
        public virtual DbSet<Base_User> Base_User { get; set; }
        public virtual DbSet<Base_UserRelation> Base_UserRelation { get; set; }
        public virtual DbSet<Client_CashBalance> Client_CashBalance { get; set; }
        public virtual DbSet<Client_Chance> Client_Chance { get; set; }
        public virtual DbSet<Client_Customer> Client_Customer { get; set; }
        public virtual DbSet<Client_CustomerContact> Client_CustomerContact { get; set; }
        public virtual DbSet<Client_Expenses> Client_Expenses { get; set; }
        public virtual DbSet<Client_Invoice> Client_Invoice { get; set; }
        public virtual DbSet<Client_Order> Client_Order { get; set; }
        public virtual DbSet<Client_OrderEntry> Client_OrderEntry { get; set; }
        public virtual DbSet<Client_Receivable> Client_Receivable { get; set; }
        public virtual DbSet<Client_TrailRecord> Client_TrailRecord { get; set; }
        public virtual DbSet<CRM_CallLog> CRM_CallLog { get; set; }
        public virtual DbSet<CRM_Customer> CRM_Customer { get; set; }
        public virtual DbSet<CRM_FollowUpRecords> CRM_FollowUpRecords { get; set; }
        public virtual DbSet<CustomerLocation> CustomerLocation { get; set; }
        public virtual DbSet<Email_Addressee> Email_Addressee { get; set; }
        public virtual DbSet<Email_Category> Email_Category { get; set; }
        public virtual DbSet<Email_Content> Email_Content { get; set; }
        public virtual DbSet<IM_Content> IM_Content { get; set; }
        public virtual DbSet<IM_Group> IM_Group { get; set; }
        public virtual DbSet<IM_Read> IM_Read { get; set; }
        public virtual DbSet<IM_UserGroup> IM_UserGroup { get; set; }
        public virtual DbSet<Rpt_Temp> Rpt_Temp { get; set; }
        public virtual DbSet<SmsInfo> SmsInfo { get; set; }
        public virtual DbSet<TelphoneCertification> TelphoneCertification { get; set; }
        public virtual DbSet<TelphoneCertification0> TelphoneCertification0 { get; set; }
        public virtual DbSet<TelphoneData> TelphoneData { get; set; }
        public virtual DbSet<TelphoneLiang> TelphoneLiang { get; set; }
        public virtual DbSet<TelphoneLiangBak721> TelphoneLiangBak721 { get; set; }
        public virtual DbSet<TelphoneLiangJoin> TelphoneLiangJoin { get; set; }
        public virtual DbSet<TelphoneLiangOther> TelphoneLiangOther { get; set; }
        public virtual DbSet<TelphoneLiangSee> TelphoneLiangSee { get; set; }
        public virtual DbSet<TelphoneLiangShare> TelphoneLiangShare { get; set; }
        public virtual DbSet<TelphoneLiangVip> TelphoneLiangVip { get; set; }
        public virtual DbSet<TelphoneLiOrder> TelphoneLiOrder { get; set; }
        public virtual DbSet<TelphonePu> TelphonePu { get; set; }
        public virtual DbSet<TelphoneReserver> TelphoneReserver { get; set; }
        public virtual DbSet<TelphoneReserveSearch> TelphoneReserveSearch { get; set; }
        public virtual DbSet<TelphoneReserveSee> TelphoneReserveSee { get; set; }
        public virtual DbSet<TelphoneSendout> TelphoneSendout { get; set; }
        public virtual DbSet<TelphoneSource> TelphoneSource { get; set; }
        public virtual DbSet<TelphoneSource_copy> TelphoneSource_copy { get; set; }
        public virtual DbSet<TelphoneWash> TelphoneWash { get; set; }
        public virtual DbSet<TelphoneXi> TelphoneXi { get; set; }
        public virtual DbSet<TelphoneXiNo> TelphoneXiNo { get; set; }
        public virtual DbSet<WanHao> WanHao { get; set; }
        public virtual DbSet<WeChat_App> WeChat_App { get; set; }
        public virtual DbSet<WeChat_DeptRelation> WeChat_DeptRelation { get; set; }
        public virtual DbSet<WeChat_UserRelation> WeChat_UserRelation { get; set; }
        public virtual DbSet<WF_DelegateRecord> WF_DelegateRecord { get; set; }
        public virtual DbSet<WF_DelegateRule> WF_DelegateRule { get; set; }
        public virtual DbSet<WF_DelegateRuleSchemeInfo> WF_DelegateRuleSchemeInfo { get; set; }
        public virtual DbSet<WF_FrmMain> WF_FrmMain { get; set; }
        public virtual DbSet<WF_ProcessInstance> WF_ProcessInstance { get; set; }
        public virtual DbSet<WF_ProcessOperationHistory> WF_ProcessOperationHistory { get; set; }
        public virtual DbSet<WF_ProcessScheme> WF_ProcessScheme { get; set; }
        public virtual DbSet<WF_ProcessTransitionHistory> WF_ProcessTransitionHistory { get; set; }
        public virtual DbSet<WF_SchemeContent> WF_SchemeContent { get; set; }
        public virtual DbSet<WF_SchemeInfo> WF_SchemeInfo { get; set; }
        public virtual DbSet<WF_SchemeInfoAuthorize> WF_SchemeInfoAuthorize { get; set; }
        public virtual DbSet<TelphoneOrder> TelphoneOrder { get; set; }
        public virtual DbSet<TelphoneOrder0> TelphoneOrder0 { get; set; }
        public virtual DbSet<TelphoneSource_0> TelphoneSource_0 { get; set; }
        public virtual DbSet<TelphoneSource1> TelphoneSource1 { get; set; }
        public virtual DbSet<TestFlow_LeaveSlip> TestFlow_LeaveSlip { get; set; }
        public virtual DbSet<WanHao1> WanHao1 { get; set; }
        public virtual DbSet<WeChat_Users> WeChat_Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Base_Area>()
                .Property(e => e.AreaId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.QuickQuery)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.SimpleSpelling)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Area>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Authorize>()
                .Property(e => e.AuthorizeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Authorize>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Authorize>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Authorize>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Authorize>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_AuthorizeData>()
                .Property(e => e.AuthorizeDataId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_AuthorizeData>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_AuthorizeData>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_AuthorizeData>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_AuthorizeData>()
                .Property(e => e.ResourceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_AuthorizeData>()
                .Property(e => e.AuthorizeConstraint)
                .IsUnicode(false);

            modelBuilder.Entity<Base_AuthorizeData>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_AuthorizeData>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.RuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.Module)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CurrentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.RuleFormatJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSeed>()
                .Property(e => e.RuleSeedId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSeed>()
                .Property(e => e.RuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSeed>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSeed>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSeed>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSeed>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSeed>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.DatabaseBackupId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.DatabaseLinkId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.ExecuteTime)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.BackupPath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseBackup>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.DatabaseLinkId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.ServerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.DBName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.DBAlias)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.DbType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.DbConnection)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DatabaseLink>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItem>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItem>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItem>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItem>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItem>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItem>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItem>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItem>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.ItemDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.ItemValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.QuickQuery)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.SimpleSpelling)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataItemDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Nature)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ManagerId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.OuterPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.InnerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.FolderType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.FolderName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.ShareLink)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileFolder>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.FileId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.FileExtensions)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.ShareLink)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FileInfo>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterIP>()
                .Property(e => e.FilterIPId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterIP>()
                .Property(e => e.ObjectType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterIP>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterIP>()
                .Property(e => e.IPLimit)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterIP>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterIP>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterIP>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterIP>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterIP>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.FilterTimeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.ObjectType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.WeekDay1)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.WeekDay2)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.WeekDay3)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.WeekDay4)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.WeekDay5)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.WeekDay6)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.WeekDay7)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FilterTime>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.LogId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.SourceObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.SourceContentJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.OperateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.OperateAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.OperateTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.OperateType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.Module)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.IPAddressName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.Host)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.Browser)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.ExecuteResultJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Log>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.UrlAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleButton>()
                .Property(e => e.ModuleButtonId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleButton>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleButton>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleButton>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleButton>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleButton>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleButton>()
                .Property(e => e.ActionAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleColumn>()
                .Property(e => e.ModuleColumnId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleColumn>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleColumn>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleColumn>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleColumn>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleColumn>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.FormId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.FormJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleForm>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleFormInstance>()
                .Property(e => e.FormInstanceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleFormInstance>()
                .Property(e => e.FormId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleFormInstance>()
                .Property(e => e.FormInstanceJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleFormInstance>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModuleFormInstance>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.NewsId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.FullHead)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.FullHeadColor)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.BriefHead)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.AuthorName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.CompileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.TagWord)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.Keyword)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.SourceName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.SourceAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.NewsContent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_News>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Nature)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.OuterPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.InnerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Postalcode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.ManagerId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.ProvinceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.CityId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.CountyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.WebAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.BusinessScope)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Img1)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Img2)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Img3)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.Img4)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.TopOrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Organize>()
                .Property(e => e.OtherOrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Role>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Role>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Role>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Role>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Role>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Role>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Role>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Role>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Role>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.ScheduleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.ScheduleName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.ScheduleContent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.StartTime)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.EndTime)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Schedule>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Secretkey)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.HeadIcon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.QuickQuery)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.SimpleSpelling)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.OICQ)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.WeChat)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.MSN)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.ManagerId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.DutyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.DutyName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.PostId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.PostName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.WorkGroupId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AnswerQuestion)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserRelation>()
                .Property(e => e.UserRelationId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserRelation>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserRelation>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserRelation>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_UserRelation>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CashBalance>()
                .Property(e => e.CashBalanceId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CashBalance>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CashBalance>()
                .Property(e => e.CashAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CashBalance>()
                .Property(e => e.Abstract)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CashBalance>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CashBalance>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CashBalance>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CashBalance>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CashBalance>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.ChanceId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.SourceId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.StageId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.SuccessRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Profit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.ChanceTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.SaleCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.CompanyNatureId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.CompanyAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.CompanySite)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.CompanyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Contacts)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Wechat)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Hobby)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.TraceUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.TraceUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Chance>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CustIndustryId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CustTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CustLevelId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CustDegreeId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.Wechat)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.Hobby)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.LegalPerson)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CompanyAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CompanySite)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CompanyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.TraceUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.TraceUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Customer>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.CustomerContactId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.CustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.Wechat)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.PostId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.Hobby)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_CustomerContact>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.ExpensesId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.ExpensesAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.ExpensesType)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.ExpensesAbstract)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Expenses>()
                .Property(e => e.Managers)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.InvoiceId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.CustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.CustomerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.InvoiceContent)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Invoice>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.CustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.SellerId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.SellerName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.OrderCode)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.PaymentMode)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.AbstractInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.ContractCode)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.ContractFile)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Order>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_OrderEntry>()
                .Property(e => e.OrderEntryId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_OrderEntry>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_OrderEntry>()
                .Property(e => e.ProductId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_OrderEntry>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Client_OrderEntry>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_OrderEntry>()
                .Property(e => e.UnitId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_OrderEntry>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Receivable>()
                .Property(e => e.ReceivableId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Receivable>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Receivable>()
                .Property(e => e.PaymentMode)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Receivable>()
                .Property(e => e.PaymentAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Receivable>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Receivable>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Receivable>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Receivable>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Receivable>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_TrailRecord>()
                .Property(e => e.TrailId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_TrailRecord>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_TrailRecord>()
                .Property(e => e.TrackContent)
                .IsUnicode(false);

            modelBuilder.Entity<Client_TrailRecord>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client_TrailRecord>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_TrailRecord>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_TrailRecord>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Client_TrailRecord>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Client_TrailRecord>()
                .Property(e => e.TrackTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Addressee>()
                .Property(e => e.AddresseeId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Addressee>()
                .Property(e => e.ContentId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Addressee>()
                .Property(e => e.CategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Addressee>()
                .Property(e => e.RecipientId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Addressee>()
                .Property(e => e.RecipientName)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Addressee>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Addressee>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Addressee>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Addressee>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Category>()
                .Property(e => e.CategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Category>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Category>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Category>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Category>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Category>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.ContentId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.CategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.Theme)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.ThemeColor)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.EmailContent)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.SenderId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.SenderName)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.SendPriority)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.AddresssHtml)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.CopysendHtml)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.BccsendHtml)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Email_Content>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Content>()
                .Property(e => e.ContentId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Content>()
                .Property(e => e.SendId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Content>()
                .Property(e => e.ToId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Content>()
                .Property(e => e.MsgContent)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Content>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Content>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Group>()
                .Property(e => e.GroupId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Group>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Group>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Group>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Read>()
                .Property(e => e.ReadId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Read>()
                .Property(e => e.ContentId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Read>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Read>()
                .Property(e => e.SendId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Read>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Read>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_UserGroup>()
                .Property(e => e.UserGroupId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_UserGroup>()
                .Property(e => e.GroupId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_UserGroup>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_UserGroup>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<IM_UserGroup>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.TempId)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.EnCode)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.TempType)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.ParamJson)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Rpt_Temp>()
                .Property(e => e.TempCategory)
                .IsUnicode(false);

            modelBuilder.Entity<SmsInfo>()
                .Property(e => e.Tel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SmsInfo>()
                .Property(e => e.Captcha)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneCertification>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneCertification0>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneData>()
                .Property(e => e.Number7)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneData>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneData>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneData>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneData>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneData>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiang>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneLiang>()
                .Property(e => e.MinPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiang>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiang>()
                .Property(e => e.ChaPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiang>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiang>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiang>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiang>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiang>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangBak721>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneLiangBak721>()
                .Property(e => e.MinPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiangBak721>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiangBak721>()
                .Property(e => e.ChaPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiangBak721>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangBak721>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangBak721>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangBak721>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangBak721>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangJoin>()
                .Property(e => e.OpenId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangJoin>()
                .Property(e => e.HeadimgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangJoin>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangJoin>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.MinPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.ChaPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangOther>()
                .Property(e => e.CreateOrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangSee>()
                .Property(e => e.OrganizeId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangSee>()
                .Property(e => e.OpenId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangSee>()
                .Property(e => e.HeadimgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangShare>()
                .Property(e => e.OpenId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangShare>()
                .Property(e => e.HeadimgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangShare>()
                .Property(e => e.ShareUrl)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangVip>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangVip>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphoneLiangVip>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangVip>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangVip>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangVip>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiangVip>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiOrder>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneLiOrder>()
                .Property(e => e.Contact)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneLiOrder>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiOrder>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiOrder>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiOrder>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneLiOrder>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphonePu>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphonePu>()
                .Property(e => e.MinPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphonePu>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphonePu>()
                .Property(e => e.ChaPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TelphonePu>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphonePu>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphonePu>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphonePu>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphonePu>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneReserver>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneReserver>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSendout>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSendout>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSendout>()
                .Property(e => e.Grade)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSendout>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSendout>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSendout>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSendout>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSendout>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource>()
                .Property(e => e.Grade)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_copy>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource_copy>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource_copy>()
                .Property(e => e.Grade)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource_copy>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_copy>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_copy>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_copy>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_copy>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneWash>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneWash>()
                .Property(e => e.Grade)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneWash>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneWash>()
                .Property(e => e.CallDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneWash>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneWash>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneWash>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneWash>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneXi>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneXiNo>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<WanHao>()
                .Property(e => e.WanId)
                .IsFixedLength();

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.AppId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.AppLogo)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.AppName)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.AppUrl)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.RedirectDomain)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.MenuJson)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_App>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_DeptRelation>()
                .Property(e => e.DeptRelationId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_DeptRelation>()
                .Property(e => e.DeptId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_DeptRelation>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_DeptRelation>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_DeptRelation>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_UserRelation>()
                .Property(e => e.UserRelationId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_UserRelation>()
                .Property(e => e.DeptId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_UserRelation>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_UserRelation>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_UserRelation>()
                .Property(e => e.SyncState)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_UserRelation>()
                .Property(e => e.SyncLog)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_UserRelation>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_UserRelation>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRecord>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRecord>()
                .Property(e => e.WFDelegateRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRecord>()
                .Property(e => e.FromUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRecord>()
                .Property(e => e.FromUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRecord>()
                .Property(e => e.ToUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRecord>()
                .Property(e => e.ToUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRecord>()
                .Property(e => e.ProcessId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRecord>()
                .Property(e => e.ProcessCode)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRecord>()
                .Property(e => e.ProcessName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRule>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRule>()
                .Property(e => e.ToUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRule>()
                .Property(e => e.ToUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRule>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRule>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRule>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRuleSchemeInfo>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRuleSchemeInfo>()
                .Property(e => e.DelegateRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_DelegateRuleSchemeInfo>()
                .Property(e => e.SchemeInfoId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmCode)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmType)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmDbId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmTable)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmTableId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.FrmContent)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_FrmMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.CustomName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.ActivityId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.ActivityName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.PreviousId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.ProcessSchemeId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.SchemeType)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessInstance>()
                .Property(e => e.MakerList)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessOperationHistory>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessOperationHistory>()
                .Property(e => e.ProcessId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessOperationHistory>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessOperationHistory>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessOperationHistory>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessScheme>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessScheme>()
                .Property(e => e.SchemeContent)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessScheme>()
                .Property(e => e.WFSchemeInfoId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessScheme>()
                .Property(e => e.SchemeVersion)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessTransitionHistory>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessTransitionHistory>()
                .Property(e => e.ProcessId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessTransitionHistory>()
                .Property(e => e.fromNodeId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessTransitionHistory>()
                .Property(e => e.fromNodeName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessTransitionHistory>()
                .Property(e => e.toNodeId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessTransitionHistory>()
                .Property(e => e.toNodeName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessTransitionHistory>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_ProcessTransitionHistory>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeContent>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeContent>()
                .Property(e => e.WFSchemeInfoId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeContent>()
                .Property(e => e.SchemeVersion)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeContent>()
                .Property(e => e.SchemeContent)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeContent>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeContent>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.SchemeCode)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.SchemeName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.SchemeType)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.SchemeVersion)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.SchemeCanUser)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfo>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfoAuthorize>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfoAuthorize>()
                .Property(e => e.SchemeInfoId)
                .IsUnicode(false);

            modelBuilder.Entity<WF_SchemeInfoAuthorize>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.Contact)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.Pro)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.Contact)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.Pro)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneOrder0>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_0>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource_0>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource_0>()
                .Property(e => e.Grade)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource_0>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_0>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_0>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_0>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource_0>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource1>()
                .Property(e => e.Telphone)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource1>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource1>()
                .Property(e => e.Grade)
                .IsFixedLength();

            modelBuilder.Entity<TelphoneSource1>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource1>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource1>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource1>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<TelphoneSource1>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<TestFlow_LeaveSlip>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<TestFlow_LeaveSlip>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<TestFlow_LeaveSlip>()
                .Property(e => e.begintime)
                .IsUnicode(false);

            modelBuilder.Entity<TestFlow_LeaveSlip>()
                .Property(e => e.endtime)
                .IsUnicode(false);

            modelBuilder.Entity<WanHao1>()
                .Property(e => e.WanId)
                .IsFixedLength();

            modelBuilder.Entity<WeChat_Users>()
                .Property(e => e.OpenId)
                .IsUnicode(false);

            modelBuilder.Entity<WeChat_Users>()
                .Property(e => e.HeadimgUrl)
                .IsUnicode(false);
        }
    }
}
