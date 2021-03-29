using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }

        protected List<string> MensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        protected void LimparMensagemValidacao()
        {

            MensagemValidacao.Clear();
        }


        protected void MensagemErro(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();

        public bool Valido
        {

            get { return (!MensagemValidacao.Any()); }
        }
       
    }
}