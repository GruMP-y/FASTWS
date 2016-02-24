﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FASTWSv1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FASTDBLogEntities : DbContext
    {
        public FASTDBLogEntities()
            : base("name=FASTDBLogEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AuditTrail> AuditTrails { get; set; }
    
        public virtual int InsertToAuditTrail(Nullable<int> employeeID, string action, string extraInfo)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            var actionParameter = action != null ?
                new ObjectParameter("action", action) :
                new ObjectParameter("action", typeof(string));
    
            var extraInfoParameter = extraInfo != null ?
                new ObjectParameter("extraInfo", extraInfo) :
                new ObjectParameter("extraInfo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertToAuditTrail", employeeIDParameter, actionParameter, extraInfoParameter);
        }
    }
}