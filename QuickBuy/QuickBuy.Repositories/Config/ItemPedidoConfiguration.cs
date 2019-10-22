using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entidades;

namespace QuickBuy.Repositories.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Quantidade).IsRequired();

            builder.HasMany(i => i.Produtos).HasMany(i => i.Produto).HasForeignKey(i => i.UsuarioId);
        }
    }
}
