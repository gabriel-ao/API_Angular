﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        //public override void Validade()
        //{
        //    if (string.IsNullOrEmpty(Nome))
        //    {
        //        AdicionarCritica("Precisa de um nome");
        //    }

        //    // verificar o do preco 
        //}
    }
}
