﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBInventarioCRUD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class INTECEntities : DbContext
    {
        public INTECEntities()
            : base("name=INTECEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientType> ClientType { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<License> License { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Restriction> Restriction { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserPermissions> UserPermissions { get; set; }
        public virtual DbSet<UserRestrictions> UserRestrictions { get; set; }
    }
}