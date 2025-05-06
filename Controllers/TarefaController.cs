using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using System.Linq;

namespace TaskManager.Controllers
{
    public class TarefaController : Controller
    {
        private static List<TarefaModel> tarefas = new List<TarefaModel>();

        // Ação para exibir todas as tarefas
        public IActionResult Index()
        {
            return View(tarefas);
        }

        // Ação para criar uma nova tarefa
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(TarefaModel tarefa)
        {
            if (ModelState.IsValid)
            {
                tarefa.Id = tarefas.Count + 1;  // Atribui um ID único
                tarefas.Add(tarefa);
                return RedirectToAction("Index");
            }
            return View(tarefa);
        }

        // Ação para editar uma tarefa
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa == null)
            {
                return NotFound();
            }
            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Editar(TarefaModel tarefa)
        {
            if (ModelState.IsValid)
            {
                var tarefaExistente = tarefas.FirstOrDefault(t => t.Id == tarefa.Id);
                if (tarefaExistente != null)
                {
                    tarefaExistente.Nome = tarefa.Nome;
                    tarefaExistente.Descricao = tarefa.Descricao;
                    tarefaExistente.Concluida = tarefa.Concluida;  // Atualiza o status de concluída
                }
                return RedirectToAction("Index");
            }
            return View(tarefa);
        }

        // Ação para excluir uma tarefa
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa == null)
            {
                return NotFound();
            }
            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Excluir(TarefaModel tarefa)
        {
            var tarefaExistente = tarefas.FirstOrDefault(t => t.Id == tarefa.Id);
            if (tarefaExistente != null)
            {
                tarefas.Remove(tarefaExistente);
            }
            return RedirectToAction("Index");
        }
    }
}
