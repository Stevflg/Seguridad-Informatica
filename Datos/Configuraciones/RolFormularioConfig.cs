using Dominio.Entidades;
using Microsoft.Data.SqlClient;
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
    public class RolFormularioConfig : IEntityTypeConfiguration<RolFormulario>
    {
        public void Configure(EntityTypeBuilder<RolFormulario> builder)
        {
                builder.HasKey(e => e.Id).HasName("PK__RolFormu__3214EC27322700AE");
                builder.Property(e => e.Id).ValueGeneratedOnAdd();

                builder.ToTable("RolFormulario");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.FechaActualizacion).HasColumnType("datetime");
                builder.Property(e => e.FechaRegistro).HasColumnType("datetime");

                builder.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.RolFormularios)
                    .HasForeignKey(d => d.IdFormulario)
                    .HasConstraintName("FK__RolFormul__IdFor__36B12243");

                builder.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolFormularios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__RolFormul__IdRol__35BCFE0A");
        }
    }
}
