using RepositorioObligatorio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;



namespace RepositorioObligatorio
{
    public class ObligatorioContext:DbContext
    {

        public ObligatorioContext() : base()
        {

        }

        //public DbSet<Proyecto> Proyectos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        //public DbSet<Inversor> Inversores { get; set; }

        //public DbSet<Solicitante> Solicitantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
