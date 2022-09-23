using CursodeCsharp.SharedContext;

namespace CursodeCsharp.ContextoAssinatura
{
    public class Assinatura: Base
    {
        public Plano Plano { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool IsInativo => DataFinal <= DateTime.Now;
    }
}