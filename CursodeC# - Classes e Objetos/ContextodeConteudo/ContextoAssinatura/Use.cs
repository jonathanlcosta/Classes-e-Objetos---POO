using CursodeCsharp.SharedContext;

namespace CursodeCsharp.ContextoAssinatura
{
    public class Usuario: Base
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}