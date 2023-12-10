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
    public class RolUsuarioConfig : IEntityTypeConfiguration<RolUsuario>
    {
        public void Configure(EntityTypeBuilder<RolUsuario> builder)
        {
                builder.HasKey(e => e.Id).HasName("PK__RolUsuar__3214EC270437CA4A");
                builder.Property(e => e.Id).ValueGeneratedOnAdd();

                builder.ToTable("RolUsuario");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.FechaActualizacion).HasColumnType("datetime");
                builder.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
                builder.Property(e => e.Activo).HasDefaultValue(true);

                builder.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolUsuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__RolUsuari__IdRol__2C3393D0");

                builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RolUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__RolUsuari__IdUsu__2D27B809");
        }
    }
}
