﻿using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EduHome.Models.ViewComponents
{
    public class HeaderViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;
        public HeaderViewComponent(AppDbContext db)
        {
            _db=db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = await _db.Bios.FirstOrDefaultAsync();

            return View(bio);
            
        }
    }
}
