using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositories.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(usuario => usuario.Id );

            // padrao fluente
            builder.Property(usuario => usuario.Email).IsRequired().HasMaxLength(50);

            builder.Property(senha => senha.Senha).IsRequired().HasMaxLength(400);


            builder.Property(nome => nome.Nome).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");

            builder.Property(sobrenome => sobrenome.SobreNome).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");

            //builder.Property(pedido => pedido.Pedidos)
        }
    }
}
