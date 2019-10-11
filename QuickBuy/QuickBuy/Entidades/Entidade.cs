using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagens { get; set; }

        private List<string> mensagemValidacao
        {
            get { return _mensagens ?? (_mensagens = new List<string>()); }
        }
        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }


        public abstract void Validade();

        protected bool EhValido
        {
            get  { return mensagemValidacao.Any();  }
        }
    }
}
