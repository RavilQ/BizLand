using BizLand.Models;
using System.Collections.Generic;

namespace BizLand.ViewModels
{
    public class HomeViewModel
    {
       public List<Features> Feature { get; set; }
       public List<Services> Service { get; set; }
       public List<Testimonials> Testimonial { get; set; }
       public List<Team> Team { get; set; }
       public List<Portfolio> Portfolio { get; set; }
       public List<Pricing> Pricing { get; set; }
    }

}
