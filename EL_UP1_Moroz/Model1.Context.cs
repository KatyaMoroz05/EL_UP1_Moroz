﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EL_UP1_Moroz
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        private static Entities _instance;
        public Entities()
            : base("name=Entities")
        {
        }

        public static Entities GetContext()
        {
            if (_instance == null)
            {
                _instance = new Entities();
            }
            return _instance;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Priorities> Priorities { get; set; }
        public virtual DbSet<Problems> Problems { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<ReportsAndMaterials> ReportsAndMaterials { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
    }
}
