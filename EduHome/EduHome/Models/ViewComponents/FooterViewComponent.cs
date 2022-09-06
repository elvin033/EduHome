//using EduHome.DAL;
//using EduHome.ViewModel;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.IdentityModel.Tokens;
//using System.Linq;
//using System.Threading.Tasks;

//namespace EduHome.Models.ViewComponents
//{
//    public class FooterViewComponent : ViewComponent
//    {
//        private readonly AppDbContext _db;
//        public FooterViewComponent(AppDbContext db)
//        {
//            _db = db;
//        }
        
//        private async Task<IViewComponentResult> InvokeAsync()
//        {
//            FooterVM FooterVM = new FooterVM()
//            {
//                SocialMedias = await _db.SocialMedias.ToListAsync(),
//                Footerbio = await _db.FooterBios.FirstOrDefaultAsync(),
//            };
//            return View(FooterVM);
//        }
//    } 
//}
