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
    public class RolPermisoConfig : IEntityTypeConfiguration<RolPermiso>
    {
        public void Configure(EntityTypeBuilder<RolPermiso> builder)
        {
                builder.HasKey(e => e.Id).HasName("PK__RolPermi__3214EC275B79F6A2");

                builder.ToTable("RolPermiso");

                builder.Property(e => e.Id).HasColumnName("ID")
                .ValueGeneratedOnAdd();
                builder.Property(e => e.FechaActualizacion).HasColumnType("datetime");
                builder.Property(e => e.FechaRegistro).HasColumnType("datetime");

                builder.HasOne(d => d.IdPermisoNavigation).WithMany(p => p.RolPermisos)
                    .HasForeignKey(d => d.IdPermiso)
                    .HasConstraintName("FK__RolPermis__IdPer__30F848ED");

                builder.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolPermisos)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__RolPermis__IdRol__300424B4");
        }
    }
}