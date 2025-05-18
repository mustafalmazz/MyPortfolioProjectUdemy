using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;
using System.Security.Cryptography.X509Certificates;

namespace MyPortfolioProject.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction(nameof(ExperienceList));
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction();
        }
    }
}
