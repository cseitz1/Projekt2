﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pdfandmail
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Projekt2Entities : DbContext
    {
        public Projekt2Entities()
            : base("name=Projekt2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Kunde> Kunde { get; set; }
        public virtual DbSet<Rechnung> Rechnung { get; set; }
        public virtual DbSet<Fahrt> Fahrt { get; set; }
    }
}