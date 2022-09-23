using CursodeCsharp.SharedContext;

namespace CursodeCsharp.ContextodeConteudo
{
    public class Aula: Base
    {
        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
    }
}

    