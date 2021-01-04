using Microsoft.AspNetCore.Mvc;
using Registry.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Registry.Controllers
{
  public class CoursesController : Controller
  {
    private readonly CourseContext _db;
    public CoursesController(CourseContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Course> model = _db.Course.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Course course)
    {
      _db.Courses.Add(course);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


  }
}