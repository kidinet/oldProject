﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstSample
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BloggingContext : DbContext
    {
        public BloggingContext()
            : base("name=BloggingContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<about> abouts { get; set; }
        public virtual DbSet<AdministratorSetting> AdministratorSettings { get; set; }
        public virtual DbSet<chatItem> chatItems { get; set; }
        public virtual DbSet<formDilemma> formDilemmas { get; set; }
        public virtual DbSet<formResponse> formResponses { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<imageGallery> imageGalleries { get; set; }
        public virtual DbSet<reminder> reminders { get; set; }
        public virtual DbSet<thisWeekTitle> thisWeekTitles { get; set; }
        public virtual DbSet<topMessage> topMessages { get; set; }
        public virtual DbSet<UserInGroup> UserInGroups { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<responseImage> responseImages { get; set; }
        public virtual DbSet<LikeImage> LikeImages1 { get; set; }
    }
}
