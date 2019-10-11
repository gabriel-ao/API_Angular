using QuickBuy.Domain.Entidades;
using QuickBuy.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositories
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositories();
            var produto = new Produto();
            var usuario = new Usuario();

            usuarioRepositorio.Adicionar(usuario);
        }

    }
}
