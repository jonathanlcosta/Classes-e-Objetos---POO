namespace CursodeCsharp.ContextodeConteudo
{
    public class Carreira: Conteudo
    {
        public Carreira(string titulo, string url)
        : base(titulo,url)
        {
            Items = new List<ItemCarreira>();
        }
        public IList<ItemCarreira> Items  { get; set; }
        public int CursosTotal => Items.Count;
        
    }
    
}