
using ModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ModeloDDD.Infra.Data.EntityConfig
{
    public class ProdutosConfiguration : EntityTypeConfiguration<Produtos>
    {

        public ProdutosConfiguration()
        {

            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);


            Property(p => p.Valor)
                .IsRequired();


            //Referencia
            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
