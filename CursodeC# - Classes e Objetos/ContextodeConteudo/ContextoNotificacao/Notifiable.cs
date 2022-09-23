namespace CursodeCsharp.ContextoNotiicacao
{
    public abstract class Notifiable
    {
        public Notifiable()
        {
            Notificacoes = new List<Notificacao>();
        }
        public List<Notificacao> Notificacoes { get; set; }
        public void AddNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AddNotificacoes(IEnumerable<Notificacao> notificacao)
        {
            Notificacoes.AddRange(notificacao);
        }
        public bool IsInvalido => Notificacoes.Any();
    }
}