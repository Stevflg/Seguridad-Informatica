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
    public class FormularioConfig : IEntityTypeConfiguration<Formulario>
    {
        public void Configure(EntityTypeBuilder<Formulario> builder)
        {
                builder.HasKey(e => e.Id).HasName("PK__Formular__3214EC27481572BB");
                builder.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
                builder.Property(e => e.FechaActualizacion).HasColumnType("datetime");
                builder.Property(e => e.FechaRegistro).HasColumnType("datetime");
                builder.Property(e => e.Formulario1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Formulario");
        }
    }
}
