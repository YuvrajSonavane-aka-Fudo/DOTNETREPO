using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

public class HomeController : Controller
{
    // Index - Display Home Page with Projects and Skills
    public ActionResult Index()
    {
        var model = new PortfolioViewModel
        {
            Name = "Yuvraj Sonavane",
            Description = "Web Developer & Designer",
            Projects = new List<Project>
            {
                new Project
                {
                    Title = "Project 1",
                    Description = "A web application built with ASP.NET MVC.",
                    ImageUrl = "/Images/project1.jpg",
                    Link = "https://project1.com"
                },
                new Project
                {
                    Title = "Project 2",
                    Description = "A mobile app for managing tasks.",
                    ImageUrl = "/Images/project2.jpg",
                    Link = "https://project2.com"
                }
            },
            Skills = new List<Skill>
            {
                new Skill { Name = "ASP.NET MVC", Proficiency = 3 },
                new Skill { Name = "JavaScript", Proficiency = 2 },
                new Skill { Name = "HTML/CSS", Proficiency = 3 }
            }
        };
        return View(model);
    }

    // About - Display About Page
    public ActionResult About()
    {
        return View();
    }

    // Projects - Display All Projects
    public ActionResult Projects()
    {
        return View();
    }

    // Contact - Display Contact Form
    public ActionResult Contact()
    {
        return View(new ContactMessage());
    }

    // Handle Contact Form Submission
    [HttpPost]
    public ActionResult SubmitContactForm(ContactMessage message)
    {
        if (ModelState.IsValid)
        {
            // Here you can implement logic to handle the message (e.g., send email or save to a file)
            return RedirectToAction("Index");
        }
        return View("Contact");
    }
}
