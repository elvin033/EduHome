using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }

        public About About { get; set; }

        public List<Course> Courses { get; set; }
        public Video Video { get; set; }

        public List<Service> Services { get; set; }
        public Feedback Feedbacks { get; set; }
        public List<Notice> Notices { get; set; }
    }
}
