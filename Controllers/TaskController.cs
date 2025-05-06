using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using System.Collections.Generic;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        // Lista simulada (em breve, substituiremos por banco ou lista persistente)
        private static List<TaskModel> tasks = new();

        public IActionResult Index()
        {
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskModel task)
        {
            if (ModelState.IsValid)
            {
                task.Id = tasks.Count + 1;
                tasks.Add(task);
                return RedirectToAction("Index");
            }

            return View(task);
        }
    }
}
