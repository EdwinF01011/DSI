﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSI.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DSIEntities1 : DbContext
    {
        public DSIEntities1()
            : base("name=DSIEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<contacto> contacto { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<Etapas> Etapas { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Progreso> Progreso { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<sector> sector { get; set; }
        public virtual DbSet<Tipo_Estado> Tipo_Estado { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
