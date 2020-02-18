using BrasilCenter.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrasilCenter.Data.Mappings
{
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(keyExpression: p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Autor)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Capa)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Livros");
        }
    }
}
