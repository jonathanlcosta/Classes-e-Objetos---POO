using System;
using System.Linq;
using CursodeCsharp.ContextodeConteudo;
using CursodeCsharp.ContextoNotiicacao;
using CursodeCsharp.ContextoAssinatura;

namespace CursodeCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
           var artigos = new List<Artigo>();
           artigos.Add(new Artigo("Artigo sobre OPP", "orientacao-orientada-objetos"));
           artigos.Add(new Artigo("Artigo sobre C#","c#url"));
           artigos.Add(new Artigo("Artigo de Injeção de Dependencia", "injecao-dotnet"));
           foreach(var artigo in artigos){
               Console.WriteLine(artigo.Id);
               Console.WriteLine(artigo.Titulo);
               Console.WriteLine(artigo.Url);
           }
        var cursos = new List<Curso>();
        var cursoOOP = new Curso("Fundamentos OOP", "orientacao-objetos");
        var cursoCsharp = new Curso("Fundamentos c#", "csharp-dotnet");
        var cursoAspNet = new Curso("Asp.net", "asp-net");
        cursos.Add(cursoOOP);
        cursos.Add(cursoCsharp);
        cursos.Add(cursoAspNet);

        var carreiras = new List<Carreira>();
        var carreiraDotNet = new Carreira("Especialista .NET", "especialista-net");
        var itemcarreira1 = new ItemCarreira(1,"Comece por aqui", "", null);
        var itemcarreira2 = new ItemCarreira(3,"Aprenda .NET", "", null);
        var itemcarreira3 = new ItemCarreira(2,"Aprenda ASPNET", "", null);
        carreiraDotNet.Items.Add(itemcarreira1);
        carreiraDotNet.Items.Add(itemcarreira2);
        carreiraDotNet.Items.Add(itemcarreira3);
        carreiras.Add(carreiraDotNet);

        foreach(var carreira in carreiras)
        {
            Console.WriteLine(carreira.Titulo);
            foreach(var item in carreira.Items.OrderBy(x=>x.Ordem)){
                Console.WriteLine($"{item.Ordem} - {item.Titulo}");
                Console.WriteLine(item.Curso?.Titulo);
                Console.WriteLine(item.Curso?.Nivel);

                foreach(var notificacao in item.Notificacoes)
                {
                    Console.WriteLine($"{notificacao.Propriedade} - {notificacao.MensagemDeErro}");
                }
            }

            var payPalAssiantura = new PayPalAssinatura();
            var estudante = new Estudante();
            estudante.CriarAssinatura(payPalAssiantura);
        }
         

        }
    }
}

