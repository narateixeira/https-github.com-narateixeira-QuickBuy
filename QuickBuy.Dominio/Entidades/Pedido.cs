using QuickBuy.Dominio.Entidades.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido: Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagtoId { get; set; }
        public FormaPagamento FormaPagto { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
             LimparMensagemValidacao();


            if (!ItensPedido.Any())
                MensagemErro("Itens de Pedido não pode ficar vazio");

            if (string.IsNullOrEmpty(CEP))
                MensagemErro("o CEP deve esta preenchido");
        }
    }
}
