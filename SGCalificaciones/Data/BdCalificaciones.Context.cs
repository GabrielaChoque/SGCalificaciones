﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGCalificaciones.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BdCalificacionesEntities : DbContext
    {
        public BdCalificacionesEntities()
            : base("name=BdCalificacionesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bimestre> Bimestre { get; set; }
        public virtual DbSet<Criterio> Criterio { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Materia_Curso> Materia_Curso { get; set; }
        public virtual DbSet<Plantel_Educativo> Plantel_Educativo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Calificaciones> Calificaciones { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
    }
}
