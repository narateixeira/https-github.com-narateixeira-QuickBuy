using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades.Enumerados
{
    public enum TipoFormaPagtoEnum
    {
        NaoDefinido = 0,
        Boleto = 1,
        CartaoCredito = 2,
        CartaoDebito = 3,
        Pix = 4,
        Transferencia = 5
    }
}
