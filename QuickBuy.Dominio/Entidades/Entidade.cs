using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List <string> _mensagensValidacao { get; set; }

        private List<string> mensagensValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMenssagensValidacao()
        {
            mensagensValidacao.Clear();
        }

        protected void AdicionaCritica(string messagem)
        {
            mensagensValidacao.Add(messagem);
        }

        

        public abstract void Validate();

        protected bool EhValidado
        {
            get { return !mensagensValidacao.Any(); }
        }
    }
}
