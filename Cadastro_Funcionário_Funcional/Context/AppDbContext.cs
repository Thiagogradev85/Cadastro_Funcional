using Cadastro_Funcionário_Funcional.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace Cadastro_Funcionário_Funcional.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
  : base(options)
    { 
    }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Endereco> Endereco { get; set; }
}

