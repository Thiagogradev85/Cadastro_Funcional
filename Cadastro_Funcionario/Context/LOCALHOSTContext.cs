using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Cadastro_Funcionário_Funcional.Models;

namespace Cadastro_Funcionario.Context
{
    public partial class LOCALHOSTContext : DbContext
    {
        public LOCALHOSTContext()
        {
        }

        public LOCALHOSTContext(DbContextOptions<LOCALHOSTContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Cadastro_Funcionário_Funcional.Models.Funcionario>? Funcionario { get; set; }

        public DbSet<Cadastro_Funcionário_Funcional.Models.Endereco>? Endereco { get; set; }
    }
}
