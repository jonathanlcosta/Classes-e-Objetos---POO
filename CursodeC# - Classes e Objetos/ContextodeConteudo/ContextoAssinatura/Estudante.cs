using CursodeCsharp.ContextoNotiicacao;
using CursodeCsharp.SharedContext;

namespace CursodeCsharp.ContextoAssinatura
{
    public class Estudante: Base
    {
        public Estudante()
        {
            Assinaturas = new List<Assinatura>();
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }
        public IList<Assinatura> Assinaturas { get; set; }

        public void CriarAssinatura(Assinatura assinatura){
            if(IsPremium){
                AddNotificacao(new Notificacao("Premium", "O aluno já tem uma assinatura ativa!"));
                return;
            }

            Assinaturas.Add(assinatura);
        }
        public bool IsPremium => Assinaturas.Any(x=> !x.IsInativo);
    }
}