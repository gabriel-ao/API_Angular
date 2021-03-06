﻿using QuickBuy.Domain.Enum;
using QuickBuy.Domain.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Produto Produtos { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public string NumeroEndereco { get; set; }

        public TipoFormaPagamentoEnum FormaPagamento { get; set; }

        public int FormaPagamentoId { get; set; }

        public virtual ICollection<Produto> ItensPedido { get; set; }

        //public override void Validade()
        //{
        //    LimparMensagensValidacao();

        //    if (!ItensPedido.Any())
        //    {
        //        AdicionarCritica("Critica - Item de pedido não pode ficare Vazio");
                
        //    }
        //    if (string.IsNullOrEmpty(CEP))
        //        AdicionarCritica("Critica - CEP deve estar preenchido" );
        //}
    }
}
