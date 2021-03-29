using QuickBuy.Dominio.Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool NaoDefinido
        {

            get { return Id == (int)TipoFormaPagtoEnum.NaoDefinido; }

        }

        public bool Boleto 
            {

                get { return Id == (int)TipoFormaPagtoEnum.Boleto; }
        
            }

        public bool CartaoCredito
        {

            get { return Id == (int)TipoFormaPagtoEnum.CartaoCredito; }

        }

        public bool CartaoDebito
        {

            get { return Id == (int)TipoFormaPagtoEnum.CartaoDebito; }

        }

        public bool Pix
        {

            get { return Id == (int)TipoFormaPagtoEnum.Pix; }

        }

        public bool Transferencia
        {

            get { return Id == (int)TipoFormaPagtoEnum.Transferencia; }

        }
    }
}
