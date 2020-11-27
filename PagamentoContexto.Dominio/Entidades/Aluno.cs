using System.Collections.Generic;

namespace PagamentoContexto.Dominio.Entidades
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public List<Assinatura> Assinaturas { get; set; }
        public string Endereco { get; private set; }
    }
}
