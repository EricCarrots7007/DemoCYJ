﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CYJ.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dorothyEntities : DbContext
    {
        public dorothyEntities()
            : base("name=dorothyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGOAL> AGOALs { get; set; }
        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<MASTER> MASTERs { get; set; }
        public virtual DbSet<POST> POSTs { get; set; }
        public virtual DbSet<QfourGOAL> QfourGOALs { get; set; }
        public virtual DbSet<QoneGOAL> QoneGOALs { get; set; }
        public virtual DbSet<QthreeGOAL> QthreeGOALs { get; set; }
        public virtual DbSet<QtwoGOAL> QtwoGOALs { get; set; }
        public virtual DbSet<SUBCATEGORY> SUBCATEGORies { get; set; }
        public virtual DbSet<TEAM> TEAMs { get; set; }
        public virtual DbSet<WSTREAM> WSTREAMs { get; set; }
    }
}