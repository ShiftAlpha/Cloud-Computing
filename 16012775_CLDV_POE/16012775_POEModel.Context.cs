﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _16012775_CLDV_POE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DomingoRoofWorks_16012775_POEEntities : DbContext
    {
        public DomingoRoofWorks_16012775_POEEntities()
            : base("name=DomingoRoofWorks_16012775_POEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CUST> CUSTs { get; set; }
        public virtual DbSet<EMP> EMPS { get; set; }
        public virtual DbSet<EMPS_JOBS> EMPS_JOBS { get; set; }
        public virtual DbSet<INVOICE> INVOICEs { get; set; }
        public virtual DbSet<JOB_TYPES> JOB_TYPES { get; set; }
        public virtual DbSet<JOB> JOBS { get; set; }
        public virtual DbSet<MATERIAL> MATERIALS { get; set; }
        public virtual DbSet<MATERIALS_PER_PROJECT> MATERIALS_PER_PROJECT { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}
