using System;
using System.ComponentModel.DataAnnotations;
using Microting.eFormApi.BasePn.Infrastructure.Database.Base;

namespace Microting.eFormCaseTemplateBase.Infrastructure.Data.Entities
{
    public class UploadedDatas : BaseEntity
    {
        [StringLength(255)]
        public string Checksum { get; set; }
        
        [StringLength(255)]
        public string Extension { get; set; }

        [StringLength(255)]
        public string CurrentFile { get; set; }

        [StringLength(255)]
        public string UploaderType { get; set; }

        [StringLength(255)]
        public string FileLocation { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public short? Local { get; set; }
        
        public string OriginalFileName { get; set; }
        
    }
}