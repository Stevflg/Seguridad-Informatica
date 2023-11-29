using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace Datos.Context;

public partial class SeguridadInformaticaContext : DbContext
{
    public SeguridadInformaticaContext()
    {
    }

    public SeguridadInformaticaContext(DbContextOptions<SeguridadInformaticaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Formulario> Formularios { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<RolFormulario> RolFormularios { get; set; }

    public virtual DbSet<RolPermiso> RolPermisos { get; set; }

    public virtual DbSet<RolUsuario> RolUsuarios { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString,b => b.MigrationsAssembly("Datos"));
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {    
        OnModelCreatingPartial(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
