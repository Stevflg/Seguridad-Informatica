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
    public class RolConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
                builder.HasKey(e => e.Id).HasName("PK__Roles__3214EC274944B42F");
                builder.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
                builder.HasIndex(e => e.Rol).IsUnique();
                builder.Property(e => e.FechaActualizacion).HasColumnType("datetime");
                builder.Property(e => e.FechaRegistro).HasColumnType("datetime");
                builder.Property(e => e.Rol)
                    .HasMaxLength(50)
                    .IsUnicode(false);
        }
    }
}
