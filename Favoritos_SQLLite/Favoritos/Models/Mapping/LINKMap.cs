using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Favoritos.Models.Mapping
{
    public class LINKMap : EntityTypeConfiguration<LINK>
    {
        public LINKMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.URL)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.DESCRICAO)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.CATEGORIA)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("LINKS");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.URL).HasColumnName("URL");
            this.Property(t => t.DESCRICAO).HasColumnName("DESCRICAO");
            this.Property(t => t.CATEGORIA).HasColumnName("CATEGORIA");
        }
    }
}
