using EduHome.DAL;
using EduHome.Helper;
using EduHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.XPath;
using Extensions = EduHome.Helper.Extensions;

namespace EduHome.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SlidersController : Controller
    {        
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public SlidersController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;      
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _db.Sliders.ToListAsync();
            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (slider.Photo==null)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa secin");
                return View();
            }
            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa secin");
                return View();
            }
            if (slider.Photo.IsOlder1MB())
            {
                ModelState.AddModelError("Photo", "Maksimum 1mb");
                return View();
            }

            
            string folder = Path.Combine(_env.WebRootPath, "img", "slider");
            slider.Image =await slider.Photo.SaveFileAsync(folder);
            await _db.Sliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            Slider dbslider = await _db.Sliders.FirstOrDefaultAsync(x=>x.Id==id);
            if (dbslider == null)
            {
                return BadRequest();
            }
            return View(dbslider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slider)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider dbslider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return View(dbslider);
            }
            if (slider.Photo != null)
            {
                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa secin");
                    return View(dbslider);
                }
                if (slider.Photo.IsOlder1MB())
                {
                    ModelState.AddModelError("Photo", "Maksimum 1mb");
                    return View(dbslider);
                }
                string folder = Path.Combine(_env.WebRootPath, "img", "slider");
                string path = Path.Combine(folder, dbslider.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                dbslider.Image = await slider.Photo.SaveFileAsync(folder);
            }
                        
            dbslider.Title = slider.Title;
            dbslider.SubTitle = slider.SubTitle;
            await _db.SaveChangesAsync();
            return RedirectToAction();
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider slider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (slider == null)
            {
                return BadRequest();
            }
            return View(slider);
        }

    }
}
