namespace BackgroundTask.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRM_CallLog
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string EnterpriseId { get; set; }

        [StringLength(50)]
        public string WorkerUserName { get; set; }

        [StringLength(50)]
        public string WorkerName { get; set; }

        [StringLength(50)]
        public string WorkerGroupId { get; set; }

        [StringLength(50)]
        public string WorkerPhoneNumber { get; set; }

        public DateTime? UploadTime { get; set; }

        [StringLength(50)]
        public string WorkerIP { get; set; }

        public int? CallType { get; set; }

        [StringLength(50)]
        public string CallNumber { get; set; }

        public DateTime? CallTime { get; set; }

        public DateTime? RingTime { get; set; }

        public DateTime? ConnectedTime { get; set; }

        public DateTime? EndTime { get; set; }

        public int? CallResult { get; set; }

        public bool? IsRecordingFile { get; set; }

        [StringLength(250)]
        public string RecordingFile { get; set; }

        [StringLength(250)]
        public string LocalFileName { get; set; }

        public int? RecordingFileSize { get; set; }

        public int? RecordingType { get; set; }

        [StringLength(250)]
        public string HangReson { get; set; }

        public int? CallDuration { get; set; }

        public bool? IsRecordingFileUploaded { get; set; }

        public DateTime? RecordingUploadTime { get; set; }

        public bool? IsUploaded { get; set; }

        public bool? IsDone { get; set; }
    }
}
