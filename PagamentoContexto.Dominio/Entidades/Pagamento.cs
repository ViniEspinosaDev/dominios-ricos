using System;

namespace PagamentoContexto.Dominio.Entidades
{
    public abstract class Pagamento
    {
        public int Numero { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public string Proprietario { get; private set; }
        public string Documento { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }
    }


    public class BoletoPagamento : Pagamento
    {
        public string BoletoNumero { get; private set; }
        public string CodigoBarras { get; private set; }
    }


    public class CartaoCreditoPagamento : Pagamento
    {
        public string NomeTitular { get; private set; }
        public string NumeroCartao { get; private set; }
        public string NumeroUltimaTransacao { get; private set; }
    }

    public class PayPalPagamento : Pagamento
    {
        public string CodigoTransacao { get; private set; }
    }
}
