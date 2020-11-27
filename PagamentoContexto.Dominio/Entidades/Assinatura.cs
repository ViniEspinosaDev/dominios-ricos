using System;
using System.Collections.Generic;

namespace PagamentoContexto.Dominio.Entidades
{
    public class Assinatura
    {
        public DateTime Criacao { get; private set; }
        public DateTime? ValidoAte { get; private set; }
        public DateTime UltimaAtualizacao { get; private set; }
        public bool Ativo { get; private set; }
        public List<Pagamento> Pagamentos { get; private set; }
    }
}
