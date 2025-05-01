using cmu_icdi_exam_chadapohn.Data;
using cmu_icdi_exam_chadapohn.Models;
using Microsoft.AspNetCore.Mvc;

namespace cmu_icdi_exam_chadapohn.Controllers
{
    public class BlogsController : Controller
    {
        private readonly ApplicationDBContext _db;

        public BlogsController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Blogs> blogs = _db.Blogs;
            return View(blogs);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blogs obj)
        {
            if (ModelState.IsValid)
            {
                _db.Blogs.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Display(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Blogs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Blogs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Blogs obj)
        {
            if (ModelState.IsValid)
            {
                _db.Blogs.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Blogs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Blogs.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
