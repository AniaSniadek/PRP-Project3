﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_bazodanowy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseBasketballEntities : DbContext
    {
        public DatabaseBasketballEntities()
            : base("name=DatabaseBasketballEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Zespol> Zespol { get; set; }
        public DbSet<Prezes> Prezes { get; set; }
        public DbSet<Trener> Trener { get; set; }
        public DbSet<Hala> Hala { get; set; }
        public DbSet<Zawodnik> Zawodnik { get; set; }
    }
}