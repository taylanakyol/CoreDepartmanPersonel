using CoreDepartmanPersonel.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartmanPersonel.Controllers
{
    public class departController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.departmanlars.ToList();
            return View(degerler);
        }


        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {
            c.departmanlars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult DepartmanSil(int id)
        {
            var dep = c.departmanlars.Find(id);
            c.departmanlars.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.departmanlars.Find(id);
            return View("DepartmanGetir", depart);

        }

        public IActionResult DepartmanGuncelle(departmanlar d)
        {
            var dep = c.departmanlars.Find(d.departid);
            dep.departmanad = d.departmanad;
            c.SaveChanges();
            return RedirectToAction("Index", "depart");

        }
    }
}
