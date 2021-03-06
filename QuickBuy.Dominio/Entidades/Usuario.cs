
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
   public class Usuario: Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string SobreNome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                MensagemErro("Email não informado.");

            if (string.IsNullOrEmpty(Senha))
                MensagemErro("Senha não informado.");
        }
    }
}
