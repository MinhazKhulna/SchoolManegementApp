using Microsoft.AspNetCore.Mvc;
using SchoolManegementApp.Data;
using SchoolManegementApp.Models;

namespace SchoolManegementApp.Controllers
{
    public class StudentController : Controller
    {

        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Create()
        {
            return View();
        }


    }
}