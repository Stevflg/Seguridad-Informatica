using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuraciones
{
    public class UsuariosConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {         
                builder.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC27A61A16C9");
                
                builder.Property(e => e.Id).HasColumnName("ID")
                .ValueGeneratedOnAdd();
                builder.HasIndex(e => e.Login).IsUnique();
                builder.Property(e => e.CambiarPassword).HasDefaultValueSql("((0))");
                builder.Property(e => e.Correo)
                    .HasMaxLength(200)
                    .IsUnicode(false);
                builder.Property(e => e.FechaActualizacion).HasColumnType("datetime");
                builder.Property(e => e.FechaRegistro).HasColumnType("datetime");
                builder.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                builder.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);
        }
    }
}
