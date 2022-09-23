namespace CursodeCsharp.ContextoNotiicacao
{
    public sealed class Notificacao
    {
        public Notificacao()
        {
            
        }

        public Notificacao(string? propriedade, string? mensagemDeErro)
        {
            Propriedade = propriedade;
            MensagemDeErro = mensagemDeErro;
        }

        public string? Propriedade { get; set; }
        public string? MensagemDeErro { get; set; }
    }
}