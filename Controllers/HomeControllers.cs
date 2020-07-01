using System;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using System.Linq;

namespace Test.Controllers{
    public class HomeController: Controller
    {
        private IRepository repository;
        public HomeController(IRepository repo)=>
            this.repository = repo;
    

    public ViewResult Index(){
        int hour = DateTime.Now.Hour;
        ViewBag.Greeting = hour<12 ? "Good Morning" : "Good Afternoon";
        return View("MyView");
    }

    [HttpGet]
    public ViewResult RsvpForm() =>View();

    [HttpPost]
    public ViewResult RsvpForm (GuestResponse guestResponse){
        if (ModelState.IsValid)
        {
            repository.AddResponse(guestResponse);
            return View("Thanks",guestResponse);
        }else{
            return View();
        }
    }

    public ViewResult ListResponses() =>
        View(repository.Responses.Where(r=>r.WillAttend == true));
}
}