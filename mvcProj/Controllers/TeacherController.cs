using mvcProj;
using mvcProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcProj.Controllers
{
    public class TeacherController : Controller {
        private readonly ApplicationDbContext _db;

        public TeacherController(ApplicationDbContext db)
        {
            _db = db;
        }
        // public IActionResult Index()
        // {
        //     IEnumerable<Teacher> listofteachers = _db.Teacher;
        //     return View(listofteachers);
        // }

        // querying searchString
        [HttpPost]
        public async Task<IActionResult> Index(string searchString)
        {
            var teachers = from t in _db.Teacher
                           select t;
            if(!String.IsNullOrEmpty(searchString))
            {
                teachers = teachers.Where(s => s.TeacherName!.Contains(searchString));
            }

            return View(await teachers.ToListAsync());

        }

        // direct searching without querying
        // public async Task<IActionResult> Index(string id)
        // {
        //     var teachers = from t in _db.Teacher
        //                    select t;
        //     if(!String.IsNullOrEmpty(id))
        //     {
        //         teachers = teachers.Where(s => s.TeacherName!.Contains(id));
        //     }

        //     return View(await teachers.ToListAsync());
        // }

        public IActionResult Create()
        {
            // PopulateSubjectsDropDownList(); 
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("TeacherName,TeacherSub")] Teacher teacherobj)
        {
            if (ModelState.IsValid)
            {
                _db.Teacher.Add(teacherobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teacherobj);
        }

        [HttpGet]
        public IActionResult Edit(int teacherid)
        {
            var teacherobj = _db.Teacher.Find(teacherid);
            return View(teacherobj);
        }

        [HttpPost] 
        public IActionResult Edit(Teacher updatedvaluesobj)
        {
            _db.Teacher.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int TeacherId)
        {
            var teacherobj = _db.Teacher.Find(TeacherId);
            return View(teacherobj);
        }

        [HttpPost]
        public IActionResult DeletePost(int teacherId)
        {
            var teacherobj = _db.Teacher.Find(teacherId);

            if(ModelState.IsValid)
            {
                _db.Teacher.Remove(teacherobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teacherobj);
        }

        
    }
}