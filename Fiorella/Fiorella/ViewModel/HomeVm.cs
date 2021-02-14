using Fiorella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.ViewModel
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; }
        public FlowerMainText FlowerMainText { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public Banner Banner { get; set; }

        public List<Expert> Experts { get; set; }

        public Search Search { get; set; }

        public List<Blog> Blogs { get; set; }

        public List<Minislide> Minislides { get; set; }

        public List<Instagram> Instagrams { get; set; }


    }
}
