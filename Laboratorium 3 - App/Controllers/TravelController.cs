using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3___App.Controllers
{
    public class TravelController : Controller
    {
        static Dictionary<int, Travel> _travels = new Dictionary<int, Travel>();
        static int id = 1;
        public IActionResult Index()
        {
            return View(_travels);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Travel model) 
        {
            if (ModelState.IsValid) 
            {
                model.Id = id++;
                _travels.Add(model.Id, model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_travels[id]);
        }

        [HttpPost]
        public IActionResult Update(Travel model)
        {
            if (ModelState.IsValid)
            {
                _travels[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_travels[id]);
        }

        [HttpPost]
        public IActionResult Delete(Travel model)
        {
            _travels.Remove(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_travels[id]);
        }
    }
}
