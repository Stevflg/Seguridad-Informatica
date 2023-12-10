using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuraciones
{
    public class PermisoConfig : IEntityTypeConfiguration<Permiso>
    {
        public void Configure(EntityTypeBuilder<Permiso> builder)
        {
                builder.HasKey(e => e.Id).HasName("PK__Permisos__3214EC276117E573");
                builder.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
                builder.HasIndex(e => e.Permiso1).IsUnique();
                builder.Property(e => e.FechaActualizacion).HasColumnType("datetime");
                builder.Property(e => e.FechaRegistro).HasColumnType("datetime");
                builder.Property(e => e.Permiso1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Permiso");
        }
    }
}
