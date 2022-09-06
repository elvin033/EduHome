using EduHome.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHome.DAL
{
	public class AppDbContext:DbContext
	{
        internal readonly object FooterVM;

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{

		}
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<About> Abouts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<FooterBio> FooterBios { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
		

    }
}
