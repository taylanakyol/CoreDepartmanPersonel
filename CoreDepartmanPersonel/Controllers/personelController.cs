using CoreDepartmanPersonel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CoreDepartmanPersonel.Controllers
{
    public class personelController : Controller
    {
        Context c = new Context();
        
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.personels.Include(x => x.depart).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.departmanlars.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.departmanad,
                                                 Value = x.departid.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }


        [HttpPost]
        public IActionResult YeniPersonel(personel p)
        {
            var per = c.departmanlars.Where(x => x.departid == p.depart.departid).FirstOrDefault();
            p.depart = per;
            c.personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult PersonelSil(int id)
        {
            var per = c.personels.Find(id);
            c.personels.Remove(per);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
