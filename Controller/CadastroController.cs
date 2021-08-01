using ListaLeitura.App.Models;
using ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ListaLeitura.App.Controller
{
    public class CadastroController
    {
        public string Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);

            return "O livro foi adicionado com sucesso.";
        }
        public IActionResult ExibeFormulario()
        {
            //var html = HTMLUtils.CarregaArquivoHTML("Formulario");
            var html = new ViewResult { ViewName = "formulario" };
            return html;
        }
    }
}
