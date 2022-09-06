using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
		public HomeController(AppDbContext db)
		{
            _db = db;
		}

        public IActionResult Index()
        {
         
           
            
            HomeVM homeVM = new HomeVM
            {
                Sliders = _db.Sliders.ToList(),
                About = _db.Abouts.FirstOrDefault(),
                Courses= _db.Courses.OrderByDescending(x=>x.Id).Take(3).ToList(),  
                Video=_db.Video.FirstOrDefault(),
                Services=_db.Services.Where(x => !x.IsDeactive).ToList(),
                Feedbacks=_db.Feedbacks.FirstOrDefault(),
                Notices=_db.Notices.ToList()
            };
            return View(homeVM);    
        }

        
    }
}
