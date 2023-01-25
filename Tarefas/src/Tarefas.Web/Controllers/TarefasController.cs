namespace Tarefas.Web.Controllers;

public class TarefasController : Controller
{
    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Index()
    {
        var listaDeTarefas = new List<TarefaViewModel>(){
            new TarefaViewModel () {Titulo = "Escovar os dentes", Descricao = "Usar Sensodine de manhã e não a noite"},
            new TarefaViewModel () {Titulo = "Arrumar a cama"},
            new TarefaViewModel () {Titulo = "Por o lixo para fora", Descricao = "somente às terças"},
        };
        return View(listaDeTarefas);
    }
}
