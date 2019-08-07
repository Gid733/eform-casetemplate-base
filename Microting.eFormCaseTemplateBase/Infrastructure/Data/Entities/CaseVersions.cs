using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microting.eFormApi.BasePn.Infrastructure.Database.Base;

namespace Microting.eFormCaseTemplateBase.Infrastructure.Data.Entities
{
    public class CaseVersions : BaseEntity
    {
        
        public int? Status { get; set; }
        
        public DateTime? DoneAt { get; set; }

        public int? SiteId { get; set; }

        public int? UnitId { get; set; }

        public int? WorkerId { get; set; }
        
        public int? eFormId { get; set; }

        [StringLength(255)]
        public string Type { get; set; }
        
        public int CaseTemplateId { get; set; }
        
        public virtual CaseTemplates CaseTemplate { get; set; }
        
        public bool FetchedByTablet { get; set; }
        
        public DateTime FetchedByTabletAt { get; set; }
        
        public bool ReceiptRetrievedFromUser { get; set; }
        
        public DateTime ReceiptRetrievedFromUserAt { get; set; }
        
        [ForeignKey("Cases")]
        public int CaseId { get; set; }
    }
}