﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entidades
{
    public class ItemPedido : Entidade
    {

        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public int Quantidade { get; set; }
        public virtual Pedido Pedidos { get; set; }


        //public override void Validade()
        //{
        //    if(ProdutoId == 0)
        //    {
        //        AdicionarCritica("Não foi identificado qual a referencia");
        //    }

        //    if(Quantidade == 0){
        //        AdicionarCritica("Quantidade não foi informada");
        //    }

        //}
    }
}
