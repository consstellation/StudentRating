﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LegramEntities9 : DbContext
    {
        public LegramEntities9()
            : base("name=LegramEntities9")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmployeeAccessMode> EmployeeAccessModes { get; set; }
        public virtual DbSet<EmployeeAccount> EmployeeAccounts { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<JoinG> JoinGS { get; set; }
        public virtual DbSet<JoinL> JoinLS { get; set; }
        public virtual DbSet<JoinSG> JoinSGs { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}