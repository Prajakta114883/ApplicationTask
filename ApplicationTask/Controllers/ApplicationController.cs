using ApplicationTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTask.Controllers
{
    public class ApplicationController : Controller
    {
        AppdbContext db;
        public ApplicationController(AppdbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewApplication()
        {
            return View();
        }
        public string AddNewApplication(Applicant ap)
        {
            db.Applicants.Add(ap);
            db.SaveChanges();
            return "Applicant Added Successfully!";
        }
    }
}
