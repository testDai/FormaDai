﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormaDai
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BdFormaContainer : DbContext
    {
        public BdFormaContainer()
            : base("name=BdFormaContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Personne> Personne { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<Formation> Formation { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<Seance> Seance { get; set; }
        public virtual DbSet<Formateur> Formateur { get; set; }
        public virtual DbSet<Evaluation> Evaluation { get; set; }
        public virtual DbSet<Projet> Projet { get; set; }
        public virtual DbSet<Equipe> Equipe { get; set; }
    }
}
