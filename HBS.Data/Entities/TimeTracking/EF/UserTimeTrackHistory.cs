//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HBS.Data.Entities.TimeTracking.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTimeTrackHistory
    {
        public int TimeTrackId { get; set; }
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public string ClockInTime { get; set; }
        public string ClockOutTime { get; set; }
        public System.DateTime StampDate { get; set; }
        public string UserIP { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual aspnet_Users aspnet_Users { get; set; }
    }
}
